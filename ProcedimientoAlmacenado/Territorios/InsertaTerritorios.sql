use northwind;

DELIMITER $$
CREATE PROCEDURE InsertaTerritorios (IN DescriTerritorio varchar(50), IN RegionID, longblob)
BEGIN
Select @territorioID := max(TerritoryID)+1 from Territories;
 INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID)
 value

END 
$$