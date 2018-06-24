/* ******************************************
	Resource queries for creating the databases necessary for the following exercises:
	https://github.com/YordanUzunov/SoftwareUniversity-SoftUni-/tree/master/Database%20Basics%20-%20MS%20SQL/Resource%20Databases
*********************************************/

/* *****************************************************
	Part I – Queries for Diablo Database
********************************************************/

USE Diablo;

/* *****************************************************
	Problem 1.	Number of Users for Email Provider
********************************************************/

SELECT domains.[Email Provider],
       COUNT([Email Provider]) AS [Number Of Users]
FROM
(
    SELECT SUBSTRING(Email, CHARINDEX('@', Email)+1, LEN(Email)-CHARINDEX('@', Email)+1) AS [Email Provider]
	--RIGHT(Email, LEN(Email)-CHARINDEX('@', Email)) AS [Email Provider]
    FROM Users
) AS domains
GROUP BY [Email Provider]
ORDER BY [Number Of Users] DESC,
         [Email Provider] ASC;
		 
/* *****************************************************
	Problem 2.	All User in Games
********************************************************/

SELECT 
		g.Name AS [Game],		
		gt.Name AS [Game Type],
		u.[Username],
		ug.[Level],
		ug.[Cash],
		c.[Name] AS	[Character]
FROM UsersGames AS ug
	JOIN Games AS g ON g.Id = ug.GameId
	JOIN GameTypes AS gt ON gt.Id = g.GameTypeId
	JOIN Users AS u ON u.Id = ug.UserId
	JOIN Characters AS c ON c.Id = ug.CharacterId
ORDER BY ug.[Level] DESC,
		 u.[Username],
		 g.[Name]

/* *****************************************************
	Problem 3.	Users in Games with Their Items
********************************************************/

SELECT 
		u.[Username],		
		g.Name AS [Game],
		COUNT(ugi.ItemId) AS [Items Count],
		SUM(i.Price) AS [Items Price]
FROM UsersGames AS ug
	JOIN Games AS g ON g.Id = ug.GameId
	JOIN Users AS u ON u.Id = ug.UserId
	JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
	JOIN Items AS i ON i.Id = ugi.ItemId
GROUP BY u.Username,
		 g.Name
HAVING COUNT(ugi.ItemId) >= 10
ORDER BY [Items Count] DESC,
		 [Items Price] DESC,
		 u.[Username]

/* *****************************************************
	Problem 4.	* User in Games with Their Statistics
********************************************************/

SELECT 
		u.[Username],
		g.Name AS [Game],		
		MAX(c.[Name]) AS [Character],
		MAX(stc.Strength) + MAX(stgt.Strength) + SUM(sti.Strength) AS [Strength],
		MAX(stc.Defence) + MAX(stgt.Defence) + SUM(sti.Defence) AS [Defence],
		MAX(stc.Speed) + MAX(stgt.Speed) + SUM(sti.Speed) AS [Speed],
		MAX(stc.Mind) + MAX(stgt.Mind) + SUM(sti.Mind) AS [Mind],
		MAX(stc.Luck) + MAX(stgt.Luck) + SUM(sti.Luck) AS [Luck]
FROM UsersGames AS ug
	JOIN Games AS g ON g.Id = ug.GameId
	JOIN GameTypes AS gt ON gt.Id = g.GameTypeId
	JOIN Users AS u ON u.Id = ug.UserId
	JOIN Characters AS c ON c.Id = ug.CharacterId
	JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
	JOIN Items AS i ON i.Id = ugi.ItemId
	JOIN [Statistics] AS stgt ON stgt.Id = gt.BonusStatsId
	JOIN [Statistics] AS stc ON stc.Id = c.StatisticId
	JOIN [Statistics] AS sti ON sti.Id = i.StatisticId
GROUP BY u.[Username], g.Name
ORDER BY Strength DESC, Defence DESC, Speed DESC, Mind DESC, Luck DESC

/* *****************************************************
	Problem 5.	All Items with Greater than Average Statistics
********************************************************/

WITH Averages_CTE (avgSpeed, avgLuck, avgMind)
AS
(
SELECT 
AVG(st.Speed) AS avgSpeed, AVG(st.Luck) AS avgLuck, AVG(st.Mind) AS avgMind
FROM Items AS i
	JOIN [Statistics] AS st ON st.Id = i.StatisticId
)


SELECT i.Name, i.Price, i.MinLevel, st.Strength, st.Defence,
				 st.Speed, st.Luck, st.Mind
