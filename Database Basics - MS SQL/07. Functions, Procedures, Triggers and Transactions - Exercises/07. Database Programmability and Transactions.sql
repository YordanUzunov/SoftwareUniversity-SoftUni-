/* ******************************************
	Resource queries for creating the databases necessary for the following exercises:
	https://github.com/YordanUzunov/SoftwareUniversity-SoftUni-/tree/master/Database%20Basics%20-%20MS%20SQL/Resource%20Databases
*********************************************/

/* *****************************************************
	Section I. Functions and Procedures
********************************************************/

/* *****************************************************
	Part I – Queries for SoftUni Database
********************************************************/

USE SoftUni;

/* *****************************************************
	Problem 1.	Employees with Salary Above 35000
********************************************************/

CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE Salary > 35000;
     END;

--TEST
EXEC usp_GetEmployeesSalaryAbove35000
GO

/* *****************************************************
	Problem 2.	Employees with Salary Above Number
********************************************************/

CREATE PROC usp_GetEmployeesSalaryAboveNumber(@salaryThreshold DECIMAL(18, 4))
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE Salary >= @salaryThreshold;
     END;

--TEST
EXEC usp_GetEmployeesSalaryAboveNumber 41800
GO

/* *****************************************************
	Problem 3.	Town Names Starting With
********************************************************/

CREATE PROC usp_GetTownsStartingWith(@townStartsWith NVARCHAR(50))
AS
     BEGIN
         SELECT [Name] AS [Town]
         FROM Towns
         WHERE [Name] LIKE(@townStartsWith+'%');
     END;

--TEST
EXEC usp_GetTownsStartingWith 'B'

/* *****************************************************
	Problem 4.	Employees from Town
********************************************************/

CREATE PROC usp_GetEmployeesFromTown(@townName NVARCHAR(50))
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees AS e
              LEFT OUTER JOIN Addresses AS a ON e.AddressID = a.AddressID
              LEFT OUTER JOIN Towns AS t ON a.TownID = t.TownID
         WHERE t.[Name] = @townName;
     END;

--TEST
EXEC usp_GetEmployeesFromTown 'Sofia'
GO

/* *****************************************************
	Problem 5.	Salary Level Function
********************************************************/

CREATE FUNCTION ufn_GetSalaryLevel
(@salary DECIMAL(18, 4)
)
RETURNS NVARCHAR(8)
AS
     BEGIN
         DECLARE @typeOfSalary NVARCHAR(8);
         IF @salary < 30000
             SET @typeOfSalary = 'Low';
             ELSE
         IF @salary BETWEEN 30000 AND 50000
             SET @typeOfSalary = 'Average';
             ELSE
         SET @typeOfSalary = 'High';

		 RETURN @typeOfSalary
     END;

--TEST
DECLARE @answer NVARCHAR(8)
SELECT @answer = dbo.ufn_GetSalaryLevel(43300.00)
SELECT @answer
GO

/* *****************************************************
	Problem 6.	Employees by Salary Level
********************************************************/

CREATE PROC usp_EmployeesBySalaryLevel(@levelOfSalary NVARCHAR(50))
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE @levelOfSalary = dbo.ufn_GetSalaryLevel(Salary);
     END;

--TEST
EXEC usp_EmployeesBySalaryLevel 'Average'
GO

/* *****************************************************
	Problem 7.	Define Function
********************************************************/

CREATE FUNCTION ufn_IsWordComprised
(@setOfLetters NVARCHAR(MAX),
 @word         NVARCHAR(MAX)
)
RETURNS BIT
AS
     BEGIN
         DECLARE @currentIndex INT= 1;
         WHILE(@currentIndex <= LEN(@word))
             BEGIN
                 DECLARE @currentLetter CHAR= SUBSTRING(@word, @currentIndex, 1);
                 IF(CHARINDEX(@currentLetter, @setOfLetters) <= 0)
                     BEGIN
                         RETURN 0;
                     END;
                 SET @currentIndex+=1;
             END;
         RETURN 1;
     END;

