--Tạo Database quản lí bán thuốc
create database DrugSalesManager
go
use DrugSalesManager
go


--Tạo table đơn vị
create table Unit
(
	id_Unit int identity(1,1) primary key,
	Code_Unit varchar(10) not null,
	Name_Unit nvarchar(100)
)
go

-- tạo table Nhà Cung Cấp
create table Supplier
(
	ID_Supplier int identity(1, 1) primary key,
	Name_Supplier nvarchar(200) not null,
	Code_Supplier varchar(10),
	PhoneNumber nvarchar(200),
	Address_Supplier nvarchar(200)

)
go

--tạo table thuốc
create table Medicine 
(
	ID_Medicine int identity(1, 1) primary key,
	Name_Medicine nvarchar(200) not null,
	Code_MEdicine varchar(10) not null,
	Exprired_Day datetime not null,
	Amount int default 0 not null,
	ID_Unit int,
	ID_Supplier int,
	Import_Price float default 0 not null,
	Sale_Price float default 0 not null,
	Note nvarchar(300),
	foreign key (ID_Unit) references Unit(Id_Unit),
	foreign key (ID_Supplier) references Supplier(ID_Supplier)


)

go

--tạo table tài khoản -- Nhân viên
create table Account
(
	ID_Account int identity(1, 1) primary key,
	Code_Account varchar(10) not null,
	DisplayName_Account nvarchar(200) ,
	DateOfBirth datetime not null,
	PhoneNumber nvarchar(200),
	PassWord_Account nvarchar(max) not null

)
go

-- tạo table Khách Hàng
create table Customer
(
	ID_Customer int identity(1, 1) primary key,
	Code_Customer varchar(10) not null,
	Name_Customer nvarchar(200) not null,
	PhoneNumber nvarchar(200),
	Address_Customer nvarchar(200)


)
go



-- Tạo table phiếu nhập kho
create table Receipt
(
	ID_Receipt int identity(1,1) primary key,
	Code_Reciept varchar(10) not null,
	CreateDay datetime not null,
	ID_Account int,
	ID_Supplier int,
	foreign key (ID_Account) references Account(ID_Account),
	foreign key (ID_Supplier) references Supplier(ID_Supplier)

)

go
--tạo table chi tiết nhập kho
create table ReceiptDetails
(
	ID_ReceiptDetails int ,
	Code_ReceiptDetails varchar(10) not null,
	ID_Medicine int,
	Amount int default 0 not null,
	Import_Pirce  float default 0 not null,
	Bill_Status bit default 0,
	foreign key (ID_ReceiptDetails) references Receipt(ID_Receipt),
	foreign key (ID_Medicine) references Medicine(ID_Medicine),
	primary key (ID_ReceiptDetails, ID_Medicine)


)
go

-- Tạo table Hóa Đơn Bán
create table Invoice
(
	ID_Invoice int identity(1,1) primary key,
	Code_Invoice varchar(10) not null,
	CreateDay datetime not null,
	ID_Account int,
	ID_Customer int,
	foreign key (ID_Account) references Account(ID_Account),
	foreign key (ID_Customer) references Customer(ID_Customer)

)

go
--tạo table chi tiết Hóa Đơn Bán
create table InvoiceDetails
(
	ID_InvoiceDetails int ,
	Code_InvoiceDetails varchar(10) not null,
	ID_Medicine int,
	Amount int default 0 not null,
	Sale_Pirce  float default 0 not null,
	Bill_Status bit not null,
	foreign key (ID_InvoiceDetails) references Invoice(ID_Invoice),
	foreign key (ID_Medicine) references Medicine(ID_Medicine),
	primary key (ID_InvoiceDetails, ID_Medicine)


)

go




