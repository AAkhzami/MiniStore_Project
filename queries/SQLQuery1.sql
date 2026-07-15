------ Triggers

create trigger trg_DeleteProduct on Products
instead of Delete
as
begin
	update p
	set p.IsActive = 0
	from Products p inner join deleted d on
	p.ProductID = d.ProductID
end;


create trigger trg_InsertOnCustomerOrdersView on v_CustomerOrders
instead of insert
as
begin
	declare @NewCustomer table
	(
		ID int,
		Name varchar(250)
	);
	
	insert into Customers
	(CustomerName,PhoneNumber,CreatedByUserID)
	Output inserted.CustomerID,inserted.CustomerName into @NewCustomer(ID,Name)
	select CustomerName,PhoneNumber,CreatedByUserID
	from inserted;

	insert into Orders
	(CustomerID,OrderDate,TotalAmount,CreatedByUserID)
	select n.ID, d.OrderDate,d.TotalAmount,d.CreatedByUserID
	from inserted d inner join @NewCustomer n on
	n.Name = d.CustomerName
end;

create trigger trg_AfterInsertOrderDetails on OrderDetails
after insert
as 
begin
		update p
		set p.StockQuantity = p.StockQuantity - i.Quantity
		from Products p
		inner join inserted i on
		p.ProductID = i.ProductID
		where (p.StockQuantity - i.Quantity) >= 0;
end;

create trigger trg_AfterUpdateProductQuantity on Products
after update
as
begin
	insert into InventoryLogs
	(ProductID,OldStock,NewStock)
	select 
	i.ProductID,
	d.StockQuantity,
	i.StockQuantity
	from inserted i inner join deleted d on
	i.ProductID = d.ProductID;
end;

------ Scalar Functions
create Function dbo.FinalPrice(@Price decimal(10,3))
Returns decimal(10,3)
as
begin
	declare @FinalPrice decimal(10,3);

	set @FinalPrice = @Price * 1.05;
	RETURN @FinalPrice;
end;

create Function dbo.GetReportOfOrder
(@OrderID int)
Returns Table
as
return
(
select
	p.Name,
	od.Quantity,
	od.PricePerUnit AS BasePrice,
	dbo.FinalPrice(od.PricePerUnit) AS PriceAfterTax
	from OrderDetails od
	inner join Products p on
	p.ProductID = od.ProductID
	where od.OrderID = @OrderID
);

create Function dbo.GetReportOfProducts()
Returns Table
as
return
(
	select
	p.ProductID,
	p.Name as ProductName,
	p.Price ,
	p.StockQuantity,
	c.Name as CategoryName,
	DENSE_RANK() over (PARTITION by c.Name Order by ISNULL(SUM(od.Quantity),0) DESC) as CategoryRank
	from  Products p
	inner join Categories c on
	p.CategoryID = c.CategoryID
	LEFT join OrderDetails od on
	p.ProductID = od.ProductID
	Group by p.ProductID, p.Name,p.Price,p.StockQuantity,c.Name
);

create Function dbo.ProductsPagination
(@pageNumber int, @RowPerPage int)
Returns Table
as
return
(
	select 
	p.ProductID,
	p.Name,
	c.Name as CategoryName,
	p.Price,
	p.StockQuantity,
	p.IsActive
	from Products p
	inner join Categories c on
	c.CategoryID = p.CategoryID 
	Order by ProductID
	offset (@pageNumber - 1) * @RowPerPage ROWS
	Fetch next @RowPerPage ROWS Only
);


create Function dbo.GetLowStockProducts ()
returns int
as
begin
	declare @CountStock int

	select @CountStock =  Count(*) from Products
	where StockQuantity <= (
		select	CAST(SettingValue as int)  
		from Settings
		where SettingKey = 'LowStockAlertLimit'
	)
	return @CountStock;
end;


------ Store Procedures

create procedure SP_AddNewUser
@UserName varchar(250),
@Password varchar(300),
@IsActive bit,
@NewUserID int OUTPUT
as
begin
	insert into Users
	(UserName, Password, IsActive)
	values
	(@UserName, @Password, @IsActive)

	set @NewUserID = SCOPE_IDENTITY();
end


create procedure SP_UpdateUser
@UserID int,
@UserName varchar(250),
@Password varchar(300),
@IsActive bit
as
begin
	update Users
	set 
	UserName = @UserName,
	Password = @Password,
	IsActive = @IsActive
	where UserID = @UserID;
end

--create procedure SP_GETOrderInformationAtDate
--@Date date,
--@TodaySales decimal(10,3) OUTPUT,
--@TodayOrder int OUTPUT
--as
--begin
--	select
--		@TodaySales = SUM(TotalAmount),
--		@TodayOrder = COUNT(*)
--	from 
--	Orders
--	where OrderDate >= CAST(@Date as DATE)
--	and OrderDate < CAST(DATEADD(DAY,1,@Date) as DATE);
--end


create procedure dbo.SP_GetTotalOrdersAtDate
@Date date,
@TodayOrders int OutPut
as
begin
	select
		@TodayOrders = COUNT(*)
	from 
	Orders
	where OrderDate >= CAST(@Date as DATE)
	and OrderDate < CAST(DATEADD(DAY,1,@Date) as DATE);
end

create procedure dbo.SP_GetTotalSalesAtDate
@Date date,
@TodaySales decimal(10,3) OutPut
as
begin
	select
		@TodaySales = SUM(TotalAmount)
	from 
	Orders
	where OrderDate >= CAST(@Date as DATE)
	and OrderDate < CAST(DATEADD(DAY,1,@Date) as DATE);
end