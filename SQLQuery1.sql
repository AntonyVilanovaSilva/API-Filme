use master
go
Create database DBFilme
go
use DBFilme
go

Create table Filme(
 FilId int identity(1,1) primary key,
 Titulo varchar(100) not null,
 Diretor varchar(100) not null,
 DataLancamento datetime,
 Genero varchar(100) not null
 )

 Insert Filme (Titulo,Diretor,DataLancamento,Genero) values ('Lanterna Verde','Martin Campbell','2011','Fantasia-A��o')
 Insert Filme (Titulo,Diretor,DataLancamento,Genero) values ('Chapolin Colorado','Roberto Gomez Bolan�s','1972','A��o')
 Insert Filme (Titulo,Diretor,DataLancamento,Genero) values ('Scooby-Doo','Joe Ruby','2002','Fantasia-A��o')

 Select * From Filme
