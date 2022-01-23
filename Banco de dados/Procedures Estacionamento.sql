use Estacionamento


-- Inserir cliente
create or alter procedure inserirCliente
(

@Nome varchar(60),
@dataNasc date,
@Cpf varchar (11),
@Rg varchar(20),
@Celular varchar(20)

)
as

--Cpf ja existe
if exists (select Cpf from Cliente where Cpf = @Cpf)
begin
raiserror ('O Cpf ja existe', 16,1)
return -1
end

--Rg ja existe
if exists (select Rg from Cliente where Rg = @Rg)
begin
raiserror('O Rg ja existe',16,1)
return -1
end

begin tran
insert into Cliente (Nome,dataNasc,Cpf,Rg,Celular) values (@Nome,@dataNasc,@Cpf,@Rg,@Celular)


if @@ERROR <> ''
rollback tran
else
commit tran
go





