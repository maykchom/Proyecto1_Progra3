use northwind;

DELIMITER $$
CREATE PROCEDURE InsertaRegiones (IN nombreRegion varchar(25))
BEGIN
Select @regionID := max(RegionID)+1 from region;
 INSERT INTO region (RegionID, RegionDescription)
 values(@regionID,nombreRegion);

END 
$$