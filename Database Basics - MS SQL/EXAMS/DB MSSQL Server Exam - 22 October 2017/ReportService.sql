/* ******************************************
	Database Basics MS SQL Exam – 22 Oct 2017
*********************************************/

CREATE DATABASE ReportService
GO

USE ReportService

/* ******************************************
	Section 1. DDL (30 pts)
*********************************************/

/* ******************************************
	1.	Database design
*********************************************/

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(30) UNIQUE NOT NULL,
	Password NVARCHAR(50) NOT NULL,
	Name NVARCHAR(50),
	Gender CHAR(1) CHECK (Gender IN('M', 'F')),
	BirthDate DATETIME,
	Age INT,
	Email NVARCHAR(50) NOT NULL
)

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(25),
	LastName NVARCHAR(25),
	Gender CHAR(1) CHECK (Gender IN('M', 'F')),
	BirthDate DATETIME,
	Age INT,
	DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Status
(
	Id INT PRIMARY KEY IDENTITY,
	Label NVARCHAR(30) NOT NULL
)

CREATE TABLE Reports
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	StatusId INT NOT NULL FOREIGN KEY REFERENCES Status(Id),
	OpenDate DATETIME NOT NULL,
	CloseDate DATETIME,
	Description NVARCHAR(200),
	UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id)
)

/* ******************************************
	Section 2. DML (10 pts)
*********************************************/

/* ******************************************
	2.	Insert
*********************************************/

INSERT INTO Employees (FirstName, LastName, Gender, BirthDate, DepartmentId) VALUES
('Marlo', 'O’Malley', 'M', '9/21/1958',	1),
('Niki', 'Stanaghan', 'F', '11/26/1969', 4),
('Ayrton', 'Senna', 'M', '03/21/1960', 9),
('Ronnie', 'Peterson', 'M', '02/14/1944', 9),
('Giovanna', 'Amati', 'F', '07/20/1959', 5)

INSERT INTO Reports (CategoryId, StatusId, OpenDate, CloseDate, Description, UserId, EmployeeId) VALUES
(1, 1, '04/13/2017', NULL,	'Stuck Road on Str.133', 6, 2),
(6, 3, '09/05/2015', '12/06/2015', 'Charity trail running', 3, 5),
(14, 2, '09/07/2015', NULL, 'Falling bricks on Str.58', 5, 2),
(4, 3, '07/03/2017', '07/06/2017', 'Cut off streetlight on Str.11', 1, 1)

/* ******************************************
	3.	Update
*********************************************/

UPDATE Reports
SET StatusId = 2
WHERE StatusId = 1 AND CategoryId = 4

/* ******************************************
	4.	Delete
*********************************************/

DELETE FROM Reports
WHERE StatusId = 4

/* ******************************************
	Section 3. Querying (40 pts)
*********************************************/

/* ******************************************
	5.	Users by Age
*********************************************/

SELECT Username, Age
FROM Users
ORDER BY Age, Username DESC

/* ******************************************
	6.	Unassigned Reports
*********************************************/

SELECT Description, OpenDate 
FROM Reports
WHERE EmployeeId IS NULL
ORDER BY OpenDate, Description

/* ******************************************
	7.	Employees & Reports
*********************************************/

SELECT e.FirstName, e.LastName, r.Description, FORMAT(r.OpenDate, 'yyyy-MM-dd') AS OpenDate
FROM Employees AS e
	JOIN Reports AS r ON r.EmployeeId = e.Id
WHERE r.EmployeeId IS NOT NULL
ORDER BY e.Id, r.OpenDate, r.Id

/* ******************************************
	8.	Most reported Category
*********************************************/

SELECT c.Name AS CategoryName, COUNT(r.Id) AS ReportsNumber
FROM Categories AS c
	JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY c.Name
ORDER BY ReportsNumber DESC, CategoryName

/* ******************************************
	9.	Employees in Category
*********************************************/

