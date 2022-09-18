use northwind;
DELIMITER $$
CREATE PROCEDURE ActualizarTerritories (IN IDTerritory varchar(20), IN TerritoryDes varchar(50), IN IDRegion INT)
BEGIN
Update Territories 
Set TerritoryDescription = TerritoryDes, RegionID = IDRegion
Where TerritoryID = IDTerritory;
END
$$