use Estacionamento
go

create or alter procedure Entrada
(
--parametros
@horarioEntrada time ,
@dataEntrada date,
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
raiserror('Esse patio esta lotado',16,1)
return -1
end




--insere
begin tran
insert into Estacionar(horarioEntrada,dataEntrada,Preco,CodigoClienteVeiculo,Patio,Status) values (@horarioEntrada,@dataEntrada,'0.00',@CodigoClienteVeiculo,@Patio,'Ocupado')


if @@ERROR <> ''
rollback tran
else
commit tran
go




create or alter procedure Saida
(
--parametros
@idEstacionar int,
@horarioSaida time,
@dataSaida date,
@Preco decimal(6,2),
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
raiserror ('O pagamento ja foi feito nesse pedido',16,1)
return -1
end


update Estacionar set horarioSaida = @horarioSaida, dataSaida = @dataSaida,Preco = @Preco, Status = '-' where idEstacionar = @idEstacionar
insert into Pagamento (Preco,CodigoFormaPagamento,codigoEstacionar) values (@Preco,@CodigoFormaPagamento,@idEstacionar)

--email com informaçoes da sessão
declare @HTML varchar(MAX);
set @HTML = '
<html>
<head>
	<title>Informações</title>
	<style type="text/css">
        table { padding:0; border-spacing: 0; border-collapse: collapse; color:black;}
        thead { background: #48D1CC; border: 1px solid #ddd; color:black;}
        th { padding: 10px; font-weight: bold; border: 1px solid ; color: #191970; background-color: #20b2aa}
        tr { padding: 0; }
        td { padding: 5px; border: 1px solid #cacaca; margin:0; color:black; text-align: center; }
	</style>
</head>
<h2>Olá. Tudo bem ? Estou passando aqui para deixar informações do seu atendimento</h2>
<p>Obrigado por confiar na nossa equipe! Nós fazemos o melhor possível para atender você </p>
<h3>Segue as informações abaixo</h3>
<table>
  <thead>
		<tr>
			<th>Hora Entrada</th>
			<th>Hora Saida</th>
			<th>Data Entrada</th>
			<th>Data Saida</th>
			<th>Placa</th>
			<th>Preco</th>
			<th>Forma de Pagamento</th>
		</tr>
   </thead>
   <tbody>' +
	CAST (
	( 
	/*select do email*/
	select
	td = Estacionar.horarioEntrada,'',
	td = Estacionar.horarioSaida,'',
    td = CONVERT(VARCHAR(19), Estacionar.dataEntrada, 103),'',
	td = CONVERT(VARCHAR(19), Estacionar.dataSaida, 103),'',
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
raiserror('Esse patio esta lotado',16,1)
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


--deleta
begin tran
delete Estacionar from Estacionar where idEstacionar = @idEstacionar


if @@ERROR <> ''
rollback tran
else
commit tran
go

