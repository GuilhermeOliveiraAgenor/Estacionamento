create database Estacionamento
go
use Estacionamento
go
/*Guilherme*/


create table Cliente
(

idCliente int identity primary key, 
Nome varchar(150),
Cpf varchar (11), 
Email varchar(100),

)	
	
create table Veiculo
(
idVeiculo int identity primary key,
Categoria varchar(20),
Marca varchar (20),
descricaoVeiculo varchar(40),
Cor varchar(20)

)

create table clienteVeiculo
(
IdClienteVeiculo int identity primary key,
Placa varchar(10),

)

create table Estacionar
(

idEstacionar int identity primary key,
horarioEntrada time ,
horarioSaida time,
dataEntrada date,
dataSaida date,
Preco decimal(6,2),
Status varchar(11) check (Status = 'Ocupado' or Status = '-')

)

create table Patio
(

idPatio int identity primary key,
Patio varchar (1),
Vagas int


)

create table Vaga
(

idVaga int identity primary key,
descricao varchar(10),


)

create table Funcionarios
(

idFuncionario int identity primary key,
primeiroNome varchar(60),
Sobrenome varchar(100),
Cpf varchar(11),
Rg varchar(20),
Profissao varchar(40),
Salario decimal (10,2),
Foto varbinary(MAX)

)


create table Pagamento
(
idPagamento int identity primary key,
Preco decimal(6,2)

)

create table formaPagamento
(
idFormaPagamento int identity primary key,
descricao varchar(30),

)

create table nivelAcesso 
(
idNivelAcesso int primary key,
Nivel varchar(40)

)

create table Usuario
(
idUsuario int identity primary key,
Cpf varchar(11),
Senha varchar(50),

)


--Adicionar chaves estrangeiras nas tabelas


alter table Estacionar add CodigoClienteVeiculo int
alter table Estacionar add foreign key (CodigoClienteVeiculo) references clienteVeiculo(IdClienteVeiculo) 

alter table Estacionar add Patio int
alter table Estacionar add foreign key (Patio) references Patio(idPatio)

alter table Pagamento add CodigoFormaPagamento int
alter table Pagamento add foreign key (CodigoFormaPagamento) references formaPagamento(idFormaPagamento)

alter table Pagamento add codigoEstacionar int
alter table Pagamento add foreign key (codigoEstacionar) references Estacionar(idEstacionar)

alter table Vaga add Patio int
alter table Vaga add foreign key (Patio) references Patio(idPatio)

alter table clienteVeiculo add codigo_Cliente int
alter table clienteVeiculo add foreign key (codigo_Cliente) references Cliente(idCliente)

alter table clienteVeiculo add codigo_Veiculo int
alter table clienteVeiculo add foreign key (codigo_Veiculo) references Veiculo(idVeiculo)

alter table Usuario add Acesso int
alter table	Usuario add foreign key (Acesso) references nivelAcesso(idNivelAcesso)

alter table Usuario add codigoFuncionario int
alter table Usuario add foreign key (codigoFuncionario) references Funcionarios(idFuncionario)


go


-- Insert
insert into Cliente (Nome,Cpf,Email) values ('Roberto','547547','mandrakeguizao@gmail.com')
insert into Veiculo (Categoria,Marca,descricaoVeiculo,Cor) values ('Carro','Chevrolet','Corsa','Preto')
insert into Patio (Patio) values ('1')
insert into Patio (Patio) values ('3')
insert into Vaga (descricao,Patio) values ('Padrão','1')
insert into Vaga (descricao,Patio) values ('Padrão','1')
insert into Vaga (descricao,Patio) values ('Padrão','2')
insert into Vaga (descricao,Patio) values ('Padrão','2')
insert into Estacionar (horarioEntrada,horarioSaida,dataEntrada,dataSaida,codigoCliente,Patio,codigoVeiculo,Preco,Patio) values ('18:30','19:30','10/06/2020','10/06/2020','1','1','1','5.00','1')
insert into Funcionarios (primeiroNome,Sobrenome,Cpf,Rg,Profissao,Salario) values ('urur','ururt','456546','797768','Cobrador','54754')
insert into Cliente (Nome,dataNasc,Cpf,Rg,Celular) values ('Alberto','10/10/1976','75278562','732752732', '93475347')
insert into Veiculo (Categoria,Marca,descricaoVeiculo,Cor) values ('Volksvagen','Sedan','Fusca','Azul')
insert into Veiculo (Categoria,Marca,descricaoVeiculo,Cor) values ('Volksvagen','Sedan','Celta','Verde')
insert into Estacionar (horarioEntrada,horarioSaida,dataEntrada,dataSaida,CodigoClienteVeiculo,Patio,Preco,Status) values ('18:30','00:00','20/01/2022','05/03/2021','1','2','10.00','-')
insert into Cliente (Nome,dataNasc,Cpf,Rg,Celular) values ('Joao','18/07/1987','945376','894647', '994854794')
insert into Veiculo (Categoria,Marca,descricaoVeiculo,Cor) values ('Chevrolet','Sedan','a','Preto')
insert into Estacionar (horarioEntrada,horarioSaida,dataEntrada,dataSaida,codigoCliente,Patio,codigoVeiculo,Preco,Patio) values ('16:00','00:00','20/10/2020','20/10/2020','1','2','1','5.00','1')
insert into Cliente (Nome,dataNasc,Cpf,Rg,Celular) values ('iytuy','18/07/1987','8657','894647', '994854794')
insert into formaPagamento (descricao) values ('Débito')
insert into nivelAcesso(idNivelAcesso,Nivel) values ('1','Funcionário')
insert into nivelAcesso(idNivelAcesso,Nivel) values ('2','Administrador')
insert into Usuario(Cpf, Senha, Acesso,codigoFuncionario) values ('456546','ola','1','1')


