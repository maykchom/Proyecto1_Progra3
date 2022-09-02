use northwind;

DELIMITER $$
CREATE PROCEDURE EliminarExpendedores (IN ShippersID int)
BEGIN	
delete FROM shippers
Where ShipperID = ShippersID;
END
$$