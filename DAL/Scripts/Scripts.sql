Create Database PersonasDb
Go
Use PersonasDb
Go

Create Table Personas
(
   Id int primary key identity,
   Nombre varchar (30),
   Apellidos varchar(35),
   Telefono varchar(13),
   Cedula varchar (13),
   Direccion varchar (max),
   FechaNacimiento date,

);




