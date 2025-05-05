create Procedure CheckProductExists @ProductID INT as Begin 
if exists (select 1 from Products where ProductID=@ProductID) begin
print 'Product Exists'; end else begin print 'Product not found' ; end end;

exec CheckProductExists @ProductID=2;