SELECT c.Name AS CategoryName, COUNT(e.Id) AS [Employees Number]
FROM Categories AS c
	JOIN Departments AS d ON d.Id = c.DepartmentId
	JOIN Employees AS e ON e.DepartmentId = d.Id
GROUP BY c.Name
ORDER BY CategoryName

/* ******************************************
	10.	Users per Employee 
*********************************************/

SELECT Name, SUM(UN) AS [Users Number] FROM
(
	SELECT e.Id, CONCAT(e.FirstName, ' ', e.LastName) AS Name, COUNT(r.UserId) AS UN 
	FROM Employees AS e
	LEFT JOIN Reports AS r ON e.Id = r.EmployeeId
	GROUP BY e.Id, e.FirstName, e.LastName, r.UserId
) AS t
GROUP BY Id, Name
ORDER BY [Users Number] DESC, Name

/* ******************************************
	11.	Emergency Patrol 
*********************************************/

SELECT r.OpenDate, r.Description, u.Email AS [Reporter Email]
FROM Reports AS r
	JOIN Users AS u ON u.Id = r.UserId
	JOIN Categories AS c ON c.Id = r.CategoryId
WHERE r.CloseDate IS NULL AND 
	  LEN(r.Description) > 20 AND
	  r.Description LIKE ('%str%') AND
	  c.DepartmentId IN (1, 4, 5)
ORDER BY r.OpenDate, [Reporter Email], u.Id

/* ******************************************
	12.	Birthday Report
*********************************************/

SELECT DISTINCT c.Name AS [Category Name] 
FROM Reports AS r
	JOIN Categories AS c ON c.Id = r.CategoryId
	JOIN Users AS u ON u.Id = r.UserId
WHERE DAY(r.OpenDate) = DAY(u.BirthDate) AND
	  MONTH(r.OpenDate) = MONTH(u.BirthDate)
ORDER BY [Category Name] 

/* ******************************************
	13.	Numbers Coincidence
*********************************************/

SELECT DISTINCT u.Username 
FROM Reports AS r
	JOIN Categories AS c ON c.Id = r.CategoryId
	JOIN Users AS u ON u.Id = r.UserId
WHERE LEFT(u.Username, 1) LIKE '[0-9]'
	  AND CONVERT(VARCHAR(10), c.Id) = LEFT(u.Username, 1) OR
	  RIGHT(u.Username, 1) LIKE '[0-9]' 
	  AND CONVERT(VARCHAR(10), c.Id) = RIGHT(u.Username, 1)
ORDER BY u.Username 
	GO
/* ******************************************
	14.	Open/Closed Statistics
*********************************************/

WITH CTE_OpenedRepots(EmployeeId, Count) AS
(
	SELECT e.Id, COUNT(r.Id) FROM Employees AS e
	JOIN Reports AS r ON e.Id = r.EmployeeId
	WHERE DATEPART(YEAR, r.OpenDate) = 2016
	GROUP BY e.Id
),

CTE_ClosedRepots(EmployeeId, Count) AS
(
	SELECT e.Id, COUNT(r.Id) FROM Employees AS e
	JOIN Reports AS r ON e.Id = r.EmployeeId
	WHERE DATEPART(YEAR, r.CloseDate) = 2016
	GROUP BY e.Id
)

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS Name, CONCAT(ISNULL(c.Count, 0), '/', ISNULL(o.Count, 0)) AS [Closed Open Reports] 
FROM  CTE_ClosedRepots AS c 
FULL JOIN CTE_OpenedRepots AS o ON c.EmployeeId = o.EmployeeId
JOIN Employees AS e ON c.EmployeeId = e.Id OR o.EmployeeId = e.Id
ORDER BY Name, e.Id

/* ******************************************
	15.	Average Closing Time
*********************************************/

