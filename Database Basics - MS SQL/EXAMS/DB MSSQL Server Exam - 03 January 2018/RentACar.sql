/* ******************************************
	Database Basics MS SQL Exam – 3 Jan 2018
*********************************************/

CREATE DATABASE RentACar
GO

/* ******************************************
	Section 1. DDL (30 pts)
*********************************************/
USE RentACar

/* ******************************************
	1.	Database design
*********************************************/

CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Gender CHAR(1) NOT NULL CHECK (Gender IN ('M', 'F')),
	BirthDate DATETIME,
	CreditCard NVARCHAR(30) NOT NULL,
	CardValidity DATETIME NOT NULL,
	Email NVARCHAR(50) NOT NULL
);

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Offices
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(40),
	ParkingPlaces INT,
	TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id)
);

CREATE TABLE Models
(
	Id INT PRIMARY KEY IDENTITY,
	Manufacturer NVARCHAR(50) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	ProductionYear DATETIME,
	Seats INT NOT NULL,
	Class NVARCHAR(10),
	Consumption DECIMAL(14,2)
);

CREATE TABLE Vehicles 
(
	Id INT PRIMARY KEY IDENTITY,
	ModelId INT NOT NULL FOREIGN KEY REFERENCES Models(Id),
	OfficeId INT NOT NULL FOREIGN KEY REFERENCES Offices(Id),
	Mileage INT NOT NULL DEFAULT(0)
);

CREATE TABLE Orders
(
	Id	INT PRIMARY KEY IDENTITY,
	ClientId INT NOT NULL FOREIGN KEY REFERENCES Clients(Id),
	TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id),
	VehicleId INT NOT NULL FOREIGN KEY REFERENCES Vehicles(Id),
	CollectionDate DATETIME NOT NULL,
	CollectionOfficeId INT NOT NULL FOREIGN KEY REFERENCES Offices(Id),
	ReturnDate DATETIME NULL,
	ReturnOfficeId INT NULL FOREIGN KEY REFERENCES Offices(Id),	
	Bill DECIMAL(14,2) DEFAULT(0),
	TotalMileage INT DEFAULT(0)
);

/* ******************************************
	Section 2. DML (10 pts)
*********************************************/

/* ******************************************
	2.	Insert
*********************************************/

INSERT INTO Models (Manufacturer, Model, ProductionYear, Seats, Class, Consumption) VALUES
('Chevrolet',	'Astro',	'2005-07-27 00:00:00.000',	4,	'Economy',	12.60),
('Toyota',	'Solara',	'2009-10-15 00:00:00.000',	7,	'Family',	13.80	 ),
('Volvo',	'S40',	'2010-10-12 00:00:00.000',	3,	'Average',	11.30		 ),
('Suzuki',	'Swift',	'2000-02-03 00:00:00.000',	7,	'Economy',	16.20	 )

INSERT INTO ORDERS (ClientId, TownId, VehicleId, CollectionDate, CollectionOfficeId, 
					ReturnDate, ReturnOfficeId, Bill, TotalMileage) VALUES
(17, 2,  52, '2017-08-08', 30, '2017-09-04', 42, 2360.00, 7434),
(78, 17, 50, '2017-04-22', 10, '2017-05-09', 12, 2326.00, 7326),
(27, 13, 28, '2017-04-25', 21, '2017-05-09', 34, 597.00, 1880)

/* ******************************************
	3.	Update
*********************************************/

UPDATE Models
SET Class = 'Luxury'
WHERE Consumption > 20

/* ******************************************
	4.	Delete
*********************************************/

DELETE FROM Orders
WHERE ReturnDate IS NULL

/* ******************************************
	Section 3. Querying (40 pts)
*********************************************/

/* ******************************************
	5.	Showroom
*********************************************/

SELECT Manufacturer, Model
FROM Models
ORDER BY Manufacturer, Id DESC

/* ******************************************
	6.	Y Generation
*********************************************/

SELECT FirstName, LastName 
FROM Clients
WHERE YEAR(BirthDate) BETWEEN 1977 AND 1994
ORDER BY FirstName, LastName, Id

