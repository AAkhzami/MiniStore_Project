create Database MiniStoreDB;

create table Users
(
	UserID int Primary key identity(1,1),
	UserName varchar(250) not null,
	FullName varchar(250) not null,
	Password varchar(300) not null,
	CreatedAt datetime default GETDATE() not null,
	IsActive bit not null
);

create table Categories
(
	CategoryID int primary key identity(1,1),
	Name varchar(150) not null
);
create table Products
(
	ProductID int Primary Key identity(1,1),
	Name varchar(250) null,
	CategoryID int not null,
	Price decimal(10,3) not null,
	StockQuantity int not null,
	IsActive bit not null default 1,
    CreatedByUserID int null
	
	Constraint fk_Product_Category
	foreign key (CategoryID) references Categories(CategoryID),
	constraint fk_Product_User
	foreign key(CreatedByUserID) references Users(UserID)
);
create table InventoryLogs
(
	LogID int primary key identity(1,1),
	ProductID int not null,
	OldStock int ,
	NewStock int,
	ChangeDate datetime default GETDATE()

	constraint fk_Inventory_Product
	foreign key(ProductID) references Products(ProductID)
);
create table Customers
(
	CustomerID int primary key Identity(1,1),
	CustomerName varchar(100),
	PhoneNumber varchar(50),
	CreatedByUserID int,
	IsActive bit default 1

	constraint fk_Customer_User
	foreign key (CreatedByUserID) references Users(UserID)
);
create table Orders
(
	OrderID int primary key identity(1,1),
	CustomerID int not null,
	OrderDate datetime not null default GETDATE(),
	TotalAmount decimal(10,3) not null,
	CreatedByUserID int

	constraint fk_Order_User
	foreign key(CreatedByUserID) references Users(UserID),
	Constraint fk_Order_Customer
	foreign key (CustomerID) references Customers(CustomerID)
);
create table OrderDetails
(
	DetailID int primary key identity(1,1),
	OrderID int not null,
	ProductID int not null,
	Quantity int,
	PricePerUnit decimal(10,3)

	Constraint fk_OrderDetails_Order
	foreign key (OrderID) references Orders(OrderID),
	Constraint fk_OrderDetails_Products
	foreign key (ProductID) references Products(ProductID)
);

create table Settings
(
	SettingKey varchar(100) primary key,
	SettingValue varchar(250) not null,
	Description VARCHAR(500) NULL
);
insert into Settings
(SettingKey,SettingValue,Description)
values
('LowStockAlertLimit','5','Minimum quantity of the product');

create view v_CustomerOrders as
select 
c.CustomerID,
c.CustomerName,
c.PhoneNumber,
o.OrderID,
o.OrderDate,
o.TotalAmount,
o.CreatedByUserID
from Customers c
inner join Orders o on
c.CustomerID = o.CustomerID;

create view v_ProductsInfo as
select 
p.ProductID,
p.Name as ProductName,
p.CategoryID,
c.Name as CategoryName,
p.Price,
p.StockQuantity,
p.IsActive,
p.CreatedByUserID
from Products p
inner join Categories c on
c.CategoryID = p.CategoryID;

insert into Customers
(CustomerName,PhoneNumber,CreatedByUserID)
Values
('Cash Customer (Walk-in)',null,1);