SELECT d.Name AS [Department Name], 
	   ISNULL(CONVERT(VARCHAR(10), AVG(DATEDIFF(DAY, r.OpenDate, r.CloseDate))), 'no info') AS [Average Duration]
FROM Departments AS d
	JOIN Categories AS c ON c.DepartmentId = d.Id
	JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY d.Name
GO

/* ******************************************
	16.	Favorite Categories
*********************************************/

WITH CTE_ReportsCount(deptName, categName, rCount) AS
(
SELECT 
		d.Name AS deptName, 
		c.Name AS categName,
		COUNT(*) AS repCount
FROM Departments AS d
	JOIN Categories AS c ON c.DepartmentId = d.Id
	JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY d.Name, c.Name
),

CTE_ReportTotals(deptName, rCount) AS
(
SELECT crc.deptName, SUM(crc.rCount) AS rrr
FROM CTE_ReportsCount AS crc
GROUP BY crc.deptName
)

SELECT crc.deptName [Department Name], 
	   crc.categName [Category Name],
	   CONVERT(INT, ROUND((crc.rCount * 100.0 / crt.rCount), 0)) AS [Percentage] 	   
FROM CTE_ReportsCount AS crc
	JOIN CTE_ReportTotals AS crt ON crt.deptName = crc.deptName
GROUP BY crc.deptName, crc.categName, CONVERT(INT, ROUND((crc.rCount * 100.0 / crt.rCount), 0))
ORDER BY [Department Name], [Category Name], [Percentage]
GO

/* ******************************************
	17. Employee's Load 
*********************************************/

CREATE FUNCTION udf_GetReportsCount(@employeeId INT, @statusId INT)
RETURNS INT
AS
BEGIN
	RETURN
		(SELECT ISNULL(COUNT(*), 0)
		FROM Reports WHERE EmployeeId = @employeeId AND StatusId = @statusId)
END
GO

/* ******************************************
	18.	Assign Employee
*********************************************/

CREATE PROCEDURE usp_AssignEmployeeToReport(@employeeId INT, @reportId INT) AS
BEGIN 
	DECLARE @empDeptartment  INT = (SELECT e.DepartmentId FROM Employees AS e WHERE e.Id = @employeeId)
	DECLARE @repDepartment INT = (SELECT c.DepartmentId FROM Categories AS c 
								    JOIN Reports AS r ON c.Id = r.CategoryId
									WHERE r.Id = @reportId)
	
	IF(@empDeptartment <> @repDepartment)
	BEGIN
		RAISERROR('Employee doesn''t belong to the appropriate department!', 16, 1)
		RETURN
	END

	UPDATE Reports
		SET EmployeeId = @employeeId
		WHERE Id = @reportId
END
GO
 
 /* ******************************************
	19.	Close Reports
*********************************************/

CREATE TRIGGER tr_CloseReport ON Reports AFTER UPDATE AS
BEGIN
	UPDATE Reports
	SET StatusId = 3
	FROM deleted AS d
	JOIN inserted AS i ON d.Id = i.Id
	WHERE i.CloseDate IS NOT NULL
END

 /* ******************************************
	Section 5. Bonus (10 pts)
*********************************************/

/* ******************************************
	20.	Categories Revision
*********************************************/

SELECT c.Name , COUNT(r.Id) AS [Reports Number],
		CASE
			WHEN SUM( CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END) >
			SUM( CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) THEN 'in progress'
			WHEN SUM( CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END) <
			SUM( CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) THEN 'waiting'
			ELSE 'equal'
		END AS [Main Status]
FROM Reports AS r
	JOIN Categories AS c ON c.Id = r.CategoryId
WHERE r.StatusId IN (1,2)
GROUP BY c.Name
ORDER BY c.Name, [Reports Number], [Main Status]



SELECT * FROM Reports
SELECT * FROM Status
SELECT * FROM Categories
SELECT * FROM Employees
SELECT * FROM Users
SELECT * FROM Departments