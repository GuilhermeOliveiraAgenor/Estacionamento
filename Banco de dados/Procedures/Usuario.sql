use Estacionamento
go

create or alter procedure alterarSenha


(
--paramêtros

@Cpf varchar(11),
@Senha varchar(50)

)

as

declare @idUsuario int;
select @idUsuario = idUsuario from Usuario where Cpf = @Cpf;

--senha existente
if exists(select Senha from Usuario where Senha = @Senha and idUsuario = @idUsuario)
begin
raiserror('Essa senha já existe',16,1)
return -1
end

--cpf que nao existe
if not exists (select Cpf from Usuario where Cpf = @Cpf)
begin
raiserror('Cpf não encontrado',16,1)
return -1
end


begin tran--insere
update Usuario set Senha = @Senha where idUsuario = @idUsuario


if @@ERROR <> ''
rollback tran
else
commit tran
go


