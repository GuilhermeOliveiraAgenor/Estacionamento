use Estacionamento
go

--Inserir clienteVeiculo
create or alter procedure InserirClienteVeiculo
(
--paramêtros
@Nome varchar(150),
@Cpf varchar (11),
@Email varchar(100),
@Placa varchar(10),
@codigo_Veiculo int

)
as


declare @id int -- define scopeidentity do cliente


--placa que ja existe
if exists (select Placa from clienteVeiculo where Placa = @Placa)
begin
raiserror ('Veiculo já existe',16,1)
return -1
end


--cpf ja existe
if exists (select Cpf from Cliente where Cpf = @Cpf)
begin
raiserror ('O Cpf já existe', 16,1)
return -1
end

--email ja existe
if exists (select Email from Cliente where Email = @Email)
begin
raiserror('O Email já existe',16,1)
return -1
end

--veiculo nao existe
if not exists (select idVeiculo from Veiculo where idVeiculo = @codigo_Veiculo)
begin
raiserror('O Veículo selecionado não existe',16,1)
return -1
end

begin tran--insere
insert into Cliente (Nome,Cpf,Email) values (@Nome,@Cpf,@Email)

set @id = SCOPE_IDENTITY();--pega o id identity da tabela cliente

insert into clienteVeiculo (Placa, codigo_Cliente,codigo_Veiculo) values (@Placa, @id,@codigo_Veiculo)

if @@ERROR <> ''
rollback tran
else
commit tran
go



create or alter procedure InserirVeiculoCv
(
@codigo_Veiculo int,--parametros
@Placa varchar(10),
@Cpf varchar(11)

)
as

declare @id int;
select @id = idCliente from Cliente where Cpf = @Cpf--seleciona o id do cliente pelo cpf


if exists (select Placa from clienteVeiculo where Placa = @Placa)-- se existir essa placa, retorna erro
begin
raiserror ('A placa já existe',16,1)
return -1
end

--se nao existir cpf, retorna erro
if not exists (select Cpf from Cliente where Cpf = @Cpf)
begin 
raiserror ('O cpf não existe',16,1)
return -1 
end

--veiculo nao existe
if not exists (select idVeiculo from Veiculo where idVeiculo = @codigo_Veiculo)
begin
raiserror('O Veículo selecionado não existe',16,1)
return -1
end

--insere
begin tran
insert into clienteVeiculo (Placa,codigo_Cliente, codigo_Veiculo) values (@Placa, @id,@codigo_Veiculo)

if @@ERROR <> ''
rollback tran
else
commit tran
go





