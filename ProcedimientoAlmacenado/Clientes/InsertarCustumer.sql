DELIMITER $$
CREATE PROCEDURE InsertarCustomer (in IdCustomer varchar(5), CompanyName varchar(40), IN ContactName varchar(30), IN ContactTitle varchar(30), IN Address varchar(60),
IN City varchar(15), IN Region varchar(15), IN PostalCode varchar(10), IN Country varchar(15), IN Phone varchar(24), IN Fax varchar(24))
BEGIN
 INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)
 values(IdCustomer,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax);
END 
$$