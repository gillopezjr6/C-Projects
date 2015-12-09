CREATE TABLE [dbo].User_Registration
(
	[userID] INT NOT NULL PRIMARY KEY, 
    [first_name] NVARCHAR(50) NULL, 
    [last_name] NVARCHAR(50) NULL, 
    [email] NVARCHAR(50) NULL, 
    [phone_number] NVARCHAR(50) NULL, 
    [user_name] NVARCHAR(50) NULL, 
    [password] NCHAR(10) NULL
)
