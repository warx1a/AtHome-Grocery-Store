CREATE TABLE [dbo].[Receipts]
(
	[receipt_id] INT NOT NULL PRIMARY KEY, 
    [billing_id] INT NOT NULL, 
    [customer_id] INT NOT NULL, 
    [order_total] DECIMAL(18, 2) NOT NULL, 
    [tax_amount] DECIMAL(18, 2) NOT NULL, 
    [shipping_id] INT NOT NULL
)
