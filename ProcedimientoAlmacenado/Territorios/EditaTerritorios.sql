use northwind;
DELIMITER $$
CREATE PROCEDURE ActualizarTerritories (IN TerritoryID INT, IN TerritoryDescription varchar(50), IN RegionID INT)
BEGIN	
Update Territories 
Set TerritoryDescription = TerritoryDescription, RegionID = RegionID
Where TerritoryID = TerritoryID;
END
$$