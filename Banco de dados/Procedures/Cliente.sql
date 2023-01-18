use Estacionamento
go
-- Inserir cliente
create or alter procedure inserirCliente
(
--parâmetros

@Nome varchar(150),
@Cpf varchar (11), 
@Email varchar(100)

)
as

--Cpf ja existe
if exists (select Cpf from Cliente where Cpf = @Cpf)
begin
raiserror ('O Cpf já existe', 16,1)
return -1
end

--Email ja existe
if exists (select Email from Cliente where Email = @Email)
begin
raiserror('O Email já existe',16,1)
return -1
end

begin tran--insere
insert into Cliente (Nome,Cpf,Email) values (@Nome,@Cpf,@Email)


if @@ERROR <> ''
rollback tran
else
commit tran
go



create or alter procedure editarCliente
(

@idCliente int,
@Nome varchar(150),
@Email varchar(100)

)
as

--Email ja existe
if exists (select Email from Cliente where Email = @Email and idCliente != @idCliente)
begin
raiserror('O Email já existe',16,1)
return -1
end

begin tran
update Cliente set Nome = @Nome, Email = @Email where idCliente = @idCliente


if @@ERROR <> ''
rollback tran
else
commit tran
go

