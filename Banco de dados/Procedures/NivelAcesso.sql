use Estacionamento
go

create or alter procedure InserirNivelAcesso
(

@idNivelAcesso int,
@Nivel varchar(40)--parametro

)
as


--se existir esse id, retorna erro
if exists(select idNivelAcesso from nivelAcesso where idNivelAcesso = @idNivelAcesso)
begin
raiserror('Esse nivel já existe',16,1)
return -1
end

--se existir esse nivel, retorna erro
if exists(select Nivel from nivelAcesso where Nivel = @Nivel)
begin
raiserror('Esse nivel já existe',16,1)
return -1
end


--insere
begin tran
insert into nivelAcesso(idNivelAcesso,Nivel) values (@idNivelAcesso,@Nivel)


if @@ERROR <> ''
rollback tran
else
commit tran
go