select Patio.Vagas - (select COUNT(idEstacionar) from Estacionar where Patio = '1' and Estacionar.Status = 'Ocupado') from Patio where Patio.Patio = '1'

select Patio.Vagas - (select COUNT(idEstacionar) from Estacionar where Patio = '2' and Estacionar.Status = 'Ocupado') from Patio where Patio.Patio = '2'


/*Consultas*/

select clienteVeiculo.Placa,clienteVeiculo.IdClienteVeiculo,clienteVeiculo.codigo_Cliente,clienteVeiculo.codigo_Veiculo 
from clienteVeiculo 
inner join Cliente 
on Cliente.idCliente = clienteVeiculo.codigo_Cliente
where Cliente.Cpf = @Cpf

select Cliente.Nome, Cliente.Cpf, Veiculo.descricaoVeiculo, Veiculo.Cor, clienteVeiculo.Placa, Estacionar.idEstacionar,Estacionar.horarioEntrada, Estacionar.horarioSaida, Estacionar.dataEntrada, Estacionar.dataSaida, Estacionar.Preco, Estacionar.Patio 
from Cliente 
inner join clienteVeiculo 
on Cliente.idCliente = clienteVeiculo.codigo_Cliente
inner join Estacionar 
on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo
inner join Veiculo 
on Veiculo.idVeiculo = clienteVeiculo.codigo_Veiculo 
where Cliente.Cpf = @Cpf and Estacionar.Status = 'Ocupado'

drop table Cliente
drop table clienteVeiculo
drop table Estacionar
drop table Pagamento
drop table formaPagamento
drop table Funcionarios
drop table Usuario
drop table nivelAcesso

delete Estacionar from Estacionar where idEstacionar = '12'

-- Selecionar carros que sejam corsas
select Cliente.Nome, Cliente.Cpf, Veiculo.Placa,Veiculo.Categoria,Veiculo.Cor, Estacionar.idEstacionar
from Cliente
inner join Estacionar
on Cliente.idCliente = Estacionar.codigoCliente
inner join Veiculo
on Veiculo.idVeiculo = Estacionar.codigoVeiculo 
where Veiculo.Categoria ='Carro' and Veiculo.descricaoVeiculo = 'Corsa'


-- Clientes na data de hoje
select Cliente.idCliente,Cliente.Nome,Veiculo.idVeiculo,Veiculo.Categoria,Veiculo.Placa,Estacionar.horarioEntrada,Estacionar.horarioSaida,Estacionar.dataEntrada,Estacionar.dataSaida,Estacionar.Preco,Patio.Patio
from Cliente 
left join Veiculo  on Cliente.idCliente = Veiculo.codigo_Cliente 
left join Estacionar on Cliente.idCliente= Estacionar.codigoCliente 
left join Patio on Patio.idpatio = Estacionar.Patio   
where Dataentrada between CONVERT(date,GETDATE()) and Dataentrada order by Cliente.idCliente
  
--Selects gerais
select *from clienteVeiculo
select *from Cliente
select *from Veiculo
select *from Funcionarios
select *from Patio
select *from Estacionar 
select *from Vaga
select *from Pagamento
select *from formaPagamento 
select *from Usuario
select *from nivelAcesso

select Estacionar.horarioEntrada, Estacionar.horarioSaida, Estacionar.dataEntrada, Estacionar.dataSaida, Pagamento.Preco, formaPagamento.descricao, clienteVeiculo.Placa
from Estacionar 
inner join clienteVeiculo 
on clienteVeiculo.IdClienteVeiculo = Estacionar.CodigoClienteVeiculo
inner join Pagamento
on Estacionar.idEstacionar = Pagamento.codigoEstacionar
inner join formaPagamento
on formaPagamento.idFormaPagamento = Pagamento.CodigoFormaPagamento
where Estacionar.idEstacionar = '5'




