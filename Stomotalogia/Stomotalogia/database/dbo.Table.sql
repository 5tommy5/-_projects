CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(25) NOT NULL, 
    [surname] VARCHAR(25) NOT NULL, 
    [position] CHAR(3) NOT NULL, 
    [work_time] CHAR(11) NOT NULL, 
    [work_days] VARCHAR(20) NOT NULL
)
