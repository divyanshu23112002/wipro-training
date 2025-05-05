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

Insert into Products(ProductID,ProductName,Price) values (1,'Laptop',70000.00),(2,'Smartphone',30000.00),
(3,'Tablet',20000.00),(4,'Monitor',15000.00);

Insert into Orders(OrderID,ProductID,Quantity,OrderDate) values(101,1,2,'2024-12-01'),
(102,2,1,'2024-12-05'),(103,3,3,'2024-12-10'),(104,1,1,'2024-12-15'),(105,4,2,'2024-12-15');

select * from orders;
select * from products;

select Orders.OrderID,Products.ProductName,Orders.Quantity,Products.Price,
(Orders.Quantity * Products.Price)As TotalAmount,Orders.OrderDate
from Orders inner join Products On Orders.OrderID=Products.ProductID;

select products.ProductID,products.ProductName,Orders.OrderID,Orders.Quantity,
Orders.OrderDate from products left join orders ON Orders.OrderID=Products.ProductID;

select products.ProductID,products.ProductName,Orders.OrderID,Orders.Quantity,
Orders.OrderDate from products right join  orders ON Orders.OrderID=Products.ProductID;

select products.ProductName,sum(Orders.Quantity) as TotalUnitSold from order 
inner join products  ON Orders.OrderID=Products.ProductID group by Products.ProductName;


Create Procedure getallproducts as begin select * from products end;  

exec getallproducts;

select p.ProductID,p.ProductName,p.Price ,'HigherEnd Product' as
Product_category from products p join Orders o ON p.ProductID=o.OrderID where
p.price > 60000;

create Procedure getOrdersByProduct @ProductID Int as begin
select o.OrderID,o.Quantity,o.OrderDate,p.ProductName,p.price from Orders o inner join
products p On o.ProductID=p.ProductID where o.ProductID=@ProductID
END;

EXEC getOrdersByProduct @ProductID=1;

