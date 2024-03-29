﻿/*
Deployment script for AtHomeDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "AtHomeDB"
:setvar DefaultFilePrefix "AtHomeDB"
:setvar DefaultDataPath "C:\Users\stink_000.LJ\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\stink_000.LJ\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
PRINT N'Rename refactoring operation with key 2ded8b01-c1dd-42ff-9930-bd092093a6b1 is skipped, element [dbo].[Products].[Id] (SqlSimpleColumn) will not be renamed to product_id';


GO
PRINT N'Rename refactoring operation with key 49639d4f-5c89-4b48-b009-d691bc06b6b5 is skipped, element [dbo].[Categories].[Id] (SqlSimpleColumn) will not be renamed to category_id';


GO
PRINT N'Rename refactoring operation with key 29679c75-22f2-458b-8bd8-306856844de6 is skipped, element [dbo].[Categories].[category_pictures] (SqlSimpleColumn) will not be renamed to category_picture';


GO
PRINT N'Creating [dbo].[Categories]...';


GO
CREATE TABLE [dbo].[Categories] (
    [category_id]      INT           NOT NULL,
    [category_name]    VARCHAR (50)  NOT NULL,
    [category_picture] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([category_id] ASC)
);


GO
PRINT N'Creating [dbo].[Products]...';


GO
CREATE TABLE [dbo].[Products] (
    [product_id]          INT             NOT NULL,
    [category_id]         INT             NOT NULL,
    [product_name]        VARCHAR (50)    NOT NULL,
    [product_description] VARCHAR (MAX)   NOT NULL,
    [product_price]       DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([product_id] ASC)
);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2ded8b01-c1dd-42ff-9930-bd092093a6b1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2ded8b01-c1dd-42ff-9930-bd092093a6b1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '49639d4f-5c89-4b48-b009-d691bc06b6b5')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('49639d4f-5c89-4b48-b009-d691bc06b6b5')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '29679c75-22f2-458b-8bd8-306856844de6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('29679c75-22f2-458b-8bd8-306856844de6')

GO

GO
PRINT N'Update complete.';


GO
