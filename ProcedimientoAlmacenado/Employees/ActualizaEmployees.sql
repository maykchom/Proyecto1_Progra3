use northwind;

DELIMITER $$
CREATE PROCEDURE ActualizaEmployees (IN IDEmployee int, IN LastName varchar(20), IN FirstName varchar(10), IN Title varchar(30), IN TitleOfC varchar(25), IN BirthD datetime,
IN HireDate datetime, IN Address varchar(60), IN City varchar(15), IN Region varchar(15), IN PostalCod varchar(10), IN Country varchar(15), IN HPhone varchar(24),
IN Extens varchar(4), IN Photo longblob, IN Notes text, IN Reports int, IN PhotoP varchar(255), IN Salary float)

BEGIN
 Update Employees
 Set LastName = LastName, FirstName = FirstName, Title = Title, TitleOfCourtesy = TitleOfC, BirthDate = BirthD, HireDate = HireDate,
 Address = Address, City = City, Region = Region, PostalCode = PostalCod, Country = Country, HomePhone = HPhone, Extension = Extens, Photo = Photo,
 Notes = Notes, ReportsTo = Reports, PhotoPath = PhotoP, Salary = Salary
 Where EmployeeID = IDEmployee;
 END 
$$