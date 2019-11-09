CREATE TABLE [dbo].[Shipping]
(
	[shipping_id] INT NOT NULL PRIMARY KEY, 
    [address] VARCHAR(MAX) NOT NULL, 
    [city] VARCHAR(MAX) NOT NULL, 
    [state] VARCHAR(MAX) NOT NULL, 
    [country] VARCHAR(MAX) NOT NULL, 
    [zipcode] INT NOT NULL
)
