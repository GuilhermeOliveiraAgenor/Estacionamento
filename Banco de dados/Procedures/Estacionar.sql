use Estacionamento
go

create or alter procedure Entrada
(
--parametros
@dataEntrada datetime ,
@CodigoClienteVeiculo int,
@Patio int


)
as


declare @cliente int;--seleciona o id do cliente pelo codigo do clienteVeiculo
select @cliente = idCliente from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente
where clienteVeiculo.IdClienteVeiculo = @CodigoClienteVeiculo

declare @vagas int;--seleciona quantas linhas que tem o idEstacionar no patio e vaga ocupada
select @vagas = COUNT(idEstacionar) from Estacionar where Patio = @Patio and Estacionar.Status = 'Ocupado'

declare @limite int;--seleciona o limite das vagas do patio
select @limite = Vagas from Patio where Patio.idPatio = @Patio


-- se tiver clientes que já estão no estacionados, retorna erro
if exists(select idCliente from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo where Cliente.idCliente = @cliente and Estacionar.Status = 'Ocupado')
begin 
raiserror ('O cliente já está no estacionamento',16,1)
return -1
end

if @vagas >= @limite--se as vagas ocupadas forem maiores ou igual ao limite do patio, retorna erro
begin
raiserror('Esse pátio está lotado',16,1)
return -1
end

if not exists (select IdClienteVeiculo from clienteVeiculo where IdClienteVeiculo = @CodigoClienteVeiculo)
begin
raiserror('O veículo selecionado não existe',16,1)
return -1
end

--insere
begin tran
insert into Estacionar(dataEntrada,Preco,CodigoClienteVeiculo,Patio,Status) values (@dataEntrada,'0.00',@CodigoClienteVeiculo,@Patio,'Ocupado')


if @@ERROR <> ''
rollback tran
else
commit tran
go




create or alter procedure Saida
(
--parametros
@idEstacionar int,
@dataSaida datetime,
@Preco decimal(10,2),
@CodigoFormaPagamento int


)
as


--insere
begin tran

--seleciona o email do cliente
declare @Email varchar(40);
select @Email = Email from Cliente inner join clienteVeiculo on Cliente.idCliente = clienteVeiculo.codigo_Cliente inner join Estacionar on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo where idEstacionar = @idEstacionar


--se existir esse id no pagamento, retorna erro
if exists (select codigoEstacionar from Pagamento where codigoEstacionar = @idEstacionar)
begin
raiserror ('O pagamento já foi feito nesse pedido',16,1)
return -1
end

--sessao nao existente
if not exists (select idEstacionar from Estacionar where idEstacionar = @idEstacionar)
begin
raiserror('Erro ao selecionar pedido',16,1)
return -1
end

--forma de pagamento que nao existe
if not exists (select idFormaPagamento from formaPagamento where idFormaPagamento = @CodigoFormaPagamento)
begin
raiserror('Erro ao selecionar forma de pagamento',16,1)
return -1
end

update Estacionar set dataSaida = @dataSaida,Preco = @Preco, Status = '-' where idEstacionar = @idEstacionar
insert into Pagamento (Preco,CodigoFormaPagamento,codigoEstacionar) values (@Preco,@CodigoFormaPagamento,@idEstacionar)

