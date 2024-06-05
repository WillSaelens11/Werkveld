CREATE TABLE [dbo].[Kolom]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [naam] NVARCHAR(150) NOT NULL, 
    [typeKolom_id] INT NOT NULL, 
    [tabel_id] INT NOT NULL, 
    CONSTRAINT [FK_Kolom_TypeKolom] FOREIGN KEY ([typeKolom_id]) REFERENCES [TypeKolom]([id]), 
)
