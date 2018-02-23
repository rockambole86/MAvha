if not exists (select * from sys.objects where object_id = object_id(N'[dbo].[Person]') and type='U')
    create table Person (
         PersonId int not null identity(1, 1) primary key
        ,Fullname varchar(100) not null
        ,DOB datetime not null
        ,Age int not null
        ,Gender int not null
        ,IsActive bit not null default(1)
    )
go


if not exists (select * from sys.objects where object_id = object_id(N'[dbo].[PersonList]') and type in (N'P', N'PC'))
begin
exec dbo.sp_executesql
    @statement = N'CREATE PROCEDURE [dbo].[PersonList] AS'
end
go

alter procedure [dbo].[PersonList]

as

select
    *
from
    Person
where
    IsActive = 1
go


if not exists (select * from sys.objects where object_id = object_id(N'[dbo].[PersonSave]') and type in (N'P', N'PC'))
begin
exec dbo.sp_executesql
    @statement = N'CREATE PROCEDURE [dbo].[PersonSave] AS'
end
go

alter procedure [dbo].[PersonSave]
(
     @PersonId int
    ,@Fullname varchar(100)
    ,@DOB datetime
    ,@Age int
    ,@Gender int
)

as

if (@PersonId = 0)
begin
    insert into Person (Fullname, DOB, Age, Gender, IsActive)
    values (@Fullname, @DOB, @Age, @Gender, 1)
end
else
begin
    update Person
    set
         Fullname = @Fullname
        ,DOB = @DOB
        ,Age = @Age
        ,Gender = @Gender
    where
        PersonId = @PersonId
end
go

if not exists (select * from sys.objects where object_id = object_id(N'[dbo].[PersonDelete]') and type in (N'P', N'PC'))
begin
exec dbo.sp_executesql
    @statement = N'CREATE PROCEDURE [dbo].[PersonDelete] AS'
end
go

alter procedure [dbo].[PersonDelete]
(
     @PersonId int
)

as

update Person
set
    IsActive = 0
where
    PersonId = @PersonId
go