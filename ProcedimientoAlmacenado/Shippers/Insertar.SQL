use northwind;

DELIMITER $$
CREATE PROCEDURE InsertarShipper (IN CompanyName Varchar (40), IN Phone varchar (24) )
BEGIN
Select @ShipperID := max(ShipperID)+1 from shippers;
 INSERT INTO shippers (ShipperID, CompanyName, Phone)
 values(@ShipperID,CompanyName, Phone);

END 
$$