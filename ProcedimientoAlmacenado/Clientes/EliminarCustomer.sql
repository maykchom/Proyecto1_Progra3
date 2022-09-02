DELIMITER $$
CREATE PROCEDURE EliminarCustomer (in IdCliente varchar(5))
BEGIN
	DELETE FROM customers 
    WHERE CustomerID  = IdCliente;
end
$$