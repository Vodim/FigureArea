# FigureArea
# Tasks
1) Write a C# library to deliver to external clients that can calculate the area of a circle by radius and a triangle by three sides. In addition to the operability we will evaluate:
Unit Tests
Ease of adding other shapes
Calculating the area of a shape without knowing the type of shape in compile-time
Checking whether a triangle is a right triangle

2) There are products and categories in the MS SQL Server database. One product can correspond to many categories, one category can have many products. Write an SQL query to select all pairs "Product name - Category name". If a product has no categories, its name should still be output:

SELECT 
	p.Name AS name_product, 
	c.Name AS name_category
FROM Products p
	LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
	LEFT JOIN Categories c ON pc.CategoryId = c.Id;
