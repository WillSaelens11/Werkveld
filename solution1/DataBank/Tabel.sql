CREATE TABLE [dbo].[Tabel]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [naam] NVARCHAR(150) NOT NULL, 
    [typeTabel_id] INT NOT NULL, 
    CONSTRAINT [FK_Tabel_TypeTabel] FOREIGN KEY ([typeTabel_id]) REFERENCES [TypeTabel]([id])
)
