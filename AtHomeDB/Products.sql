CREATE TABLE [dbo].[Products]
(
	[product_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [category_id] INT NOT NULL, 
    [product_name] VARCHAR(50) NOT NULL, 
    [product_description] VARCHAR(MAX) NOT NULL, 
    [product_price] DECIMAL(18, 2) NOT NULL,
	[product_picture] VARCHAR(100)
)