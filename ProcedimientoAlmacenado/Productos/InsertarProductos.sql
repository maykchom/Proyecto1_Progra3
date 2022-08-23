use northwind;

DELIMITER $$
CREATE PROCEDURE InsertaProductos (IN ProducName varchar(40), IN SupplierID INT, IN CatID INT, IN PerUnit varchar(20), 
IN UnitPrice decimal(10,4), IN UnitsStock smallint(2), IN UnitsOrder smallint(2), IN ReorderLevel smallint(2), IN Discontinued bit(1))
BEGIN
Select @Product := max(ProductID)+1 from products;
 INSERT INTO products (ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
 values(@Product,ProducName,SupplierID,CatID,PerUnit,UnitPrice,UnitsStock,UnitsOrder,ReorderLevel,Discontinued);

END 
$$