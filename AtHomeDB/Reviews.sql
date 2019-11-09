CREATE TABLE [dbo].[Reviews]
(
	[review_id] INT NOT NULL PRIMARY KEY, 
    [review_rating] INT NOT NULL, 
    [product_id] INT NOT NULL, 
    [review_description] VARCHAR(MAX) NULL
)
