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

--cpf ja existe
if exists (select Cpf from Funcionario where Cpf = @Cpf)
begin
raiserror ('O Cpf já existe',16,1)
return -1
end

--rg ja existe
if exists (select Rg from Funcionario where Rg = @Rg)
begin
raiserror ('O Rg já existe',16,1)
return -1
end

begin tran--insere
insert into Funcionario (primeiroNome,Sobrenome,Cpf,Rg,Profissao,Salario,Foto) values (@primeiroNome,@Sobrenome,@Cpf,@Rg,@Profissao,@Salario,@Foto)


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
@Foto varbinary(MAX)

)
as


--altera
begin tran
update Funcionario set primeiroNome = @primeiroNome, Sobrenome = @Sobrenome, Rg = @Rg, Profissao = @Profissao, Salario = @Salario, Foto = @Foto where idFuncionario = @idFuncionario

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

delete Funcionario from Funcionario where idFuncionario = @idFuncionario

if @@ERROR <> ''
rollback tran
else
commit tran
go	



