CREATE TABLE [dbo].[Users]
(
	[user_id] INT NOT NULL PRIMARY KEY, 
    [user_username] VARCHAR(50) NULL, 
    [user_password] VARCHAR(MAX) NULL, 
    [user_sessionid] VARCHAR(50) NULL, 
    [user_profile] VARCHAR(MAX) NULL
)
