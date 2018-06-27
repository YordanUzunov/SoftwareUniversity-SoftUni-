/* ******************************************
	Database Basics MS SQL Exam – 3 Jan 2018
*********************************************/

CREATE DATABASE TripService
GO

/* ******************************************
	Section 1. DDL (30 pts)
*********************************************/

USE TripService

/* ******************************************
	1. Database design
*********************************************/

CREATE TABLE Cities
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) NOT NULL,
	CountryCode VARCHAR(2) NOT NULL
)

CREATE TABLE Hotels
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(30) NOT NULL,
	CityId INT NOT NULL FOREIGN KEY REFERENCES Cities(Id),
	EmployeeCount INT NOT NULL,
	BaseRate DECIMAL(10,2)
)

CREATE TABLE Rooms
(
	Id INT PRIMARY KEY IDENTITY,
	Price DECIMAL(10,2) NOT NULL,
	Type NVARCHAR(20) NOT NULL,
	Beds INT NOT NULL,
	HotelId INT NOT NULL FOREIGN KEY REFERENCES Hotels(Id)
)

CREATE TABLE Trips
(
	Id INT PRIMARY KEY IDENTITY,
	RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id),
	BookDate DATE NOT NULL,
	ArrivalDate DATE NOT NULL,
	ReturnDate DATE NOT NULL,
	CancelDate DATE ,
	CONSTRAINT CHK_BookDate CHECK (BookDate < ArrivalDate),
	CONSTRAINT CHK_ArrivalDate CHECK (ArrivalDate < ReturnDate)
)

CREATE TABLE Accounts
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(20),
	LastName NVARCHAR(50) NOT NULL,
	CityId INT NOT NULL FOREIGN KEY REFERENCES Cities(Id),
	BirthDate DATE NOT NULL,
	Email NVARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE AccountsTrips
(
	AccountId INT NOT NULL,
	TripId INT NOT NULL,
	Luggage INT NOT NULL CHECK (Luggage >= 0),
	CONSTRAINT PK_AccountsTrips_AccountId_TripId PRIMARY KEY(AccountId, TripId),
	CONSTRAINT FK_AccountsTrips_Accounts FOREIGN KEY(AccountId) REFERENCES Accounts(Id),
	CONSTRAINT FK_AccountsTrips_Trips FOREIGN KEY(TripId) REFERENCES Trips(Id)	 
)

/* ******************************************
	Section 2. DML (10 pts)
*********************************************/

/* ******************************************
	2. Insert
*********************************************/

INSERT INTO Accounts (FirstName, MiddleName, LastName, CityId, BirthDate, Email) VALUES
('John', 'Smith', 'Smith', 34, '1975-07-21', 'j_smith@gmail.com'),
('Gosho', NULL , 'Petrov', 11, '1978-05-16', 'g_petrov@gmail.com'),
('Ivan', 'Petrovich', 'Pavlov', 59, '1849-09-26', 'i_pavlov@softuni.bg'),
('Friedrich', 'Wilhelm', 'Nietzsche', 2, '1844-10-15', 'f_nietzsche@softuni.bg')

INSERT INTO Trips (RoomId, BookDate, ArrivalDate, ReturnDate, CancelDate) VALUES
(101, '2015-04-12', '2015-04-14', '2015-04-20', '2015-02-02'),
(102, '2015-07-07', '2015-07-15', '2015-07-22', '2015-04-29'),
(103, '2013-07-17', '2013-07-23', '2013-07-24', NULL),
(104, '2012-03-17', '2012-03-31', '2012-04-01', '2012-01-10'),
(109, '2017-08-07', '2017-08-28', '2017-08-29', NULL)

/* ******************************************
	3. Update
*********************************************/

UPDATE Rooms
SET Price *= 1.14
WHERE HotelId IN (5,7,9)


/* ******************************************
	4. Delete
*********************************************/

DELETE FROM AccountsTrips
WHERE AccountId = 47

/* ******************************************
	Section 3. Querying (40 pts)
*********************************************/

