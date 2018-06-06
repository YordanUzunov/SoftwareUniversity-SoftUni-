
/* ******************************************
	Resource queries for creating the databases necessary for the following exercises:
	https://github.com/YordanUzunov/SoftwareUniversity-SoftUni-/tree/master/Database%20Basics%20-%20MS%20SQL/Resource%20Databases
*********************************************/

USE SoftUni; 

/* ******************************************
	Problem 1.	Employee Address
*********************************************/

SELECT TOP (5) e.EmployeeID,
               e.JobTitle,
               a.AddressId,
               a.AddressText
FROM Employees AS e
     INNER JOIN Addresses AS a ON a.AddressID = e.AddressID
ORDER BY e.AddressID;

/* ******************************************
	Problem 2.	Addresses with Towns
*********************************************/

SELECT TOP (50) e.FirstName,
                e.LastName,
                t.Name as Town,
                a.AddressText
FROM Employees AS e
     INNER JOIN Addresses AS a ON a.AddressID = e.AddressID
     INNER JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY e.FirstName,
         e.LastName;

/* ******************************************
	Problem 3.	Sales Employee
*********************************************/

SELECT e.EmployeeID,
       e.FirstName,
       e.LastName,
       d.Name AS DepartmentName
FROM Employees AS e
     INNER JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID;

/* ******************************************
	Problem 4.	Employee Departments
*********************************************/

SELECT TOP (5) e.EmployeeID,
       e.FirstName,
       e.Salary,
       d.Name AS DepartmentName
FROM Employees AS e
     INNER JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID;

/* ******************************************
	Problem 5.	Employees Without Project
*********************************************/

SELECT TOP (3) e.EmployeeID,
               e.FirstName
FROM EmployeesProjects AS ep
     RIGHT OUTER JOIN Employees AS e ON e.EmployeeID = ep.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID;

/* /ALTERNATIVE SOLUTION/
SELECT TOP (3) EmployeeID,
               FirstName
FROM Employees
WHERE EmployeeID NOT IN
(
    SELECT DISTINCT
           EmployeeID
    FROM EmployeesProjects
)
ORDER BY EmployeeID;
*/

/* ******************************************
	Problem 6.	Employees Hired After
*********************************************/

SELECT e.FirstName,
       e.LastName,
       e.HireDate,
       d.Name AS DeptName
FROM Employees AS e
     INNER JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE e.HireDate > '1.1.1999'
      AND d.Name IN('Sales', 'Finance')
ORDER BY e.HireDate;

/* ******************************************
	Problem 7.	Employees with Project
*********************************************/

SELECT TOP (5) e.EmployeeID,
               e.FirstName,
               p.Name AS ProjectName
FROM Employees AS e
     INNER JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
     INNER JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.EndDate IS NULL
      AND p.StartDate >
(
    SELECT CONVERT(DATE, '13.08.2002', 103)
)
ORDER BY e.EmployeeID;

/* ******************************************
	Problem 8.	Employee 24
*********************************************/

SELECT e.EmployeeID,
       e.FirstName,
       CASE
           WHEN p.StartDate > '2005'
           THEN NULL
           ELSE p.Name
       END AS ProjectName
FROM Employees AS e
     INNER JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
     INNER JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24; 

/* ******************************************
	Problem 9.	Employee Manager
*********************************************/

SELECT e1.EmployeeID,
       e1.FirstName,
       e1.ManagerID,
       e.FirstName AS ManagerName
FROM Employees AS e
     INNER JOIN Employees AS e1 ON e1.ManagerID = e.EmployeeID
WHERE e1.ManagerID IN(3, 7)
ORDER BY e1.EmployeeID;

/* ******************************************
	Problem 10.	Employee Summary
*********************************************/

SELECT TOP (50) e.EmployeeID,
                e.FirstName+' '+e.LastName AS EmployeeName,
                m.FirstName+' '+m.LastName AS ManagerName,
                d.Name AS DepartmentName
FROM Employees AS e
     INNER JOIN Employees AS m ON e.ManagerID = m.EmployeeID
     INNER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID;

/* ******************************************
	Problem 11.	Min Average Salary
*********************************************/

SELECT MIN(AllDeptsAvgSalary.MinAverageSalary)
FROM
(
    SELECT AVG(Salary) AS MinAverageSalary
    FROM Employees
    GROUP BY DepartmentID
) AS AllDeptsAvgSalary;

/* ******************************************
	Problem 12.	Highest Peaks in Bulgaria
*********************************************/

USE Geography

SELECT ms.CountryCode,
       m.MountainRange,
       p.PeakName,
       p.Elevation
FROM MountainsCountries AS ms
     INNER JOIN Mountains AS m ON ms.MountainId = m.Id
     INNER JOIN Peaks AS p ON m.Id = p.MountainId
WHERE ms.CountryCode = 'BG'
      AND p.Elevation > 2835
ORDER BY p.Elevation DESC;