FROM Items AS i
	JOIN [Statistics] AS st ON st.Id = i.StatisticId
	WHERE st.Speed > (SELECT avgSpeed FROM Averages_CTE) AND
		  st.Luck > (SELECT avgLuck FROM Averages_CTE) AND
		  st.Mind > (SELECT avgMind FROM Averages_CTE)
GROUP BY i.Name,
		 i.Price,
		 i.MinLevel,
		 st.Strength, 
		 st.Defence,
		 st.Speed, 
		 st.Luck, 
		 st.Mind

/* *****************************************************
	Problem 6.	Display All Items with Information about Forbidden Game Type
********************************************************/

SELECT i.Name AS [Item], 
	   i.Price, 
	   i.MinLevel, 
	   gt.Name AS [Forbidden Game Type]
FROM Items AS i 
	LEFT JOIN GameTypeForbiddenItems AS fi ON fi.ItemId = i.Id
	LEFT JOIN GameTypes AS gt ON fi.GameTypeId = gt.Id
ORDER BY [Forbidden Game Type] DESC, 
		 [Item]

/* *****************************************************
	Problem 7.	Buy Items for User in Game
********************************************************/

DECLARE @gameName NVARCHAR(50) = 'Edinburgh'
DECLARE @userName NVARCHAR(50) = 'Alex'
DECLARE @userGameId INT = 
(
	SELECT ug.Id
	FROM UsersGames AS ug
		JOIN Users AS u ON u.Id = ug.UserId
		JOIN Games AS g ON g.Id = ug.GameId
	WHERE u.Username = @userName AND g.Name = @gameName
)

DECLARE @initialCash MONEY = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
DECLARE @itemsTotalPrice MONEY = 
(
	SELECT SUM(Price) FROM Items WHERE [Name] IN
	('Blackguard', 'Bottomless Potion of Amplification', 'Eye of Etlich (Diablo III)',
     'Gem of Efficacious Toxin', 'Golden Gorget of Leoric', 'Hellfire Amulet')
)

IF (@initialCash >= @itemsTotalPrice)
BEGIN
	BEGIN TRANSACTION
		UPDATE UsersGames SET Cash -= @itemsTotalPrice WHERE Id = @userGameId
		IF (@@ROWCOUNT <> 1)
		BEGIN
			ROLLBACK
			RAISERROR('Could not make payment', 16, 1)
			RETURN
		END

		INSERT INTO UserGameItems (ItemId, UserGameId)
		(
			(SELECT Id, @userGameId FROM Items WHERE [Name] IN
			('Blackguard', 'Bottomless Potion of Amplification', 'Eye of Etlich (Diablo III)',
		     'Gem of Efficacious Toxin', 'Golden Gorget of Leoric', 'Hellfire Amulet')
		))

		IF((SELECT COUNT(*) FROM Items WHERE Name IN 
			('Blackguard', 'Bottomless Potion of Amplification', 'Eye of Etlich (Diablo III)', 
			 'Gem of Efficacious Toxin', 'Golden Gorget of Leoric', 'Hellfire Amulet')) <> @@ROWCOUNT)
	    BEGIN
			ROLLBACK 
			RAISERROR('Could not buy items', 16, 1) 
			RETURN
		END

	COMMIT
END

SELECT u.Username, 
	   g.Name, 
	   ug.Cash, 
	   i.Name AS [Item Name]
FROM UsersGames AS ug
	JOIN Games AS g ON ug.GameId = g.Id
	JOIN Users AS u ON ug.UserId = u.Id
	JOIN UserGameItems AS ugi ON ug.Id = ugi.UserGameId
	JOIN Items AS i ON i.Id = ugi.ItemId
WHERE g.Name = @gameName

/* *****************************************************
	Problem 8.	Peaks and Mountains
********************************************************/

USE [Geography]

SELECT p.PeakName,
	   m.MountainRange AS Mountain,
	   p.Elevation
FROM Mountains AS m
	JOIN Peaks AS p ON p.MountainId = m.Id
ORDER BY Elevation DESC,
		 PeakName

/* *****************************************************
	Problem 9.	Peaks with Their Mountain, Country and Continent
********************************************************/

SELECT p.PeakName,
	   m.MountainRange AS Mountain,
	   c.CountryName,
	   cont.ContinentName
FROM Mountains AS m
	JOIN Peaks AS p ON p.MountainId = m.Id
	JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
	JOIN Countries AS c ON c.CountryCode = mc.CountryCode
	JOIN Continents AS cont ON cont.ContinentCode = c.ContinentCode
GROUP BY c.CountryName,
		 p.PeakName,
		 m.MountainRange,
		 cont.ContinentName
ORDER BY PeakName, CountryName

/* *****************************************************
	Problem 10.	Rivers by Country
********************************************************/

