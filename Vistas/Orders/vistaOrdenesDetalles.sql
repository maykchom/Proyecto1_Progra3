create view v_od
as
select `order details`.OrderID ,`order details`.ProductID ,products.ProductName, `order details`.UnitPrice, `order details`.Quantity,  (`order details`.UnitPrice * `order details`.Quantity)
from `order details`
inner join products ON products.ProductID = `order details`.ProductID 