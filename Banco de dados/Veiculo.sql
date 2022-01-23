use Estacionamento
go

--Inserir veiculo
create or alter procedure inserirVeiculo
(
--paramêtros
@Categoria varchar(20),
@Marca varchar (20),
@descricaoVeiculo varchar(40),
@Cor varchar(20)

)
as

--veiculo que ja existe
if exists (select descricaoVeiculo from Veiculo where descricaoVeiculo = @descricaoVeiculo)
begin
raiserror ('Veiculo já existe',16,1)
return -1
end

begin tran--insere
insert into Veiculo (Categoria,Marca,descricaoVeiculo,Cor) values (@Categoria,@Marca,@descricaoVeiculo,@Cor)

if @@ERROR <> ''
rollback tran
else
commit tran
go
