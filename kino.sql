
--1
create table Aktor
(
aktorId int identity primary key,
imie nvarchar(50) not null,
nazwisko nvarchar(50) not null,
)
go
--2
create table Rezyser
(
rezyserId int identity primary key,
imie nvarchar(255) not null,
nazwisko nvarchar(255) not null
)
go
--3
create table Film
(
filmId int identity primary key,
tytul nvarchar(255) not null,
rokProdukcji date not null,
czasTrwania int not null,
dataPremierySwiat date not null,
dataPremieryPolska date not null
)
go
--4
create table FilmAktor
(
FilmId int foreign key references Film(filmId),
AktorId int foreign key references Aktor(aktorId),
primary key(FilmId, AktorId)
)
go

--5
create table FilmRezyser
(
FilmId int foreign key references Film(filmId),
RezyserId int foreign key references Rezyser(rezyserId),
primary key(FilmId, RezyserId)
)
go

--5.1
create table Kino
(
kinoId int  identity primary key,
nazwa nvarchar(255) not null,
adres text not null
)
go
--5.5
create table SalaKinowa
(
salaKinowaId int identity primary key,
kinoId int foreign key references Kino(kinoId) not null,
nrSali int not null
)
go

--6
create table Miejsce
(
MiejsceId int identity primary key,
SalaId int foreign key references SalaKinowa(salaKinowaId) not null,
rzad int not null, 
kolumna int not null
)
go

--7
create table Seans
(
seansId int identity primary key,
salaKinowaId int foreign key references SalaKinowa(salaKinowaId) not null,
filmId int foreign key references Film(filmId) not null,
dataStart datetime not null,
dataStop datetime not null
)
go
--8
create table TypPracownika
(
typPracownikaId int identity primary key,
nazwa nvarchar(255) not null
)
go

--9
create table Pracownik
(
pracownikId int identity primary key,
typPracownikaId int foreign key references TypPracownika(typPracownikaId) not null,
imie nvarchar(50) not null,
nazwisko nvarchar(50) not null,
pesel nvarchar(11) check ( pesel like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
adres text not null,
email nvarchar(255),
)
go

--10
create table Klient
(
klientId int identity primary key,
imie nvarchar(50) not null,
nazwisko nvarchar(50) not null,
adres text,
login_ nvarchar(16) unique not null,
email nvarchar(255) unique not null,
)
go

--11
create table Rezerwacja
(
rezerwacjaId int identity primary key,
klientId int foreign key references Klient(klientId) ,
pracownikId int foreign key references Pracownik(pracownikId),
seansId int foreign key references Seans(seansId)  not null,
check(klientId is not null or pracownikId is not null)
)
go

--12
create Table TypPlatnosci
(
typPlatnosciId int identity primary key,
nazwa nvarchar(255) unique not null, 
)
go

create table Platnosc
(
platnoscId int identity primary key, 
rezerwacjaId int foreign key references Rezerwacja(rezerwacjaId)  not null,
typPlatnosciId int foreign key references TypPlatnosci(typPlatnosciId) not null,
kwota decimal not null,
)
go