/* ******************************************
	5. Bulgarian Cities
*********************************************/

SELECT Id, Name  
FROM Cities
WHERE CountryCode = 'BG'
ORDER BY Name

/* ******************************************
	6. People Born After 1991
*********************************************/

SELECT (RTRIM(LTRIM(RTRIM(FirstName)) + ' ' + ISNULL(LTRIM(RTRIM(MiddleName)), '')) + ' ' + LTRIM(RTRIM(LastName))) 
AS [Full Name],
		YEAR(BirthDate) AS [BirthYear]
FROM Accounts
WHERE YEAR(BirthDate) > 1991
ORDER BY BirthYear DESC, FirstName

/* ******************************************
	7. EEE-Mails
*********************************************/

SELECT FirstName, LastName, FORMAT(BirthDate, 'MM-dd-yyyy') AS BirthDate, c.Name, Email
FROM Accounts AS a
	JOIN Cities AS c ON c.Id = a.CityId
WHERE Email LIKE 'e%'
ORDER BY c.Name DESC
	
/* ******************************************
	8. City Statistics
*********************************************/

SELECT c.Name, COUNT(h.Id) AS [Hotels]
FROM Hotels AS h
	RIGHT JOIN Cities AS c ON c.Id = h.CityId
GROUP BY c.Name
ORDER BY [Hotels] DESC, c.Name

/* ******************************************
	9. Expensive First-Class Rooms
*********************************************/

SELECT r.Id, r.Price, h.Name, c.Name
FROM Rooms AS r
	JOIN Hotels AS h ON h.Id = r.HotelId
	JOIN Cities AS c ON c.Id = h.CityId
WHERE r.Type = 'First Class'
ORDER BY Price DESC, r.Id

/* ******************************************
	10. Longest and Shortest Trips
*********************************************/

SELECT at.AccountId, 
	   CONCAT(FirstName, ' ', LastName) AS FullName, 
	   MAX(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) AS LongestTrip,
	   MIN(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) AS ShortestTrip
FROM Trips AS t
	JOIN AccountsTrips AS at ON at.TripId = t.Id
	JOIN Accounts AS a ON a.Id = at.AccountId
WHERE a.MiddleName IS NULL AND t.CancelDate IS NULL
GROUP BY at.AccountId, CONCAT(FirstName, ' ', LastName)
ORDER BY LongestTrip DESC, at.AccountId

/* ******************************************
	11. Metropolis
*********************************************/

SELECT TOP (5) c.Id,
			   c.Name AS [City],
			   c.CountryCode AS [Country],
			   COUNT(a.Id) AS [Accounts]
FROM Accounts AS a
	JOIN Cities AS c ON c.Id = a.CityId
GROUP BY c.Id, c.Name, c.CountryCode
ORDER BY [Accounts] DESC

/* ******************************************
	12. Romantic Getaways
*********************************************/

SELECT at.AccountId AS [Id], 
	   a.Email, 
	   c.Name AS [City],
	   COUNT(t.Id) AS [Trips]
FROM Accounts AS a
	JOIN Cities AS c ON c.Id = a.CityId
	JOIN AccountsTrips AS at ON at.AccountId = a.Id
	JOIN Trips AS t ON t.Id = at.TripId
	JOIN Rooms AS r ON r.Id = t.RoomId
	JOIN Hotels AS h ON h.Id = r.HotelId
WHERE a.CityId = h.CityId
GROUP BY at.AccountId, a.Email, c.Name
HAVING COUNT(t.Id) >= 1
ORDER BY [Trips] DESC, at.AccountId

/* ******************************************
	13. Lucrative Destinations
*********************************************/

SELECT TOP (10) c.Id,
				c.Name,
				SUM(BaseRate) + SUM(r.Price) AS [Total Revenue],
				COUNT(t.Id) AS [Trips]
FROM Cities AS c
	JOIN Hotels AS h ON h.CityId = c.Id
	JOIN Rooms AS r ON r.HotelId = h.Id
	JOIN Trips As t ON t.RoomId = r.Id
