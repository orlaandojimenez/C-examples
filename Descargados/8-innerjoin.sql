--use NORTHWND
SELECT * FROM SYSOBJECTS WHERE xtype = 'U'

SELECT * FROM Orders
SELECT * FROM Products
SELECT * FROM [Order Details Extended]
SELECT * FROM  CustomerCustomerDemo
SELECT * FROM CustomerDemographics
SELECT * FROM Region
SELECT * FROM Territories
SELECT * FROM EmployeeTerritories
SELECT * FROM sysdiagrams
SELECT * FROM Employees
SELECT * FROM Categories
SELECT * FROM Customers
SELECT * FROM Shippers
SELECT * FROM Suppliers



SELECT * FROM Categories --CategoryID,CategorName, descripcion
SELECT * FROM Products		--productID, ProductName,UnitPrice , CategoryID
SELECT * FROM [Order Details Extended]  --ProductID, ProductName,OrderID


/*================================================================================
			EJEMPLO DE CONSULTA CON INNER JOIN
==================================================================================*/

SELECT p.ProductID,P.ProductName, c.CategoryName, p.UnitPrice FROM Products as P 
INNER JOIN Categories AS C ON P.categoryID = C.CategoryID
WHERE C.CategoryName = 'Seafood' AND p.UnitPrice < 50
ORDER BY p.ProductID ASC


EXECUTE PROC_GET_PRODUCTS_CATEGORY @CATEGORY = 'SeaFood', @UNIT_PRICE = 50

