CREATE TABLE [dbo].Mjesta
(
	[MjestaId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Deleted] BIT NOT NULL DEFAULT 0, 
    [Naziv] NVARCHAR(50) NOT NULL, 
    [DrzaveId] INT NOT NULL, 
    CONSTRAINT [DrzaveFK] FOREIGN KEY ([DrzaveId]) REFERENCES [dbo].[Drzave] ([DrzaveId])
)
