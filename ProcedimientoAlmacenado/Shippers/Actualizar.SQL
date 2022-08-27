use northwind;
DELIMITER $$
CREATE PROCEDURE Actualizarshippers (IN ShipperAID INT, IN CompanyName varchar(50), IN phone INT)
BEGIN	
Update shippers 
Set CompanyName = CompanyName, phone = phone
Where ShipperID = ShipperAID;
END
$$