/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Categories (category_name, category_picture) VALUES ('Bread','');
INSERT INTO Categories (category_name, category_picture) VALUES ('Vegetables', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Dollar', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Poultry', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Meat', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Bakery', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Personal Care', '');

INSERT INTO Products (category_id, product_name, product_description, product_price) VALUES (1, 'French Bread', 'Freshly baked french bread', 0.99);
INSERT INTO Products (category_id, product_name, product_description, product_price) VALUES (1, 'Hawaiian Rolls', 'Buttery soft Hawaiian Rolls', 1.79);