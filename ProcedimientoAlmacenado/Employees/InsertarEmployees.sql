use northwind;

DELIMITER $$
CREATE PROCEDURE InsertarEmployees (IN LastName varchar(20), IN FirstName varchar(10), IN Title varchar(30), IN TitleOfC varchar(25), IN BirthD datetime,
IN HireDate datetime, IN Address varchar(60), IN City varchar(15), IN Region varchar(15), IN PostalCod varchar(10), IN Country varchar(15), IN HPhone varchar(24),
IN Extens varchar(4), IN Photo longblob, IN Notes text, IN Reports int, IN PhotoP varchar(255), IN Salary float)

BEGIN
 Select @Emp := max(EmployeeID)+1 from employees;
 INSERT INTO employees (EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,
 Photo,Notes,ReportsTo,PhotoPath,Salary)
 values(@Emp,LastName,FirstName,Title,TitleOfC,BirthD,HireDate,Address,City,Region,PostalCod,Country,HPhone,Extens,Photo,Notes,Reports,PhotoP,Salary);
 END 
$$