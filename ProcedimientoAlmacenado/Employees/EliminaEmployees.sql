use northwind;

DELIMITER $$
CREATE PROCEDURE EliminarEmployees(IN idEmpl int)
BEGIN
	DELETE FROM employees
    WHERE EmployeeID = idEmpl;
END
$$