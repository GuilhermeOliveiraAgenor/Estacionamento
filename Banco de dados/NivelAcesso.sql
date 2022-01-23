use Estacionamento

create or alter procedure InserirNivelAcesso
(
@Nivel varchar(40)--parametro

)
as

--se existir esse nivel, retorna erro
if exists(select Nivel from nivelAcesso where Nivel = @Nivel)
begin
raiserror('Esse nivel ja existe',16,1)
return -1
end


--insere
begin tran
insert into nivelAcesso(Nivel) values (@Nivel)


if @@ERROR <> ''
rollback tran
else
commit tran
go