/* ******************************************
	7.	Spacious Office
*********************************************/

SELECT  t.Name AS [TownName], o.Name AS [OfficeName], o.ParkingPlaces
FROM Offices AS o
	JOIN Towns AS t ON t.Id = o.TownId
WHERE o.ParkingPlaces > 25
ORDER BY t.Name, o.Id

/* ******************************************
	8.	Available Vehicles
*********************************************/

SELECT m.Model, m.Seats, v.Mileage
FROM Models AS m
	JOIN Vehicles AS v ON v.ModelId = m.Id
WHERE v.Id NOT IN (
	SELECT o.VehicleId
	FROM Orders AS o
	WHERE o.ReturnDate IS NULL
)
ORDER BY v.Mileage, m.Seats DESC, m.Id

/* ******************************************
	9.	Offices per Town
*********************************************/

SELECT t.Name AS [TownName], COUNT(t.Id) [OfficesNumber]
FROM Offices AS o
	JOIN Towns AS t ON t.Id = o.TownId
GROUP BY t.Name
ORDER BY COUNT(t.Id) DESC, [TownName]

/* ******************************************
	10.	Buyers Best Choice 
*********************************************/

SELECT Manufacturer, Model, SUM(OrdersById) AS [Times Ordered]
FROM
(
SELECT m.Manufacturer, m.Model, v.Id, COUNT(v.Id) AS OrdersById
FROM Orders AS o
	LEFT JOIN Vehicles AS v ON v.Id = o.VehicleId
	RIGHT JOIN Models AS m ON m.Id = v.ModelId
GROUP BY m.Manufacturer, m.Model, v.Id
) AS H
GROUP BY Manufacturer, Model
ORDER BY [Times Ordered] DESC, Manufacturer DESC, Model

/* ******************************************
	11.	Kinda Person
*********************************************/

SELECT Name, Class
FROM
(
SELECT H.Id, Name, m.Class, RANK() OVER (PARTITION BY H.Name ORDER BY COUNT(m.Class) DESC) AS ranks  
FROM
(
SELECT FirstName + ' ' + LastName AS [Name], c.Id
FROM Clients AS c
WHERE c.Id IN (SELECT ClientId FROM Orders)
) AS H
	JOIN Orders AS o ON o.ClientId = H.Id
	JOIN Vehicles AS v ON v.Id = o.VehicleId
	JOIN Models AS m ON m.Id = v.ModelId
GROUP BY H.Name, m.Class, H.Id
) AS H1
WHERE ranks = 1
ORDER BY Name, Class, H1.Id

/* ******************************************
	12.	Age Groups Revenue
*********************************************/

SELECT 
	CASE 
	WHEN YEAR(BirthDate) BETWEEN 1970 AND 1979 THEN '70''s'
	WHEN YEAR(BirthDate) BETWEEN 1980 AND 1989 THEN '80''s'
	WHEN YEAR(BirthDate) BETWEEN 1990 AND 1999 THEN '90''s'
	ELSE 'Others'
	END AS AgeGroup,
	SUM(ISNULL(o.Bill, 0)) AS [Revenue],
	AVG(o.TotalMileage) AS [AverageMileage]
FROM
(
SELECT c.Id, c.BirthDate
FROM Clients AS c
WHERE c.Id IN (SELECT ClientId FROM Orders)
) AS H
 JOIN Orders AS o ON o.ClientId = H.Id
 GROUP BY 
	CASE 
	WHEN YEAR(BirthDate) BETWEEN 1970 AND 1979 THEN '70''s'
	WHEN YEAR(BirthDate) BETWEEN 1980 AND 1989 THEN '80''s'
	WHEN YEAR(BirthDate) BETWEEN 1990 AND 1999 THEN '90''s'
	ELSE 'Others'
	END
ORDER BY AgeGroup

/* ******************************************
	13.	Consumption in Mind
*********************************************/

