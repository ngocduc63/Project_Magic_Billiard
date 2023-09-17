create database MagicBilliard
go
use MagicBilliard
go

create table position
(
	id nvarchar(50) primary key,
	name nvarchar(50)
)
go
create table staff
(
	id nvarchar(50) primary key,
	name nvarchar(50),
	address nvarchar(50),
	phoneNumber nvarchar(50),
	idPosition nvarchar(50),
	foreign key (idPosition) references position (id)
)
go
create table account
(
	username nvarchar(50) primary key,
	passWord nvarchar(50),
	displayName nvarchar(50),
	idStaff nvarchar(50),
	foreign key (idStaff) references staff (id)
)
go
create table tableCategory 
(
	id nvarchar(50) primary key,
	name nvarchar(50),
	price float not null
)
go
create table tablePLay
(
	id nvarchar(50) primary key,
	status int default 0,
	idCategory nvarchar(50)
	foreign key (idCategory) references tableCategory (id)
)
go
create table foodCategory 
(
	id nvarchar(50) primary key,
	name nvarchar(50)
)
go
create table food 
(
	id nvarchar(50) primary key,
	name nvarchar(50),
	price float not null,
	idCategory nvarchar(50),
	foreign key (idCategory) references foodCategory (id)
)
go
create table guest 
(
	id nvarchar(50) primary key,
	name nvarchar(50),
	address nvarchar(50),
	phoneNumber nvarchar(50),
	totalPoint float,
)
go 
create table bill 
(
	id nvarchar(50) primary key,
	dateCheckIn date,
	dateCheckOut date,
	idTable nvarchar(50),
	idGuest nvarchar(50),
	idStaff nvarchar(50),
	status int default 0,
	totalPrice float,
	foreign key (idTable) references tablePlay (id),
	foreign key (idGuest) references guest (id),
	foreign key (idStaff) references staff (id)
)
go
create table billInfo 
(
	id nvarchar(50) primary key,
	idFood nvarchar(50),
	quantityFood int default 1,
	idBill nvarchar(50),
	foreign key (idFood) references food (id),
	foreign key (idBill) references bill (id)
)
go
CREATE TRIGGER InsertBill
ON bill FOR Insert
AS
BEGIN
	DECLARE @idBill nvarchar(50)
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable nvarchar(50)
	
	SELECT @idTable = idTable FROM bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM bill WHERE idTable = @idTable AND status = 0
	
	IF (@count > 0)
		UPDATE tablePlay SET status = 1 WHERE id = @idTable
END
go
CREATE TRIGGER UpdateBill
ON bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill nvarchar(50)
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable nvarchar(50)
	
	SELECT @idTable = idTable FROM bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE tablePlay SET status = 0 WHERE id = @idTable
END
GO
--DROP TRIGGER UpdateBill 
--DROP TRIGGER InsertBill