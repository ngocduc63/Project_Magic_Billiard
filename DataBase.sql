create database MagicBilliard
go
use MagicBilliard
go
create table position
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50)
)
go
create table staff
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	address nvarchar(50),
	phoneNumber nvarchar(50),
	idPosition int,
	foreign key (idPosition) references position (id)
)
go
create table account
(
	username nvarchar(50) primary key,
	passWord nvarchar(50),
	displayName nvarchar(50),
	idStaff int,
	foreign key (idStaff) references staff (id)
)
go
create table tableCategory 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	price float not null
)
go
create table tablePLay
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	status int default 0,
	idCategory int,
	foreign key (idCategory) references tableCategory (id)
)
go
create table foodCategory 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50)
)
go
create table food 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	price float not null,
	idCategory int,
	foreign key (idCategory) references foodCategory (id)
)
go
create table guest 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	address nvarchar(50),
	phoneNumber nvarchar(50),
	totalPoint float default 0,
)
go 
create table bill 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	dateCheckIn datetime,
	dateCheckOut datetime,
	idTable int,
	idGuest int,
	idStaff int,
	status int default 0,
	totalPrice float,
	foreign key (idTable) references tablePlay (id),
	foreign key (idGuest) references guest (id),
	foreign key (idStaff) references staff (id)
)
go
create table billInfo 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	idFood int,
	quantityFood int default 1,
	idBill int,
	foreign key (idFood) references food (id),
	foreign key (idBill) references bill (id)
)
go
CREATE TRIGGER InsertBill
ON bill FOR Insert
AS
BEGIN
	DECLARE @idBill int
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable int
	
	SELECT @idTable = idTable FROM bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM bill WHERE idTable = @idTable AND status = 0
	
	IF (@count > 0)
		UPDATE tablePlay SET status = 1 WHERE id = @idTable
END
go
CREATE TRIGGER InsertBillInfo
ON billInfo for Insert
AS
BEGIN
	DECLARE @idBillInfoLast int
	DECLARE @idBillInfo int
	DECLARE @idFood int
	DECLARE @quantity int
	DECLARE @idBill int

	SELECT @idBillInfoLast = id, @idFood = idFood,  @quantity = quantityFood, @idBill = idBill
	FROM Inserted	
	
	SELECT top 1  @idBillInfo = billInfo.id FROM bill join billInfo on bill.id = billInfo.idBill
	where idFood = @idFood and status = 0 and @idBill = bill.id

	DECLARE @count int
	select @count = count(*) FROM bill join billInfo on bill.id = billInfo.idBill
	where idFood = @idFood and status = 0 and @idBill = bill.id

	IF (@idBillInfo is not null and @count > 1)
		begin
			update billInfo set quantityFood = quantityFood + @quantity
			where id = @idBillInfo
			
			Delete from billInfo where id = @idBillInfoLast
		end
END
go
CREATE TRIGGER UpdateBill
ON bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill int
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable int
	
	SELECT @idTable = idTable FROM bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE tablePlay SET status = 0 WHERE id = @idTable
	else
		Update tablePLay set status = 2 where id = @idTable

END
GO
CREATE TRIGGER UpdatePointGuest
ON bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill int
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idGuest int

	DECLARE @totalPrice float
	
	SELECT @idGuest = idGuest, @totalPrice = totalPrice FROM bill WHERE id = @idBill
	
	IF (@totalPrice is not null)
		UPDATE guest set totalPoint += @totalPrice / 1000 where @idGuest = id
END
GO
--DROP TRIGGER UpdateBill 
--DROP TRIGGER InsertBill
--DROP TRIGGER InsertBillInfo
--DROP TRIGGER UpdatePointGuest

insert into position values('giam doc'), ('nhan vien')
go
insert into staff (name, idPosition) values ('admin', 1)
go
insert into staff (name, idPosition) values ('staff', 2)
go
insert into guest (name) values ('admin')
go
insert into account values('admin', '1', 'admin', 1)
go
insert into account values('staff', '1', 'staff', 2)
go
insert into tableCategory values('Aplus', 50000), ('MrSung', 60000), ('KKing', 40000)
go
insert into tablePLay(idCategory) values (1), (3), (1), (2), (3), (1), (1), (2)
go
insert into foodCategory values ('do uong'), ('thuc an')
go
insert into food values ('coca', 10000, 1), ('pepsi', 10000, 1), ('Mi tom trung', 15000, 2)
go
