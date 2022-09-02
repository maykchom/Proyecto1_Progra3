use northwind;
DELIMITER $$
CREATE PROCEDURE ActualizarOrders (IN OrdenID int, IN ClienteID varchar(50), IN EmployID Int, IN FechaOrden datetime, IN FechaRequerida datetime, IN FechaEnvio datetime, IN  Via INT, IN Transporte decimal, IN NombreBarco varchar (40), IN DireccionEnvio varchar(60), IN CiudadBarco varchar (15), IN RegionEnvio varchar (15), IN CodigoPostal varchar (10), PaisEnvio varchar (15))
BEGIN	
Update orders 
Set   CustomerID = ClienteID, EmployeeID = EmployID, OrderDate = FechaOrden, RequiredDate = FechaRequerida, ShippedDate = FechaEnvio, ShipVia = Via, Freight = Transporte, ShipName = NombreBarco, ShipAddress = DireccionEnvio, ShipCity = CiudadBarco, ShipRegion = RegionEnvio, ShipPostalCode = CodigoPostal, ShipCountry = PaisEnvio
Where OrderID = OrdenID;
END
$$