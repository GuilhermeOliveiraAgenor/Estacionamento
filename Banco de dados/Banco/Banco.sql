create database Estacionamento
go
use Estacionamento
go
/*Guilherme Oliveira Agenor*/

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
Categoria varchar(20) check (Categoria = 'Carro' or Categoria = 'Moto' or Categoria = 'Veículo'),
Marca varchar (20),
descricaoVeiculo varchar(40),

)

create table clienteVeiculo
(
IdClienteVeiculo int identity primary key,
Placa varchar(10),

)

create table Estacionar
(

idEstacionar int identity primary key,
dataEntrada datetime,
dataSaida datetime,
Preco decimal(10,2),
Status varchar(11) check (Status = 'Ocupado' or Status = '-')

)

create table Patio
(

idPatio int identity primary key,
Patio varchar (1),
Vagas int


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
Preco decimal(10,2)

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

alter table clienteVeiculo add codigo_Cliente int
alter table clienteVeiculo add foreign key (codigo_Cliente) references Cliente(idCliente)

alter table clienteVeiculo add codigo_Veiculo int
alter table clienteVeiculo add foreign key (codigo_Veiculo) references Veiculo(idVeiculo)

alter table Usuario add Acesso int
alter table	Usuario add foreign key (Acesso) references nivelAcesso(idNivelAcesso)

alter table Usuario add codigoFuncionario int
alter table Usuario add foreign key (codigoFuncionario) references Funcionarios(idFuncionario)

								
-- Insert
insert into Patio (Patio,Vagas) values ('1','5')
insert into Patio (Patio,Vagas) values ('2','10')
insert into formaPagamento (descricao) values ('Dinheiro')
insert into formaPagamento (descricao) values ('Crédito')
insert into formaPagamento (descricao) values ('Débito')
insert into formaPagamento (descricao) values ('Pix')
insert into nivelAcesso(idNivelAcesso,Nivel) values ('1','Funcionário')
insert into nivelAcesso(idNivelAcesso,Nivel) values ('2','Administrador')
insert into Usuario(Cpf, Senha, Acesso) values ('12451532443','administrador_gerente123','2')
insert into Cliente (Nome,Cpf,Email) values ('Roberto','41241241241','mandrakeguizao@gmail.com')
insert into Cliente (Nome,Cpf,Email) values ('Luiz Alves','86575474545','luiz.10alves@gmail.com')
insert into Cliente (Nome,Cpf,Email) values ('Lucas Rodrigues','94636524123','rodrigues_lucas@gmail.com')
insert into Cliente (Nome,Cpf,Email) values ('Murilo Silva','85436543675','murilo1012silva@gmail.com')
insert into Cliente (Nome,Cpf,Email) values ('Gabriel Rodrigues Magalhães','76542546765','gabrielmagalhães@gmail.com')
insert into Veiculo (Categoria,Marca,descricaoVeiculo) values ('Carro','Chevrolet','Celta'),('Carro','Chevrolet','Prisma'),
('Carro','Chevrolet','Onix'),('Carro','Hyundai','HB20'),('Carro','Ford','Ford KA'),('Carro','Volkswagen','Gol'),('Carro','Fiat','Strada'),
('Carro','Renault','Sandero'),('Carro','Volkswagen','Fox'),('Carro','Fiat','Palio'),
('Carro','Fiat','Uno'),('Carro','Hyundai','Creta'),('Carro','Volkswagen','Fusca'),('Carro','Volkswagen','Voyage'),
('Carro','Volkswagen','Saveiro'),('Carro','Chevrolet','Classic'),('Carro','Fiat','Siena'),('Carro','Ford','Fiesta'),('Carro','Honda','Civic'),
('Carro','Volkswagen','Polo'),('Carro','Volkswagen','Amarok'),('Carro','Volkswagen','Jetta'),('Carro','Volkswagen','Corsa'),
('Carro','Chevrolet','Spin'),('Carro','Chevrolet','S10'),('Carro','Chevrolet','Monza'),('Carro','Chevrolet','Vectra'),
('Carro','Chevrolet','Cruze'),('Carro','Volkswagen','SpaceFox'),('Carro','Volkswagen','Parati'),('Carro','Fiat','Fiorino'),('Carro','Fiat','Argo'),
('Carro','Renault','Clio'),('Carro','Renault','Duster'),('Carro','Renault','Fluence'),('Carro','Renault','Grand Tour'),('Carro','Renault','Logan'),
('Carro','Renault','Megane'),('Carro','Renault','Scénic'),('Carro','Renault','Kwid'),('Moto','Honda','America Classic'),('Moto','Honda','Biz'),
('Moto','Honda','CB'),('Moto','Honda','Hornet'),('Moto','Honda','CB 1300'),('Moto','Honda','CBR'),('Moto','Honda','CBX 200 Strada'),
('Moto','Honda','250 Twister'),('Moto','Honda','CG 125'),('Moto','Honda','CRF'),('Moto','Honda','Bros'),('Moto','Honda','XR'),('Moto','Honda','XRE'),
('Moto','Honda','CB 1000'),('Moto','Honda','CG 160 Fan'),('Moto','Honda','CG 160 Titan'),('Moto','Honda','CG 150 Titan'),('Moto','Honda','CG 125 Titan'),
('Moto','Yamaha','FZR'),('Moto','Yamaha','FZ6'),('Moto','Yamaha','Jog'),('Moto','Yamaha','MT 0'),('Moto','Yamaha','XT'),('Moto','Yamaha','XJ6'),
('Moto','Yamaha','XTZ'),('Moto','Yamaha','YBR'),('Moto','Yamaha','Factor'),('Moto','BMW','BMW'),('Moto','Harley Davidson','Harley Davidson'),
('Veículo','-','Outro')
insert into clienteVeiculo (Placa,codigo_Cliente, codigo_Veiculo) values ('IFU8779','1','7'),('KAS7478','1','1'),('AZI6787','2','21'),('ANS9983','2','14'), 
('IAS9897','3','25'),('OSK9576','4','10'),('KSN9323','4','42'),('BSK8768','5','37')
insert into Estacionar (dataEntrada,dataSaida,CodigoClienteVeiculo,Patio,Preco,Status) values 
('17:00:00 20/02/2022','19:00:00 20/02/2022','1','1','18.00','-'),
('12:00:00 10/02/2022','13:00:00 10/02/2022','1','1','09.00','-'),
('12:00:00 20/02/2022','13:00:00 20/02/2022','1','1','09.00','-'),
('10:00:00 15/02/2022','12:30:00 15/02/2022','2','1','22.50','-'),
('10:00:00 12/02/2022','12:00:00 12/02/2022','2','2','18.00','-'),
('10:00:00 10/02/2022','19:00:00 10/02/2022','2','2','81.00','-'),
('10:00:00 20/02/2022','18:00:00 20/02/2022','3','2','72.00','-'),
('10:00:00 20/01/2022','16:00:00 20/01/2022','3','2','54.00','-'),
('10:00:00 20/01/2022','19:00:00 20/01/2022','3','1','81.00','-'),
('14:00:00 15/01/2022','19:00:00 15/01/2022','3','1','45.00','-'),
('14:00:00 15/01/2022','17:00:00 15/01/2022','4','1','27.00','-'),
('14:00:00 10/01/2022','19:00:00 10/01/2022','4','2','45.00','-'),
('17:00:00 15/12/2021','19:00:00 15/12/2021','5','2','18.00','-'),
('17:00:00 15/12/2021','19:00:00 15/12/2021','5','2','18.00','-'),
('10:00:00 12/12/2021','19:00:00 12/12/2021','4','1','81.00','-'),
('10:00:00 12/12/2021','12:00:00 12/12/2021','3','1','18.00','-'),
('12:00:00 20/11/2021','19:00:00 20/11/2021','5','2','63.00','-'),
('12:00:00 20/11/2021','19:00:00 20/11/2021','2','2','63.00','-'),
('14:00:00 15/11/2021','19:00:00 15/11/2021','3','2','45.00','-')
insert into Pagamento (Preco,CodigoFormaPagamento,codigoEstacionar) values
('18.00','1','1'),
('09.00','1','2'),
('09.00','1','3'),
('22.50','1','4'),
('18.00','1','5'),
('81.00','1','6'),
('72.00','1','7'),
('54.00','1','8'),
('81.00','1','9'),
('45.00','1','10'),
('27.00','1','11'),
('45.00','1','12'),
('18.00','1','13'),
('18.00','1','14'),
('81.00','1','15'),
('18.00','1','16'),
('63.00','1','17'),
('63.00','1','18'),
('45.00','1','19')

go

/*Tabelas/
drop table Pagamento
drop table formaPagamento
drop table Estacionar
drop table clienteVeiculo
drop table Cliente
drop table Veiculo
drop table Patio
drop table Usuario
drop table Funcionarios
drop table nivelAcesso

--Selects gerais
select *from clienteVeiculo
select *from Cliente
select *from Veiculo 
select *from Funcionarios
select *from Patio
select *from Estacionar 
select *from Pagamento
select *from formaPagamento 
select *from Usuario
select *from nivelAcesso
*/

             