SELECT Manufacturer, AverageConsumption
FROM
(
SELECT TOP (7) Manufacturer, AVG(m.Consumption) AS [AverageConsumption]
FROM Orders AS o
	JOIN Vehicles AS v ON v.Id = o.VehicleId
	JOIN Models AS m ON m.Id = v.ModelId
GROUP BY Manufacturer, m.Model
--HAVING AVG(m.Consumption) BETWEEN 5 AND 15  --SAME RESULT WHEN ABOVE IS  'SELECT TOP(3) ...' -> PASS JUDGE
ORDER BY COUNT(m.Id) DESC
) AS H
WHERE AverageConsumption BETWEEN 5 AND 15
ORDER BY Manufacturer, AverageConsumption

/* ******************************************
	14.	Debt Hunter
*********************************************/

SELECT Names, Emails, Bills, TownNames
FROM
(
	SELECT ROW_NUMBER() OVER (PARTITION BY t.Name ORDER BY o.Bill DESC) AS orderByHighestBillDesc,
		   CONCAT(c.FirstName, ' ', c.LastName) AS [Names],
		   c.Email AS Emails, o.Bill AS Bills, t.Name AS [TownNames],
		   c.Id AS ClientId
	FROM Orders AS o
		JOIN Clients AS c ON c.Id = o.ClientId
		JOIN Towns AS t ON t.Id = o.TownId
	WHERE o.CollectionDate > c.CardValidity AND o.Bill IS NOT NULL
) AS H
WHERE orderByHighestBillDesc IN (1,2)
ORDER BY TownNames, Bills, ClientId 

/* ******************************************
	15.	Town Statistics
*********************************************/

WITH CTE_allOrdersPerTown AS
(
SELECT t.Name, COUNT(o.Id) AS ordersPerTown
FROM Orders AS o
	JOIN Towns AS t ON t.Id = o.TownId
GROUP BY t.Name
),

CTE_menOrders AS
(	
SELECT t.Name, COUNT(o.Id) AS ordersMenPerTown
FROM Orders AS o
	JOIN Towns AS t ON t.Id = o.TownId
	JOIN Clients AS c ON c.Id = o.ClientId
WHERE c.Gender = 'M'
GROUP BY t.Name
),

CTE_womenOrders AS
(
SELECT t.Name, COUNT(o.Id) AS ordersWomenPerTown
FROM Towns AS t
	JOIN Orders AS o ON o.TownId = t.Id
	JOIN Clients AS c ON c.Id = o.ClientId
WHERE c.Gender = 'F'
GROUP BY t.Name
)

SELECT ao.Name, CAST( (mo.ordersMenPerTown * 100.0 / ao.ordersPerTown) AS INT) AS MalePercent,
				CAST( (wo.ordersWomenPerTown * 100.0 / ao.ordersPerTown) AS INT) AS FemalePercent
FROM CTE_allOrdersPerTown AS ao
	LEFT JOIN CTE_menOrders AS mo ON mo.Name = ao.Name
	LEFT JOIN CTE_womenOrders AS wo ON wo.Name = ao.Name
GROUP BY ao.Name, ( mo.ordersMenPerTown * 100.0 / ao.ordersPerTown), ( wo.ordersWomenPerTown * 100.0 / ao.ordersPerTown)

-- SHORTER VERSION --

SELECT t.Name AS TownName,
	SUM(H.M) * 100 / (ISNULL(SUM(H.M), 0) + ISNULL(SUM(H.F), 0)) AS MalePercent,
	SUM(H.F) * 100/ (ISNULL(SUM(H.M), 0) + ISNULL(SUM(H.F), 0)) AS FemalePercent
FROM (
	SELECT o.TownId,
		CASE WHEN (Gender = 'M') THEN COUNT(o.Id) ELSE NULL END AS M,
		CASE WHEN (Gender = 'F') THEN COUNT(o.Id) ELSE NULL END AS F
	FROM Orders AS o
	JOIN Clients AS c ON c.Id = o.ClientId
	GROUP BY c.Gender, o.TownId
	) AS H
JOIN Towns AS t ON t.Id = H.TownId
GROUP BY t.Name
GO

/* ******************************************
	16.	Home Sweet Home
*********************************************/

