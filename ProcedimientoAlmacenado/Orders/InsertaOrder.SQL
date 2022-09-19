use northwind;

CREATE PROCEDURE InsertaOrder (IN ClienteID varchar(50), IN EmployID Int, IN OrderDatee datetime, IN RequiredDatee datetime, IN ShippedDatee datetime, IN ShipViaa INT, IN Freightt decimal, IN ShipNamee varchar(40), IN ShipAddresss varchar(60), IN ShipCityy varchar(15), IN ShipRegionn varchar(15), IN ShipPostalCodee varchar(10),IN ShipCountryy varchar(15), OUT IDOrder INT)
BEGIN

    INSERT INTO orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry)
    VALUES(ClienteID, EmployID, OrderDatee, RequiredDatee, ShippedDatee, ShipViaa, Freightt, ShipNamee, ShipAddresss, ShipCityy, ShipRegionn, ShipPostalCodee, ShipCountryy);
    SET IDOrder = (SELECT max(OrderID) from orders);
END 

--Llamar al procedimiento
CALL InsertaOrder('BONAP',7,"1996-07-04 00:00:00","1996-08-01 00:00:00","1996-07-16 00:00:00",3,32.38,"Vins et alcools Chevalier","59 rue de l-Abbaye","Reims",NULL,"51100","France", @IDOrder); 
SELECT @IDOrder;

