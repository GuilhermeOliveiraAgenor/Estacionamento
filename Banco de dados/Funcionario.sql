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
@Salario decimal (10,2)


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
insert into Funcionario (primeiroNome,Sobrenome,Cpf,Rg,Profissao,Salario) values (@primeiroNome,@Sobrenome,@Cpf,@Rg,@Profissao,@Salario)


if @@ERROR <> ''
rollback tran
else
commit tran
go




