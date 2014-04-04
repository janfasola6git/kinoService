

IF OBJECT_ID ( 'SP_Aktor_add', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_Aktor_add;
GO
create procedure SP_Aktor_add
(
@aktorid int output,
@imie nvarchar(255),
@nazwisko nvarchar(255)
)
as
begin
	
	insert into Aktor values (@imie,@nazwisko);
	set @aktorId = scope_identity();

end

IF OBJECT_ID ( 'SP_Rezyser_add', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_Rezyser_add;
GO
create procedure SP_Rezyser_add
(
@Rezyserid int output,
@imie nvarchar(255),
@nazwisko nvarchar(255)
)
as
begin
	
	insert into Rezyser values (@imie,@nazwisko);
	set @RezyserId = scope_identity();

end

IF OBJECT_ID ( 'SP_Film_add', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_Film_add;
GO
create procedure SP_Film_add
(
@Filmid int output,
@tytul nvarchar(255) ,
@rokProdukcji date ,
@czasTrwania int ,
@dataPremierySwiat date ,
@dataPremieryPolska date 
)
as
begin
	
	insert into Film values (@tytul,@rokProdukcji,@czasTrwania,@dataPremierySwiat,@dataPremieryPolska);
	set @FilmId = scope_identity();

end

IF OBJECT_ID ( 'SP_SalaKinowa_add', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_SalaKinowa_add;
GO
create procedure SP_SalaKinowa_add
(
@SalaKinowaid int output,
@kinoId int ,
@nrSali int
)
as
begin
	
	insert into SalaKinowa values (@kinoId,@nrSali);
	set @SalaKinowaId = scope_identity();

end

IF OBJECT_ID ( 'SP_SalaKinowa_add', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_SalaKinowa_add;
GO
create procedure SP_SalaKinowa_add
(
@SalaKinowaid int output,
@kinoId int ,
@nrSali int
)
as
begin
	
	insert into SalaKinowa values (@kinoId,@nrSali);
	set @SalaKinowaId = scope_identity();

end