SELECT c.CountryName,
       cont.ContinentName,
	   ISNULL(COUNT(r.Id), 0) AS [RiversCount],
	   ISNULL(SUM(r.Length), 0) AS [TotalLength]  
FROM Countries AS c
	LEFT JOIN Continents AS cont ON cont.ContinentCode = c.ContinentCode
	LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName,
		 cont.ContinentName
ORDER BY [RiversCount] DESC,
		 [TotalLength] DESC,
		 c.CountryName

/* *****************************************************
	Problem 11.	Count of Countries by Currency
********************************************************/

SELECT cu.CurrencyCode,
	   cu.Description AS [Currency],
	   COUNT(co.CountryCode) AS [NumberOfCountries]
FROM Currencies AS cu
	LEFT JOIN Countries AS co ON co.CurrencyCode = cu.CurrencyCode
GROUP BY cu.CurrencyCode,
		 cu.Description
ORDER BY [NumberOfCountries] DESC,
	     [Currency]

/* *****************************************************
	Problem 12.	Population and Area by Continent
********************************************************/

SELECT cont.ContinentName,
	   SUM(CAST(c.AreaInSqKm AS BIGINT)) AS [CountriesArea],
	   SUM(CAST(c.Population AS BIGINT)) AS [CountriesPopulation] 
FROM Continents AS cont
	JOIN Countries AS c ON c.ContinentCode = cont.ContinentCode
GROUP BY cont.ContinentName		 
ORDER BY CountriesPopulation DESC

/* *****************************************************
	Problem 13.	Monasteries by Country
********************************************************/

CREATE TABLE Monasteries(
  Id int NOT NULL IDENTITY, 
  Name nvarchar(200) NOT NULL, 
  CountryCode char(2) NOT NULL,
  CONSTRAINT PK_Monasteries PRIMARY KEY (Id),
  CONSTRAINT FK_Monasteries_Countries FOREIGN KEY (CountryCode) REFERENCES Countries(CountryCode)
)

INSERT INTO Monasteries(Name, CountryCode) VALUES
  ('Rila Monastery “St. Ivan of Rila”', 'BG'), 
  ('Bachkovo Monastery “Virgin Mary”', 'BG'),
  ('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
  ('Kopan Monastery', 'NP'),
  ('Thrangu Tashi Yangtse Monastery', 'NP'),
  ('Shechen Tennyi Dargyeling Monastery', 'NP'),
  ('Benchen Monastery', 'NP'),
  ('Southern Shaolin Monastery', 'CN'),
  ('Dabei Monastery', 'CN'),
  ('Wa Sau Toi', 'CN'),
  ('Lhunshigyia Monastery', 'CN'),
  ('Rakya Monastery', 'CN'),
  ('Monasteries of Meteora', 'GR'),
  ('The Holy Monastery of Stavronikita', 'GR'),
  ('Taung Kalat Monastery', 'MM'),
  ('Pa-Auk Forest Monastery', 'MM'),
  ('Taktsang Palphug Monastery', 'BT'),
  ('Sümela Monastery', 'TR');


WITH CTE_CountriesWithMoreRivers (CountryCode) AS 
(
  SELECT c.CountryCode
  FROM Countries AS c
	JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
  GROUP BY c.CountryCode
  HAVING COUNT(cr.RiverId) > 3
)

UPDATE Countries
SET IsDeleted = 1
WHERE CountryCode IN (SELECT * FROM CTE_CountriesWithMoreRivers)

SELECT m.Name AS Monastery, c.CountryName AS Country
FROM Monasteries AS m
	JOIN Countries AS c ON c.CountryCode = m.CountryCode
WHERE c.IsDeleted = 0
ORDER BY Monastery

/* *****************************************************
	Problem 14.	Monasteries by Continents and Countries
********************************************************/

UPDATE Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'

INSERT INTO Monasteries(Name, CountryCode)
(SELECT 'Hanga Abbey', CountryCode FROM Countries AS c WHERE CountryName = 'Tanzania')

INSERT INTO Monasteries(Name, CountryCode)
(SELECT 'Myin-Tin-Daik', CountryCode FROM Countries AS c WHERE CountryName = 'Myanmar')

SELECT cont.ContinentName,
	   c.CountryName,
	   COUNT(m.Name) AS [MonasteriesCount]
FROM Countries AS c
	LEFT JOIN Continents AS cont ON cont.ContinentCode = c.ContinentCode
	LEFT JOIN Monasteries AS m ON m.CountryCode = c.CountryCode
WHERE c.IsDeleted = 0
GROUP BY cont.ContinentName, c.CountryName
ORDER BY [MonasteriesCount] DESC,
		 c.CountryName
