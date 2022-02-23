use Estacionamento
go

create or alter procedure inserirFuncionario

(
--paramêtros
@primeiroNome varchar(60),
@Sobrenome varchar(100),
@Cpf varchar(11),
@Rg varchar(20),
@Profissao varchar(40),
@Salario decimal (10,2),
@Foto varbinary(MAX)



)
as

declare @codigoFuncionario int--declara a variável código do cliente

--cpf ja existe
if exists (select Cpf from Funcionarios where Cpf = @Cpf)
begin
raiserror ('O Cpf já existe',16,1)
return -1
end

--rg ja existe
if exists (select Rg from Funcionarios where Rg = @Rg)
begin
raiserror ('O Rg já existe',16,1)
return -1
end

begin tran--insere
insert into Funcionarios (primeiroNome,Sobrenome,Cpf,Rg,Profissao,Salario,Foto) values (@primeiroNome,@Sobrenome,@Cpf,@Rg,@Profissao,@Salario,@Foto)

set @codigoFuncionario = SCOPE_IDENTITY()--pega o id identity da tabela funcionario

insert into Usuario (Cpf,Senha,Acesso,codigoFuncionario) values (@Cpf,'estacionamento123','1',@codigoFuncionario)--insere usuario com senha provisória


if @@ERROR <> ''
rollback tran
else
commit tran
go



create or alter procedure alterarFuncionario
(
@idFuncionario int,
@primeiroNome varchar(60),
@Sobrenome varchar(100),
@Rg varchar(20),
@Profissao varchar(40),
@Salario decimal (10,2),
@Acesso int

)
as

declare @idUsuario int;
select @idUsuario = idUsuario from Usuario where codigoFuncionario = @idFuncionario

--rg ja existe
if exists (select Rg from Funcionarios where Rg = @Rg and idFuncionario != @idFuncionario and Rg != '')
begin
raiserror ('O Rg já existe',16,1)
return -1
end



--altera
begin tran
update Funcionarios set primeiroNome = @primeiroNome, Sobrenome = @Sobrenome, Rg = @Rg, Profissao = @Profissao, Salario = @Salario where idFuncionario = @idFuncionario
update Usuario set Acesso = @Acesso where idUsuario = @idUsuario

if @@ERROR <> ''
rollback tran
else 
commit tran
go


create or alter procedure alterarFoto
(
@idFuncionario int,
@Foto varbinary(MAX)

)
as

--altera
begin tran
update Funcionarios set Foto = @Foto where idFuncionario = @idFuncionario

if @@ERROR <> ''
rollback tran
else 
commit tran
go




create or alter procedure excluirFuncionario
(
@idFuncionario int
)
as

--exclui
begin tran

delete Usuario from Usuario where codigoFuncionario = @idFuncionario
delete Funcionarios from Funcionarios where idFuncionario = @idFuncionario


if @@ERROR <> ''
rollback tran
else
commit tran
go	


exec excluirFuncionario
@idFuncionario = '7'



