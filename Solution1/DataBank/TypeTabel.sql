CREATE TABLE [dbo].[TypeTabel]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [naam] NVARCHAR(150) NOT NULL, 
    [typeTabel] BIT NOT NULL, 
    [aantalKolommen] INT NULL, 
    [minKolommen] INT NULL
)
