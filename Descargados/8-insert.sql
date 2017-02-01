/*Instruccion para el ingreso de un nuevo registro*/
INSERT INTO dbo.Categories(CategoryName,Description, Picture)
VALUES ('Pastry shop','cake,cookie','<Binary data>')

/*Instruccion para consulta*/
SELECT CategoryID
      ,CategoryName
      ,Description
      ,Picture
  FROM categories