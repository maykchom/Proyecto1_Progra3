create view vistaTerritorios
as
select t.TerritoryID  , t.TerritoryDescription, r.RegionDescription 
from territories t 
inner join region r on r.RegionID = t.RegionID 