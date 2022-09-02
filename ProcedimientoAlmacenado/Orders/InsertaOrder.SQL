use northwind;
DELIMITER $$
CREATE PROCEDURE InsertaOrder (IN ClienteID varchar(50), IN EmployID Int, IN OrderDate datetime, IN RequiredDate datetime, IN ShippedDate datetime, IN ShipVia INT, IN Freight decimal, IN ShipName varchar (40), IN ShipAddress varchar(60), IN ShipCity varchar (15), IN ShipRegion varchar (15), IN ShipPostalCode varchar (10), ShipCountry varchar (15))
BEGIN
Select @OrderID := max(OrderID)+1 from orders;
 INSERT INTO orders (OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry)
 value (@OrderID, ClienteID, EmployID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry);
END 
$$