--email com informaçoes da sessão
declare @HTML varchar(MAX);
set @HTML = '
<html>
<head>
	<title>Informações</title>
	<style type="text/css">
        table { padding:0; border-spacing: 0; border-collapse: collapse; color:black; margin-left:auto; margin-right: auto;}
        thead { background: #48D1CC; border: 1px solid #ddd; color:black;}
        th { padding: 10px; font-weight: bold; border: 1px solid ; color: #191970; background-color: #20b2aa; text-align: center; font-size: 18px; }
        tr { padding: 0;}
        td { padding: 5px; border: 1px solid #cacaca; margin:0; color:black; text-align: center; font-size: 15px;}
		div {text-align: center; font-family: Cambria,Georgia,serif;}
		h1 {font-size: 35px; text-decoration: underline solid rgb(32,178,170);}
		h2 {font-size: 25px;}
		p  {font-size: 20px;}
		h3 {text-align: left; font-size: 20px;}
	</style>
</head>
<div>
<h1>Estacionamento AlfaPark</h1>
<h2>Olá. Tudo bem ? Estou passando aqui para deixar informações do seu atendimento</h2>
<p> É uma alegria ter um cliente como você. Nós nos dedicamos ao máximo, porque temos você ao nosso lado! Obrigado pela confiança! </p>
<br>
<br>
<br>
<h3>Segue as informações abaixo:</h3>
<table>
  <thead>
		<tr>
			<th>Código</th>
			<th>Data Entrada</th>
			<th>Hora Entrada</th>
			<th>Data Saída</th>
			<th>Hora Saída</th>
			<th>Placa</th>
			<th>Preço</th>
			<th>Forma de Pagamento</th>
		</tr>
   </thead>
   <tbody>' +
	CAST (
	( 
	/*select do email*/--107 data ,108 hora,113 dia e hora
	select
    td = Estacionar.idEstacionar,'',
	td = CONVERT(VARCHAR(19), Estacionar.dataEntrada,107),'',
	td = CONVERT(VARCHAR(19), Estacionar.dataEntrada,108),'',
	td = CONVERT(VARCHAR(19), Estacionar.dataSaida,107),'',
	td = CONVERT(VARCHAR(19), Estacionar.dataSaida,108),'',
	td = clienteVeiculo.Placa,'',
	td = Estacionar.Preco,'',
	td = formaPagamento.descricao
	from Estacionar
	inner join clienteVeiculo
	on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo
	inner join Pagamento
	on Estacionar.idEstacionar = Pagamento.codigoEstacionar
	inner join formaPagamento
	on formaPagamento.idFormaPagamento = Pagamento.CodigoFormaPagamento
	where idEstacionar = @idEstacionar
	for XML PATH('tr'), type
	) as nvarchar(MAX) ) + '
	</tbody>
</table>
</div>
'


/*Procedure de enviar email*/
exec msdb.dbo.sp_send_dbmail
     @profile_name = 'Estacionamento_perfil',
     @recipients = @Email, 
	 @subject = 'Informações da sua sessão no Alfa Park',
	 @body = @HTML,
	 @body_format = 'html'


if @@ERROR <> ''
rollback tran
else
commit tran
go



create or alter procedure alterarEstacionar
(
@idEstacionar int,--parametros
@CodigoClienteVeiculo int,
@Patio int

)
as


declare @vagas int;--seleciona quantas linhas que tem o idEstacionar no patio e vaga ocupada
select @vagas = COUNT(idEstacionar) from Estacionar where Patio = @Patio and Estacionar.Status = 'Ocupado'

declare @limite int;--seleciona o limite das vagas do patio
select @limite = Vagas from Patio where Patio.idPatio = @Patio


if @vagas >= @limite--se as vagas ocupadas forem maiores ou igual ao limite do patio, retorna erro
begin
raiserror('Esse pátio está lotado',16,1)
return -1
end

--veiculo nao existente
if not exists (select IdClienteVeiculo from clienteVeiculo where IdClienteVeiculo = @CodigoClienteVeiculo)
begin
raiserror('O veículo selecionado não existe',16,1)
return -1
end

--sessao que nao existe
if not exists (select idEstacionar from Estacionar where idEstacionar = @idEstacionar)
begin
raiserror('Erro ao selecionar pedido',16,1)
return -1
end


--insere
begin tran
update Estacionar set CodigoClienteVeiculo = @CodigoClienteVeiculo, Patio = @Patio where idEstacionar = @idEstacionar 


if @@ERROR <> ''
rollback tran
else
commit tran
go


create or alter procedure excluirEstacionar
(
@idEstacionar int--parametro
)
as

--sessao que nao existe
if not exists (select idEstacionar from Estacionar where idEstacionar = @idEstacionar)
begin
raiserror('Erro ao selecionar pedido',16,1)
return -1
end

--deleta
begin tran
delete Estacionar from Estacionar where idEstacionar = @idEstacionar


if @@ERROR <> ''
rollback tran
else
commit tran
go

