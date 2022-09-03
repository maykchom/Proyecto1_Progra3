use northwind;

DELIMITER $$
CREATE PROCEDURE EliminarTerritorios (IN territoriesID int)
BEGIN	
delete FROM territories
Where TerritoryID = territoriesID;
END
$$