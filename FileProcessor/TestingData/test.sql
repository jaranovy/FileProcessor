SELECT [ID], [nazev], ([pocet_kusu_skladem] - [pocet_objednanych_kusu]) as [pocet_expedovanych_kusu] from [dbo].[Zbozi] ORDER BY [ID];

UPDATE [Dbo].[Zbozi] SET [pocet_objednanych_kusu] = 2 WHERE [ID] = 1;