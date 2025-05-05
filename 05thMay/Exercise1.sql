create Procedure getProductRevenue @ProductID Int as begin 
select p.ProductID,p.ProductName , sum(o.Quantity * p.price) as TotalRevenue from orders o inner join
products p ON o.ProductID=p.ProductID where o.ProductID=@ProductID group by p.ProductID,p.ProductName END;  

exec getProductRevenue @productID=1;






