create table Products(
ProductID int primary key,
ProductName varchar(50),

Price decimal(10,2),

);

create table Orders(
OrderID int primary key,
ProductID Int,
Quantity int,
OrderDate date,
Foreign key(ProductID) References Products(ProductID)

);
