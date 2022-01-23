use Estacionamento

create or alter procedure inserirVaga
(
@descricao varchar(10),
@Patio varchar(10)
)
as

declare @vaga int;
select @vaga = count(Patio) from Vaga where Patio = @Patio--seleciona quantas vagas estão cadastradas no patio

declare @limite int;
select @limite = Vagas from Patio where Patio.Patio = @Patio--seleciona o limite de vagas que tem cada patio


if @vaga >= @limite--se o total de vagas cadastradas for maior ou igual ao limite do patio, retorna erro
begin 
raiserror('As vagas estao cheias',16,1)
return -1
end

--insere
begin tran
insert into Vaga(descricao,Patio) values (@descricao,@Patio)
	

if @@ERROR <> ''
rollback tran
else
commit tran
go