WHERE YEAR(BookDate) = 2016
GROUP BY c.Id, c.Name
ORDER BY [Total Revenue] DESC, [Trips] DESC

/* ******************************************
	14. Trip Revenues
*********************************************/

SELECT DISTINCT at.TripId AS [Id],
	   h.Name AS [HotelName],
	   r.Type AS [RoomType],
	   CASE
		WHEN t.CancelDate IS NOT NULL THEN 0.00
		WHEN t.CancelDate IS NULL AND (SELECT COUNT(AccountId) FROM AccountsTrips WHERE TripId = at.TripId) = 1 THEN h.BaseRate + r.Price
		WHEN t.CancelDate IS NULL AND (SELECT COUNT(AccountId) FROM AccountsTrips WHERE TripId = at.TripId) >= 1 
			THEN (h.BaseRate + r.Price) * (SELECT COUNT(AccountId) FROM AccountsTrips WHERE TripId = at.TripId)
	   END AS [Revenue]
FROM Hotels AS h 
	JOIN Rooms AS r ON r.HotelId = h.Id
	JOIN Trips As t ON t.RoomId = r.Id
	JOIN AccountsTrips AS at ON at.TripId = t.Id
GROUP BY at.TripId, h.Name, r.Type, t.CancelDate, h.BaseRate, r.Price
ORDER BY [RoomType], [Id]

SELECT *
FROM AccountsTrips 
WHERE TripId = 212

/* ******************************************
	15. Top Travelers
*********************************************/

SELECT AccountId, Email, CountryCode, mostTrips AS [Trips]
FROM
	(
	SELECT AccountId, 
		   Email, 
		   CountryCode, 
		   MAX([TripsCount]) AS [mostTrips],
		   ROW_NUMBER() OVER (PARTITION BY CountryCode ORDER BY MAX([TripsCount]) DESC) AS ranks
	FROM
		(
		SELECT at.AccountId,
			   a.Email,
			   c.CountryCode,
			   COUNT(*) AS [TripsCount]
		FROM Cities AS c
			JOIN Hotels AS h ON h.CityId = c.Id
			JOIN Rooms AS r ON r.HotelId = h.Id
			JOIN Trips AS t ON t.RoomId = r.Id
			JOIN AccountsTrips AS at ON at.TripId = t.Id
			JOIN Accounts AS a ON a.Id = at.AccountId
		GROUP BY at.AccountId, a.Email, c.CountryCode
		) AS H
	GROUP BY AccountId, Email, CountryCode
	) AS H1
WHERE ranks = 1
ORDER BY [Trips] DESC, AccountId

/* ******************************************
	16. Luggage Fees
*********************************************/

SELECT TripId,
	   Luggage,
	   CASE
		WHEN Luggage > 5 THEN ('$' + CONVERT(NVARCHAR(10), Luggage * 5))
		ELSE ('$' + CONVERT(NVARCHAR(10), 0))
	   END AS Fee
FROM
(
SELECT TripId, SUM(Luggage) AS [Luggage]
FROM AccountsTrips
GROUP BY TripId
HAVING SUM(Luggage) > 0
) AS H
ORDER BY [Luggage] DESC

/* ******************************************
	17. GDPR Violation
*********************************************/

SELECT TripId, [Full Name], [From], c.Name AS [To], Duration
FROM
	(
	SELECT at.TripId, 
		   (RTRIM(LTRIM(RTRIM(a.FirstName)) + ' ' + ISNULL(LTRIM(RTRIM(a.MiddleName)), '')) + ' ' + LTRIM(RTRIM(a.LastName))) AS [Full Name],
		   c.Name AS [From],
		   CASE
			WHEN t.CancelDate IS NULL THEN  CONVERT(NVARCHAR(10), DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) + ' days'
			WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
		   END AS Duration,
		   t.RoomId
	FROM Cities AS c
		JOIN Accounts AS a ON a.CityId = c.Id
		JOIN AccountsTrips AS at ON at.AccountId = a.Id
		JOIN Trips AS t ON t.Id = at.TripId
	GROUP BY at.TripId, c.Name, t.RoomId, a.FirstName, a.MiddleName, a.LastName, t.CancelDate, t.ArrivalDate, t.ReturnDate
	) AS HelpTable
