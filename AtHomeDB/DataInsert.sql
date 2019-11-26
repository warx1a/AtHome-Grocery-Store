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
INSERT INTO Categories (category_name, category_picture) VALUES ('Personal Care', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Poultry', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Meat', '');
INSERT INTO Categories (category_name, category_picture) VALUES ('Fruits', '');

/*cats 2, 4, 5, 6 are priced PER POUND*/
/* bread cat = 1 */
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (1, 'French Bread', 'Freshly baked french bread', 0.99, 'frenchbread.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (1, 'Hawaiian Rolls', 'Buttery soft Hawaiian Rolls', 1.79, 'kingshawaiian.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (1, 'Wheat Bread', 'Plain wheat bread', 0.79, 'wheatbread.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (1, 'Rye Bread', 'Plain rye bread', 0.79, 'ryebread.jpg');
/* vegetables cat = 2 */
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (2, 'Carrot', 'Freshly picked carrot', 0.46, 'carrot.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (2, 'Potato', 'Russet potato', 0.25, 'potato.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (2, 'Yam', 'Fresh yam', 0.64, 'yam.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (2, 'Tomato', 'Fresh roma tomatos', 0.49, 'tomato.jpg');
/* dollar cat = 3 */
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (3, 'Tissues', 'Generic tissues', 1.29, 'tissue.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (3, 'Body Soap', 'Non-scented body soap', 1.09, 'bodysoap.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (3, 'Comb', 'Comb for hair', 1.99, 'comb.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (3, 'Shampoo', 'Non-scented shampoo', 1.49, 'shampoo.jpg');
/*poultry cat = 4*/
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (4, 'Chicken Breast', 'Plain white meat chicken breast', 1.99, 'chickenbreast.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (4, 'Chicken Wings', 'Plain unseasoned white meat chicken wings', 1.49, 'chickenwings.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (4, 'Chicken Tenders', 'White meat chicken tenders', 1.79, 'chickentenders.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (4, 'Chicken Gizzards', 'Plain chicken gizzards', 1.29, 'chickengizzard.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (4, 'Whole Chicken', 'Non-scented shampoo', 1.29, 'wholechicken.jpg');
/*meat cat = 5*/
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (5, 'Prime Rib', 'Prime rib meat', 4.49, 'primerib.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (5, 'New York Strip', 'New York Strip Steak', 3.49, 'newyorkstrip.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (5, 'Ribeye', 'Ribeye cut', 3.29, 'ribeye.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (5, 'Flank', 'Beef flank', 2.99, 'flank.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (5, 'Ground Beef', '90% lean ground beef', 1.99, 'groundbeef.jpg');
/*fruits cat = 6*/
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (6, 'Orange', 'Fresh florida oranges', 0.69, 'orange.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (6, 'Apple', 'Crispy red delicious apple', 0.89, 'apple.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (6, 'Mango', 'Imported mangos', 0.99, 'mango.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (6, 'Lemon', 'Fresh lemon', 0.49, 'lemon.jpg');
INSERT INTO Products (category_id, product_name, product_description, product_price, product_picture) VALUES (6, 'Lime', 'Fresh lime', 0.25, 'lime.jpg');