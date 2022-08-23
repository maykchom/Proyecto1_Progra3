use northwind;

DELIMITER $$
CREATE PROCEDURE InsertaProveedores (IN CompanyName varchar(40), IN ContactName varchar(30), IN ContactTitle varchar(30), IN Address varchar(60),
IN City varchar(15), IN Region varchar(15), IN PostalCode varchar(10), IN Country varchar(15), IN Phone varchar(24), IN Fax varchar(24), IN HomePage Text)

BEGIN
Select @Supp := max(SupplierID)+1 from suppliers;
 INSERT INTO suppliers (SupplierID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage)
 values(@Supp,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage);

END 
$$