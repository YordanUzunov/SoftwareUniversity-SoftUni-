/* ******************************************
	Resource queries for creating the databases necessary for the following exercises:
	https://github.com/YordanUzunov/SoftwareUniversity-SoftUni-/tree/master/Database%20Basics%20-%20MS%20SQL/Resource%20Databases
*********************************************/

/* ******************************************
	Part I – Queries for SoftUni Database
*********************************************/

USE SoftUni

/* ******************************************
	Problem 1.	Find Names of All Employees by First Name
*********************************************/

SELECT FirstName, LastName
  FROM Employees
  WHERE LEFT(FirstName, 2) = 'SA'
--WHERE FirstName LIKE 'SA%';

/* ******************************************
	Problem 2.	  Find Names of All employees by Last Name 
*********************************************/

SELECT FirstName, LastName
  FROM Employees
  WHERE LastName LIKE '%ei%'

/* ******************************************
	Problem 3.	Find First Names of All Employees
*********************************************/

SELECT FirstName
  FROM Employees
  WHERE DepartmentID IN (3, 10) AND
		DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005

/* ******************************************
	Problem 4.	Find All Employees Except Engineers
*********************************************/

SELECT FirstName, LastName
  FROM Employees
  WHERE JobTitle NOT LIKE '%engineer%'

/* ******************************************
	Problem 5.	Find Towns with Name Length
*********************************************/

SELECT [Name]
  FROM Towns
  WHERE LEN([Name]) IN (5, 6)
  ORDER BY [Name]

/* ******************************************
	Problem 6.	 Find Towns Starting With
*********************************************/

SELECT TownID, [Name]
  FROM Towns
--WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E') 
  WHERE LEFT([Name], 1) LIKE '[MKBE]'  
  ORDER BY [Name]

/* ******************************************
	Problem 7.	 Find Towns Not Starting With
*********************************************/

SELECT TownID, [Name]
  FROM Towns
  WHERE NOT LEFT([Name], 1) IN ('R', 'B', 'D') 
--WHERE LEFT([Name], 1) NOT LIKE '[RBD]'  
  ORDER BY [Name]

/* ******************************************
	Problem 8.	Create View Employees Hired After 2000 Year
*********************************************/

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
  FROM Employees
  WHERE DATEPART(YEAR, HireDate) > 2000

/* ******************************************
	Problem 9.	Length of Last Name
*********************************************/

SELECT FirstName, LastName
  FROM Employees
  WHERE LEN(LastName) = 5

/* ******************************************
	Part II – Queries for Geography Database 
*********************************************/

USE Geography

/* ******************************************
	Problem 10.	Countries Holding ‘A’ 3 or More Times
*********************************************/

SELECT CountryName AS 'Country Name', IsoCode AS 'Iso Code'
  FROM Countries
  WHERE CountryName LIKE '%a%a%a%'
  ORDER BY IsoCode

/* ******************************************
	Problem 11.	 Mix of Peak and River Names
*********************************************/

SELECT Peaks.PeakName,
       Rivers.RiverName,
       LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName)-1), Rivers.RiverName)) AS Mix
  FROM Peaks
     JOIN Rivers ON RIGHT(Peaks.PeakName, 1) = LEFT(Rivers.RiverName, 1)
  ORDER BY Mix

/* /SAME RESULT\--------
SELECT Peaks.PeakName,
       Rivers.RiverName,
       LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName)-1), Rivers.RiverName)) AS Mix
  FROM Peaks,
       Rivers
  WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
  ORDER BY Mix
*/

/* ******************************************
	Part III – Queries for Diablo Database
*********************************************/

USE Diablo 

/* ******************************************
	Problem 12.	Games from 2011 and 2012 year
*********************************************/

SELECT TOP (50) [Name], 
				FORMAT(CAST([Start] AS DATE), 'yyyy-MM-dd') AS [Start]
  FROM Games
  WHERE DATEPART(YEAR, [Start]) IN (2011, 2012)
  ORDER BY [Start],
		   [Name]

/* ******************************************
	Problem 13.	 User Email Providers
*********************************************/

SELECT Username,
       RIGHT(Email, LEN(Email)-CHARINDEX('@', Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider],
         Username

/* /SAME RESULT\--------
SELECT Username,
	   SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email) - CHARINDEX('@', Email) + 1) AS [Email Provider]
  FROM Users
  ORDER BY [Email Provider],
		   Username
*/

/* ******************************************
	Problem 14.	 Get Users with IPAdress Like Pattern
*********************************************/

SELECT Username, IpAddress AS [IP Address]
  FROM Users
  WHERE IpAddress LIKE '___.1_%._%.___'
  ORDER BY Username

/* ******************************************
	Problem 15.	 Show All Games with Duration and Part of the Day
*********************************************/

SELECT [Name] AS [Game],
	   CASE
           WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11
           THEN 'Morning'
           WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17
           THEN 'Afternoon'
           WHEN DATEPART(HOUR, [Start]) BETWEEN 18 AND 23
           THEN 'Evening'
           ELSE 'N\A'
       END AS [Part of the Day],
	   CASE
           WHEN Duration <= 3
           THEN 'Extra Short'
           WHEN Duration BETWEEN 4 AND 6
           THEN 'Short'
           WHEN Duration > 6
           THEN 'Long'
           WHEN Duration IS NULL
           THEN 'Extra Long'
           ELSE 'N\A'
       END AS [Duration]
  FROM Games
  ORDER BY Name,
         [Duration],
         [Part of the Day]

/* ******************************************
	Part IV – Date Functions Queries
*********************************************/

USE Orders

/* ******************************************
	Problem 16.	 Orders Table
*********************************************/

SELECT ProductName,
       OrderDate,
       DATEADD(DAY, 3, OrderDate) AS [Pay Due],
       DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
  FROM Orders

/* ******************************************
	Problem 17.	 People Table
*********************************************/

CREATE TABLE People
(
             Id        INT
             PRIMARY KEY IDENTITY,
             Name      NVARCHAR(50) NOT NULL,
             Birthdate DATETIME2 NOT NULL
);

INSERT INTO People
VALUES
( 'Victor', '2000-12-07 00:00:00.000'),
( 'Steven', '1992-09-10 00:00:00.000'),
( 'Stephen', '1910-09-19 00:00:00.000'),
( 'John', '2010-01-06 00:00:00.000')

SELECT Name,
       DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
       DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
       DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
       DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
FROM People

DROP TABLE People