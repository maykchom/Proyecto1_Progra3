use northwind;

DELIMITER $$
CREATE PROCEDURE InsertaCategorias (IN nombreCategoria varchar(15), IN Descri text, IN Pic 	longblob)
BEGIN
Select @categoriaID := max(CategoryID)+1 from categories;
 INSERT INTO categories (CategoryID, CategoryName, Description, Picture)
 values(@categoriaID,nombreCategoria,Descri,Pic);

END 
$$