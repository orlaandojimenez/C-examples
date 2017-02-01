--USE [NombreBD]
--GO

/*=======================================================================================
Instruccion para modificar 1 o mas campos de una tabla Sintaxis de la Instruccion UPDATE
UPDATE [Nombre de la tabla]
   SET [Campo1] = <Valor1>
      ,[Campo2] = <Valor1>
      ,[Campo3] = <Valor1>
 WHERE <Condiciones>
========================================================================================*/
--======== CONSULTAREMOS LOS DATOS ========
 SELECT * FROM Categories

 --======== APLICAR EL UPDATE ============
 UPDATE Categories 
	SET Description = 'Cake, Cookies, Bread, Panque'
WHERE CategoryID = 9

--========== CONSULTAR LOS DATOS PARA VER EL CAMBIO REFLEJADO ===========
 SELECT * FROM Categories WHERE CategoryID = 9


--GO