WITH CTE_Ranks (ReturnOfficeId, OfficeId, Id, Manufacturer, Model)
AS
(
	SELECT RankedByDateDESC.ReturnOfficeId,
		   RankedByDateDESC.OfficeId,
		   RankedByDateDESC.Id,
		   RankedByDateDESC.Manufacturer,
		   RankedByDateDESC.Model
	FROM (
		SELECT DENSE_RANK() OVER (PARTITION BY v.Id ORDER BY o.CollectionDate DESC) AS LatestRentedCars,
			   o.ReturnOfficeId, v.OfficeId, v.Id, m.Manufacturer, m.Model
		FROM Orders AS o
			RIGHT JOIN Vehicles AS v ON v.Id = o.VehicleId
			JOIN Models AS m ON m.Id = v.ModelId
	) AS RankedByDateDESC
	WHERE LatestRentedCars = 1
)

SELECT CONCAT(Manufacturer, ' - ', Model) AS Vehicle,
	   Location =
		CASE
			WHEN (
				SELECT COUNT(*)
				FROM Orders AS o
				WHERE o.VehicleId = CTE_Ranks.Id
				) = 0 --TODO
				THEN 'home'
			WHEN (
				CTE_Ranks.ReturnOfficeId IS NULL
				)
				THEN 'on a rent'
			WHEN (
				CTE_Ranks.OfficeId <> CTE_Ranks.ReturnOfficeId
				)
				THEN (
					SELECT CONCAT(t.Name, ' - ', o.Name)
					FROM Towns AS t 
					JOIN Offices AS o ON o.TownId = t.Id
					WHERE o.Id = CTE_Ranks.ReturnOfficeId
					)
		END
FROM CTE_Ranks
ORDER BY Vehicle, CTE_Ranks.Id
GO

/* ******************************************
	Section 4. Programmability (14 pts)
*********************************************/

/* ******************************************
	17.	Find My Ride
*********************************************/

CREATE FUNCTION udf_CheckForVehicle(@townName NVARCHAR(50), @seatsNumber INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @result VARCHAR(100) = (
			SELECT TOP(1) CONCAT(ofc.Name, ' - ', m.Model)
			FROM Towns AS t
			JOIN Offices AS ofc ON ofc.TownId = t.Id
			JOIN Vehicles AS v ON v.OfficeId = ofc.Id
			JOIN Models AS m ON m.Id = v.ModelId
			WHERE t.Name = @townName AND m.Seats = @seatsNumber
			ORDER BY ofc.Name
	)

	IF (@result IS NULL)
	BEGIN
		RETURN 'NO SUCH VEHICLE FOUND'
	END

	RETURN @result
END
GO

/* ******************************************
	18.	Move a Vehicle
*********************************************/

CREATE PROCEDURE usp_MoveVehicle @vehicleId INT, @officeId INT
AS
BEGIN
	BEGIN TRANSACTION

	UPDATE Vehicles
	SET OfficeId = @officeId
	WHERE Id = @vehicleId

	DECLARE @countVehiclesById INT = (
		SELECT COUNT(v.Id) FROM Vehicles AS v WHERE v.OfficeId = @officeId
	)

	DECLARE @parkingPlaces INT = (
		SELECT ParkingPlaces FROM Offices AS o WHERE o.Id = @officeId
	)

	IF (@countVehiclesById > @parkingPlaces)
	BEGIN
		ROLLBACK
		RAISERROR('Not enough room in this office!', 16, 1)
		RETURN
	END

	COMMIT
END
GO

/* ******************************************
	19.	Move the Tally
*********************************************/

CREATE TRIGGER tr_MoveTheTally
ON Orders
FOR UPDATE
AS
BEGIN
	DECLARE @newTotalMileage INT = (
		SELECT TotalMileage FROM inserted
	)
	DECLARE @oldTotalMileage INT = (
		SELECT TotalMileage FROM deleted
	)
	DECLARE @vehicleId INT = (
		SELECT VehicleId FROM inserted
	)

	IF (@oldTotalMileage IS NULL AND @vehicleId IS NOT NULL)
	BEGIN
		UPDATE Vehicles
		SET Mileage += @newTotalMileage
		WHERE Id = @vehicleId
	END
END
GO



