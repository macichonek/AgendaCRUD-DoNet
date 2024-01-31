CREATE TABLE [dbo].[pessoas]
(
	[ContatoID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(100) NULL, 
    [Empresa] NVARCHAR(100) NULL, 
    [Telefone] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Cliente] BIT NULL, 
    [Última Ligação] DATETIME NULL
)
