CREATE PROCEDURE PROC_GET_PRODUCTS_CATEGORY
(
	@CATEGORY VARCHAR(25) = '',
	@UNIT_PRICE DECIMAL(18,2)
)
AS
BEGIN
		SELECT p.ProductID,P.ProductName, c.CategoryName, p.UnitPrice FROM Products as P 
		INNER JOIN Categories AS C ON P.categoryID = C.CategoryID
		WHERE C.CategoryName = @CATEGORY AND p.UnitPrice < @UNIT_PRICE
		ORDER BY p.ProductID ASC
END