/* *****************************************************
	Problem 8. * Delete Employees and Departments
********************************************************/

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment
(
                 @departmentId INT
)
AS
     BEGIN
         ALTER TABLE Employees ALTER COLUMN ManagerID INT;

         ALTER TABLE Employees ALTER COLUMN DepartmentID INT;

         UPDATE Employees
           SET
               DepartmentID = NULL
         WHERE EmployeeID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         UPDATE Employees
           SET
               ManagerID = NULL
         WHERE ManagerID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         ALTER TABLE Departments ALTER COLUMN ManagerID INT;

         UPDATE Departments
           SET
               ManagerID = NULL
         WHERE DepartmentID = @departmentId;

         DELETE FROM Departments
         WHERE DepartmentID = @departmentId;

         DELETE FROM EmployeesProjects
         WHERE EmployeeID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         DELETE FROM Employees
         WHERE DepartmentID = @departmentId;

         SELECT COUNT(*)
         FROM Employees
         WHERE DepartmentID = @departmentId;
     END;
GO

/* *****************************************************
	PART II – Queries for Bank Database
********************************************************/

USE BANK;
GO 

/* *****************************************************
	Problem 9.	Find Full Name
********************************************************/

CREATE PROC usp_GetHoldersFullName
AS
     BEGIN
         SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
         FROM AccountHolders;
     END;

--TEST
EXEC usp_GetHoldersFullName
GO

/* *****************************************************
	Problem 10.	People with Balance Higher Than
********************************************************/

SELECT * FROM Accounts
SELECT * FROM AccountHolders

CREATE PROC usp_GetHoldersWithBalanceHigherThan(@moreThanThisSum DECIMAL(18, 2))
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM AccountHolders AS ah
              INNER JOIN Accounts AS a ON ah.Id = a.AccountHolderId
         GROUP BY ah.FirstName,
                  ah.LastName
         HAVING SUM(a.Balance) > @moreThanThisSum;
     END;

--TEST
EXEC usp_GetHoldersWithBalanceHigherThan 33333.33
GO

/* *****************************************************
	Problem 11.	Future Value Function
********************************************************/

CREATE FUNCTION ufn_CalculateFutureValue
(@initialSum         MONEY,
 @yearlyInterestRate FLOAT,
 @numberOfYears      INT
)
RETURNS MONEY
AS
     BEGIN
         RETURN @initialSum * (POWER(1 + @yearlyInterestRate, @numberOfYears));
     END;

--TEST
DECLARE @answer MONEY
SELECT @answer = dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
SELECT @answer
GO

/* *****************************************************
	Problem 12.	Calculating Interest
********************************************************/

CREATE PROCEDURE usp_CalculateFutureValueForAccount
(@accountID    INT,
 @interestRate FLOAT
)
AS
     BEGIN
         SELECT a.Id AS [Account Id],
                ah.FirstName AS [First Name],
                ah.LastName AS [Last Name],
                a.Balance AS [Current Balance],
                dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5)
         FROM Accounts AS a
              JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
         WHERE a.Id = @accountID;
     END;

--TEST
EXEC usp_CalculateFutureValueForAccount 1, 0.1
GO

/* *****************************************************
	PART III – Queries for Diablo Database
********************************************************/

USE Diablo;
GO

/* *****************************************************
	Problem 13.	*Scalar Function: Cash in User Games Odd Rows
********************************************************/

CREATE FUNCTION ufn_CashInUsersGames(@gameName NVARCHAR(50)) RETURNS TABLE AS RETURN
(
    SELECT SUM(ocbg.Cash) AS SumCash
    FROM
(
    SELECT g.[Name],
           ug.Cash,
           ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS RowN
    FROM Games AS g
         JOIN UsersGames AS ug ON ug.GameId = g.Id
    WHERE [Name] = @gameName
) AS ocbg
    WHERE ocbg.RowN % 2 <> 0
);
GO

