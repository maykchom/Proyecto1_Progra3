DELIMITER $$
CREATE PROCEDURE ActualizarCustomer (in IdCustumer  varchar(5), CompanyName varchar(40), IN ContactName varchar(30), IN ContactTitle varchar(30), IN Address varchar(60), IN City varchar(15), IN Region varchar(15), IN PostalCode varchar(10), IN Country varchar(15), IN Phone varchar(24), IN Fax varchar(24))
BEGIN
	Update customers
	set CompanyName= CompanyName, ContactName = ContactName,ContactTitle = ContactTitle, Address = Address,City = City,Region = Region, PostalCode = PostalCode,Country = Country,Phone = Phone,Fax = Fax
 	Where CustomerID = IdCustumer;
END 
$$