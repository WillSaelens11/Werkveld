CREATE TABLE [dbo].[TypeKolom-Tabel]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [tabel_id] INT NOT NULL, 
    [typeKolom_id] INT NOT NULL, 
    [data] NVARCHAR(150) NOT NULL, 
    CONSTRAINT [FK_TypeKolom-Tabel_Tabel] FOREIGN KEY ([tabel_id]) REFERENCES [Tabel]([id]), 
    CONSTRAINT [FK_TypeKolom-Tabel_TypeKolom] FOREIGN KEY ([typeKolom_id]) REFERENCES [TypeKolom]([id])
)