JOIN Rooms AS r ON r.Id = HelpTable.RoomId
JOIN Hotels AS h ON h.Id = r.HotelId
JOIN Cities AS c ON c.Id = h.CityId
ORDER BY [Full Name], TripId
GO

/* ******************************************
	Section 4. Programmability (14 pts)
*********************************************/

/* ******************************************
	18. Available Room
*********************************************/

CREATE FUNCTION udf_GetAvailableRoom(@HotelId INT, @Date DATETIME2, @People INT) RETURNS VARCHAR(MAX)
AS BEGIN

   DECLARE @BookedRooms TABLE(Id INT)
                       INSERT INTO @BookedRooms
                   SELECT DISTINCT R.Id
                              FROM Rooms R
                         LEFT JOIN Trips T on R.Id = T.RoomId
                             WHERE R.HotelId = @HotelId AND @Date BETWEEN T.ArrivalDate AND T.ReturnDate AND T.CancelDate IS NULL

   DECLARE @AvailableRoom NVARCHAR(MAX) = 
                     (SELECT TOP(1) CONCAT('Room ', r.Id, ': ', r.Type,' (', r.Beds, ' beds) - $',
					                     (h.BaseRate + r.Price) * @People)
                              FROM Hotels AS h
                              JOIN Rooms AS r
                                ON r.HotelId = h.Id
                              JOIN Trips AS t
                                ON t.RoomId = r.Id
                             WHERE r.Id NOT IN(SELECT Id FROM @BookedRooms)
                               AND h.Id = @HotelId AND r.Beds >= @People
                          ORDER BY r.Price DESC)

		IF(@AvailableRoom IS NULL)
		BEGIN
		   RETURN 'No rooms available' 
		END 
		
	    RETURN @AvailableRoom	
END
GO

--TEST
SELECT dbo.udf_GetAvailableRoom(112, '2011-12-17', 2)
SELECT dbo.udf_GetAvailableRoom(94, '2015-07-26', 3)
GO

/* ******************************************
	19. Switch Room
*********************************************/

CREATE PROCEDURE usp_SwitchRoom(@TripId INT, @TargetRoomId INT)
AS
BEGIN
    DECLARE @HotelId INT = (SELECT TOP(1) r.HotelId
	                                 FROM Trips AS t
	                                 JOIN Rooms AS r ON r.Id = t.RoomId
							        WHERE t.Id = @TripId)
      
    DECLARE @TargetRoomHotelId INT = (SELECT TOP(1) r.HotelId
	                                           FROM Rooms AS r
									          WHERE r.Id = @TargetRoomId)            

	   IF(@HotelId != @TargetRoomHotelId)
	    BEGIN 
	      ;THROW 99001, 'Target room is in another hotel!', 1;
	    END

	DECLARE @NumberOfPeople INT = (SELECT COUNT(*)
	                                 FROM AccountsTrips AS at
	                                WHERE at.TripId = @TripId)
  
	   IF((SELECT TOP(1) Beds FROM Rooms WHERE Id = @TargetRoomId) < @NumberOfPeople)
		BEGIN 
		  ;THROW 99001, 'Not enough beds in target room!', 1;
		END

	 UPDATE Trips
	    SET RoomId = @TargetRoomId
	  WHERE Id = @TripId
END
GO

/* ******************************************
	Section 5. Bonus (6 pts)
*********************************************/

/* ******************************************
	20. Cancel Trip
*********************************************/

CREATE TRIGGER tr_CancelTrip
ON Trips
INSTEAD OF DELETE
AS
BEGIN
UPDATE t SET t.CancelDate = GETDATE()
  FROM Trips AS t JOIN DELETED d 
    ON d.Id = t.Id
 WHERE t.CancelDate IS NULL  
END
GO
