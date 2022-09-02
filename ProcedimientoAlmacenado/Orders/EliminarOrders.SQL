use northwind;

DELIMITER $$
CREATE PROCEDURE EliminarOrders (IN OrdenID int)
BEGIN	
delete FROM orders
Where OrderID = OrdenID;
END
$$