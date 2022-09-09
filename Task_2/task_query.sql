------------- Подготовительные шаги (создание бд и таблиц)  -------------
create database TestBase;
go;

use TestBase;

create table Products
(
	ID int identity not null,
	name nvarchar(20) not null,
	primary key(ID)
)
go

insert Products values('bread')
insert Products values('milk')
insert Products values('something')

create table Categories
(
	ID int identity not null,
	name nvarchar(20) not null
	primary key(ID)
)
go

insert Categories values('food')
insert Categories values('liquid')
insert Categories values('best_choiсe')

create table Products_Categories
(
	ProductID int foreign key references dbo.Products(ID),
	CategoryID int foreign key references dbo.Categories(ID),
	primary key(ProductID, CategoryID)
)
go

insert Products_Categories values(1,1)
insert Products_Categories values(2,1)
insert Products_Categories values(2,2)
insert Products_Categories values(2,3)

-------------------- Выполнение задания (сам запрос) --------------------
select dbo.Products.ID, dbo.Products.name as ProductName, dbo.Categories.name as CategoryName
  from dbo.Products
left outer join dbo.Products_Categories
  on dbo.Products.ID = dbo.Products_Categories.ProductID
left outer join dbo.Categories
  on dbo.Products_Categories.CategoryID = dbo.Categories.ID