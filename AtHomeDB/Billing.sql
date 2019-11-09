CREATE TABLE [dbo].[Billing]
(
	[billing_id] INT NOT NULL PRIMARY KEY, 
    [card_number] VARCHAR(50) NULL, 
    [csc] VARCHAR(50) NULL, 
    [card_name] VARCHAR(MAX) NULL
)