--TEST
SELECT * FROM ufn_CashInUsersGames('Lily Stargazer')
GO

/* *****************************************************
	Section II. Triggers and Transactions
********************************************************/

/* *****************************************************
	Part I. Queries for Bank Database
********************************************************/

USE Bank
GO

/* *****************************************************
	Problem 14. Create Table Logs
********************************************************/

CREATE TABLE Logs
(LogId     INT
 PRIMARY KEY IDENTITY,
 AccountID INT FOREIGN KEY REFERENCES Accounts(Id),
 OldSum    DECIMAL(18, 2) NOT NULL,
 NewSum    DECIMAL(18, 2) NOT NULL
);
GO

CREATE TRIGGER tr_Logs_Accounts_After_Update ON Accounts
FOR UPDATE
AS
     BEGIN
         INSERT INTO Logs
         VALUES
(
(
    SELECT Id
    FROM deleted
),
(
    SELECT Balance
    FROM deleted
),
(
    SELECT Balance
    FROM inserted
)
);
     END;
	 GO

/* *****************************************************
	Problem 15. Create Table Emails
********************************************************/

CREATE TABLE NotificationEmails
(Id        INT
 PRIMARY KEY IDENTITY,
 Recipient INT NOT NULL,
 Subject   NVARCHAR(50) NOT NULL,
 Body      NVARCHAR(255) NOT NULL,
);
GO

CREATE TRIGGER tr_NotificationEmails_Logs ON Logs
FOR INSERT
AS
     BEGIN
         INSERT INTO NotificationEmails
         VALUES
(
(
    SELECT AccountId
    FROM inserted
),
CONCAT('Balance change for account: ',
(
    SELECT AccountId
    FROM inserted
)),
CONCAT('On ', FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), ' your balance was changed from ',
(
    SELECT OldSum
    FROM Logs
), ' to ',
(
    SELECT NewSum
    FROM Logs
), '.')
);
     END;
	 GO

/* *****************************************************
	Problem 16. Deposit Money
********************************************************/

CREATE PROCEDURE usp_DepositMoney
(@AccountId   INT,
 @MoneyAmount DECIMAL(18, 4)
)
AS
     BEGIN
         IF(@MoneyAmount > 0)
             BEGIN
                 UPDATE Accounts
                   SET
                       Balance+=@MoneyAmount
                 WHERE Id = @AccountId;
             END;
     END;
GO

/* *****************************************************
	Problem 17. Withdraw Money
********************************************************/

CREATE PROCEDURE usp_WithdrawMoney
(@AccountId   INT,
 @MoneyAmount DECIMAL(18, 4)
)
AS
     BEGIN
         IF(@MoneyAmount > 0)
             BEGIN
                 UPDATE Accounts
                   SET
                       Balance-=@MoneyAmount
                 WHERE Id = @AccountId;
             END;
     END;
GO

/* *****************************************************
	Problem 18. Money Transfer
********************************************************/

CREATE PROCEDURE usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(18,4)) AS
BEGIN TRANSACTION
				EXEC dbo.usp_WithdrawMoney @SenderId, @Amount
				EXEC usp_DepositMoney @ReceiverId, @Amount
				DECLARE @senderBalance DECIMAL(18,4) = (SELECT Balance FROM Accounts WHERE Id = @SenderId)
				IF @senderBalance < 0
				BEGIN
					ROLLBACK
					RETURN
				END
COMMIT TRANSACTION
GO
/* *****************************************************
	Part II. Queries for Diablo Database
********************************************************/

USE Diablo
GO

/* *****************************************************
	Problem 19. Trigger
********************************************************/

