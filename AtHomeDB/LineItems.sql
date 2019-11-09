CREATE TABLE [dbo].[LineItems]
(
	[receipt_item_id] INT NOT NULL PRIMARY KEY, 
    [product_id] INT NOT NULL, 
    [quantity] INT NOT NULL, 
    [is_taxed] TINYINT NOT NULL, 
    [product_price] DECIMAL(18, 2) NOT NULL, 
    [receipt_id] INT NOT NULL
)