/* ******************************************
	Problem 13.	Count Mountain Ranges
*********************************************/

SELECT ms.CountryCode,
       COUNT(m.MountainRange) AS MountainRanges
FROM MountainsCountries AS ms
     INNER JOIN Mountains AS m ON ms.MountainId = m.Id
GROUP BY ms.CountryCode
HAVING ms.CountryCode IN('US', 'RU', 'BG');

/* ALTERNATIVE SOLUTION

SELECT c.CountryCode,
       COUNT(mc.MountainId) AS MountainRanges
FROM Countries AS c
     LEFT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
GROUP BY mc.CountryCode,
         c.CountryCode,
         CountryName
HAVING c.CountryName IN('United States', 'Russia', 'Bulgaria'); 
*/

/* ******************************************
	Problem 14.	Countries with Rivers
*********************************************/

SELECT TOP (5) c.CountryName,
               r.RiverName
FROM Countries AS c
     LEFT OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
     LEFT OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName;

/* ******************************************
	Problem 15.	*Continents and Currencies
*********************************************/

SELECT ranked.ContinentCode,
       ranked.CurrencyCode,
       ranked.CurrencyUsage
FROM
(
    SELECT gbc.ContinentCode,
           gbc.CurrencyCode,
           gbc.CurrencyUsage,
           DENSE_RANK() OVER(PARTITION BY gbc.ContinentCode ORDER BY gbc.CurrencyUsage DESC) AS UsageRank
    FROM
    (
        SELECT ContinentCode,
               CurrencyCode,
               COUNT(CurrencyCode) AS CurrencyUsage
        FROM Countries
        GROUP BY ContinentCode,
                 CurrencyCode
        HAVING COUNT(CurrencyCode) > 1
    ) AS gbc
) AS ranked
WHERE ranked.UsageRank = 1
ORDER BY ranked.ContinentCode; 

/* ******************************************
	Problem 16.	Countries without any Mountains
*********************************************/

SELECT COUNT(CountriesAndMountains.CountryCode) AS CountryCode
FROM
(
    SELECT ms.MountainId,
           c.CountryCode
    FROM MountainsCountries AS ms
         RIGHT OUTER JOIN Countries AS c ON ms.CountryCode = c.CountryCode
) AS CountriesAndMountains
WHERE CountriesAndMountains.MountainId IS NULL;

/* SHORTER ALTERNATIVE
SELECT COUNT(c.CountryCode) AS CountryCode
FROM Countries AS c
     LEFT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
WHERE mc.CountryCode IS NULL; 
*/

/* ******************************************
	Problem 17.	Highest Peak and Longest River by Country
*********************************************/

SELECT TOP (5) c.CountryName,
               MAX(p.Elevation) AS HighestPeakElevation,
               MAX(r.Length) AS LongestRiverLength
FROM Countries AS c
     LEFT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
     LEFT OUTER JOIN Mountains AS m ON mc.MountainId = m.Id
     LEFT OUTER JOIN Peaks AS p ON p.MountainId = m.Id
     LEFT OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
     LEFT OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC,
         MAX(r.Length) DESC;

/* ******************************************
	Problem 18.	* Highest Peak Name and Elevation by Country
*********************************************/

SELECT TOP (5) c.CountryName AS [Country],
               CASE
                   WHEN p.PeakName IS NULL
                   THEN '(no highest peak)'
                   ELSE p.PeakName
               END AS [Highest Peak Name],
               CASE
                   WHEN MAX(p.Elevation) IS NULL
                   THEN '0'
                   ELSE MAX(p.Elevation)
               END AS [Highest Peak Elevation],
               CASE
                   WHEN m.MountainRange IS NULL
                   THEN '(no mountain)'
                   ELSE m.MountainRange
               END AS [Mountain]
FROM Countries AS c
     LEFT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
     LEFT OUTER JOIN Mountains AS m ON mc.MountainId = m.Id
     LEFT OUTER JOIN Peaks AS p ON p.MountainId = m.Id
GROUP BY c.CountryName,
		 p.PeakName,
		 m.MountainRange
ORDER BY c.CountryName,
         p.PeakName; 

/* /ALTERNATIVE SOLUTION/ With ISNULL
SELECT TOP (5) sqt.CountryName AS [Country],
               ISNULL(sqt.PeakName, '(no highest peak)') AS [Highest Peak Name],
               ISNULL(sqt.Elevation, 0) AS [Highest Peak Elevation],
               ISNULL(sqt.MountainRange, '(no mountain)') AS [Mountain]
FROM
(
    SELECT c.CountryName,
           DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS PeakRank,
           p.PeakName,
           p.Elevation,
           m.MountainRange
    FROM Countries AS c
         LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
         LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
         LEFT JOIN Peaks AS p ON m.Id = p.MountainId
) AS sqt
WHERE sqt.PeakRank = 1
ORDER BY sqt.CountryName,
         sqt.PeakName;
*/