/* Trigger for validating user's level when buying items */
CREATE TRIGGER tr_UserGameItems_LevelRestriction ON UserGameItems
INSTEAD OF UPDATE
AS
     BEGIN
         IF(
           (
               SELECT Level
               FROM UsersGames
               WHERE Id =
               (
                   SELECT UserGameId
                   FROM inserted
               )
           ) <
           (
               SELECT MinLevel
               FROM Items
               WHERE Id =
               (
                   SELECT ItemId
                   FROM inserted
               )
           ))
             BEGIN
                 RAISERROR('Your current level is not enough', 16, 1);
         END;

/* Assign the new item when the exception isn't thrown */
		INSERT INTO UserGameItems
         VALUES
         (
         (
             SELECT ItemId
             FROM inserted
         ),
         (
             SELECT UserGameId
             FROM inserted
         )
         );
     END;

 /* Add bonus cash */
UPDATE ug
  SET
      ug.Cash+=50000
FROM UsersGames AS ug
     JOIN Users AS u ON u.Id = ug.UserId
     JOIN Games AS g ON g.Id = ug.GameId
WHERE u.FirstName IN('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
AND g.Name = 'Bali';

/* *****************************************************
	Problem 20. *Massive Shopping
********************************************************/

DECLARE @userId INT = (SELECT Id FROM Users WHERE Username = 'Stamat')
DECLARE @gameId INT = (SELECT Id FROM Games WHERE [Name] = 'Safflower')
DECLARE @userGameId INT = (SELECT Id FROM UsersGames WHERE UserId = @userId AND GameId = @gameId)

BEGIN TRY
BEGIN TRANSACTION
	UPDATE UsersGames
	SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel IN (11, 12))
	WHERE Id = @userGameId
	DECLARE @userBalance DECIMAL(15,4) = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
	IF @userBalance < 0
	BEGIN
	ROLLBACK
	RETURN
	END
	INSERT INTO UserGameItems
	SELECT Id, @userGameId FROM Items WHERE MinLevel IN (11, 12)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

BEGIN TRY
BEGIN TRANSACTION
	UPDATE UsersGames
	SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN 19 AND 21)
	WHERE Id = @userGameId
	SET @userBalance = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
	IF @userBalance < 0
	BEGIN
	ROLLBACK
	RETURN
	END
	INSERT INTO UserGameItems
	SELECT Id, @userGameId FROM Items WHERE MinLevel BETWEEN 19 AND 21
COMMIT
END TRY
BEGIN CATCH
ROLLBACK
END CATCH

SELECT i.[Name] AS [Item Name]
FROM Items AS i
JOIN UserGameItems AS u ON i.Id = u.ItemId
WHERE u.UserGameId = @userGameId
ORDER BY [Item Name]
GO
/* *****************************************************
	Part III. Queries for SoftUni Database
********************************************************/

USE SoftUni
GO

/* *****************************************************
	Problem 21. Employees with Three Projects
********************************************************/

CREATE PROCEDURE usp_AssignProject (@EmployeeId INT, @ProjectId INT) AS
BEGIN
BEGIN TRANSACTION
	INSERT INTO EmployeesProjects (EmployeeId, ProjectId) VALUES
	(@EmployeeId, @ProjectId)
	DECLARE @projectCount INT = (SELECT COUNT(*) FROM EmployeesProjects WHERE EmployeeID = @EmployeeId)
	IF @projectCount > 3
	BEGIN
		ROLLBACK
		RAISERROR('The employee has too many projects!', 16, 1)
		RETURN
	END
	COMMIT
END
GO

--TEST
SELECT * FROM EmployeesProjects
ORDER BY EmployeeID

EXEC usp_AssignProject 1,5
GO

/* *****************************************************
	Problem 22. Delete Employees
********************************************************/

CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(10),
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentID),
	Salary DECIMAL(15,4)
)
GO

CREATE TRIGGER t_FireEmployee ON Employees AFTER DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary
	FROM deleted
END

--TEST
INSERT INTO Employees (FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID)
SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID FROM Employees
WHERE EmployeeID = 1

SELECT * FROM Employees

DELETE FROM Employees
WHERE EmployeeID = 294

SELECT * FROM Deleted_Employees
GO