/* ******************************************
	Problem 1. Create Database
*********************************************/

CREATE DATABASE Minions
GO

USE Minions

/* ******************************************
	Problem 2. Create Tables
*********************************************/

CREATE TABLE Minions (
	Id INT PRIMARY KEY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	Age INT
	)

CREATE TABLE Towns (
	Id INT PRIMARY KEY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	)

/* ******************************************
	Problem 3. Alter Minions Table
*********************************************/

ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL

--/ALTERNATIVE INPUT\:
--ALTER TABLE Minions
--ADD TownId INT NOT NULL;

--ALTER TABLE Minions
--ADD CONSTRAINT FK_TownId FOREIGN KEY(TownId) REFERENCES Towns(Id);

/* ******************************************
	Problem 4. Insert Records in Both Tables
*********************************************/

INSERT INTO Towns (Id, Name) VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO Minions (Id, Name, Age, TownId) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

/* ******************************************
	Problem 5. Truncate Table Minions
*********************************************/

TRUNCATE TABLE Minions

/* ******************************************
	Problem 6. Drop All Tables
*********************************************/

DROP TABLE Minions

DROP TABLE Towns

/* ******************************************
	Problem 7. Create Table People
*********************************************/

CREATE TABLE People (
	Id INT UNIQUE IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height NUMERIC(3, 2),
	Wight NUMERIC(5, 2),
	Gender CHAR(1) CHECK([Gender] IN('m', 'f')) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
	)

ALTER TABLE People
ADD PRIMARY KEY(Id)

ALTER TABLE People
ADD CONSTRAINT CH_PictureSize CHECK(DATALENGTH(Picture) <= 2 * 1024 * 1024)

INSERT INTO People ([Name], Gender, Birthdate) VALUES
('First Person', 'f', '01-02-1999'),
('Second Person', 'm', '03-04-2000'),
('Third Person', 'f', '05-06-2001'),
('Fourth Person', 'm', '07-08-2003'),
('Fifth Person', 'f', '09-10-2010')

/* ******************************************
	Problem 8. Create Table Users
*********************************************/

CREATE TABLE Users (
	Id BIGINT UNIQUE IDENTITY NOT NULL,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) UNIQUE NOT NULL,
	ProfilePicture VARBINARY(MAX),
	LastLoginTime DATETIME2,
	IsDeleted BIT NOT NULL DEFAULT(0)
	)

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT CH_ProfilePicture CHECK(DATALENGTH(ProfilePicture) <= 900 * 1024)

INSERT INTO Users(Username, [Password]) VALUES
('First', 'pass1'),
('Second', 'pass2'),
('Third', 'pass3'),
('Fourth', 'pass4'),
('Fifth', 'pass5')

/* ******************************************
	Problem 9. Change Primary Key
*********************************************/

ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id, Username)

/* ******************************************
	Problem 10. Add Check Constraint
*********************************************/

ALTER TABLE Users
ADD CONSTRAINT PasswordLength
CHECK(LEN(Password) >= 5)

/* ******************************************
	Problem 11. Set Default Value of a Field
*********************************************/

ALTER TABLE Users
ADD CONSTRAINT DF_Users DEFAULT GETDATE() FOR LastLoginTime

/* ******************************************
	Problem 12. Set Unique Field
*********************************************/

ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Person PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT UC_Username UNIQUE(Username)

ALTER TABLE Users
ADD CONSTRAINT CH_Username CHECK(LEN(Password) >= 3)

/* ******************************************
	Problem 13. Movies Database
*********************************************/

CREATE DATABASE Movies
GO

USE Movies

CREATE TABLE Directors (
	Id INT PRIMARY KEY NOT NULL,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Genres (
	Id INT PRIMARY KEY NOT NULL,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Categories (
	Id INT PRIMARY KEY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

CREATE TABLE Movies (
	Id INT PRIMARY KEY NOT NULL,
	Title NVARCHAR(255) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear INT,
	[Length] NVARCHAR(50),
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating INT,
	NOTES NVARCHAR(MAX)
	)

INSERT INTO Directors (Id, DirectorName) VALUES
(1, 'Director One'),
(2, 'Director Two'),
(3, 'Director Three'),
(4, 'Director Four'),
(5, 'Director Five')

INSERT INTO Genres (Id, GenreName) VALUES
(1, 'Genre One'),
(2, 'Genre Two'),
(3, 'Genre Three'),
(4, 'Genre Four'),
(5, 'Genre Five')

INSERT INTO Categories (Id, CategoryName) VALUES
(1, 'Category One'),
(2, 'Category Two'),
(3, 'Category Three'),
(4, 'Category Four'),
(5, 'Category Five')

INSERT INTO Movies (Id, Title, DirectorId, GenreId, CategoryId) VALUES
(1, 'Title One', 2, 3, 4),
(2, 'Title One', 3, 4, 5),
(3, 'Title One', 4, 5, 1),
(4, 'Title One', 5, 1, 2),
(5, 'Title One', 1, 2, 3)

/* ******************************************
	Problem 14. Car Rental Database
*********************************************/

CREATE DATABASE CarRental
GO

USE CarRental

CREATE TABLE Categories (
	Id INT PRIMARY KEY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate DECIMAL(15, 2),
	WeeklyRate DECIMAL(15, 2),
	MonthlyRate DECIMAL(15, 2),
	WeekendRate DECIMAL(15, 2)
	)

ALTER TABLE Categories
ADD CONSTRAINT CK_AtLeastOneRate CHECK((DailyRate IS NOT NULL)
                                       OR (WeeklyRate IS NOT NULL)
                                       OR (MonthlyRate IS NOT NULL)
                                       OR (WeekendRate IS NOT NULL));

INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
(1, 'First Category', 20, 100, 400, 30),
(2, 'Second Category', 30, 150, 500, 40),
(3, 'Third Category', 40, 200, 600, 60)

CREATE TABLE Cars (
	Id INT PRIMARY KEY NOT NULL,
	PlateNumber VARCHAR(50) NOT NULL,
	Manufacturer VARCHAR(50) NOT NULL,
	Model VARCHAR(50) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Doors TINYINT NOT NULL,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(50),
	Available BIT DEFAULT 1
	)

INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Available) VALUES
(1, 'A1234KM', 'AUDI', 'A8', '2010', 3, 5, 1),
(2, 'A4567AA', 'BMW', 'M6', '2012', 2, 3, 1),
(3, 'A9999KK', 'LADA', 'NIVA', '1999', 1, 5, 1)

CREATE TABLE Employees (
	Id INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO Employees (Id, FirstName, LastName, Title) VALUES
(1, 'First', 'Firstev', 'Salesman'),
(2, 'Second', 'Secondev', 'Marketeer'),
(3, 'Third', 'Thirdev', 'Guard')

CREATE TABLE Customers (
	Id INT PRIMARY KEY NOT NULL,
	DriverLicenceNumber VARCHAR(50) UNIQUE NOT NULL,
	FullName NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(255),
	City NVARCHAR(50),
	ZIPCODE NVARCHAR(50),
	Notes NVARCHAR(MAX)
	)

INSERT INTO Customers (Id, DriverLicenceNumber, FullName)  VALUES
(1, 'asd123', 'First Customer'),
(2, 'dsa321', 'Second Customer'),
(3, 'qwe123', 'Third Customer')

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel NUMERIC(5, 2),
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays INT NOT NULL,    
		--TotalDays AS DATEDIFF(DAY, StartDate, EndDate)
	RateApplied DECIMAL(10, 2),
	TaxRate DECIMAL(10, 2),
	OrderStatus NVARCHAR(50),
	Notes NVARCHAR(MAX)
	)

	--Validation for TotalDays
ALTER TABLE RentalOrders
ADD CONSTRAINT CHK_TotalDays CHECK(DATEDIFF(DAY, StartDate, EndDate) = TotalDays)

INSERT INTO RentalOrders(Id, EmployeeId, CustomerId, CarId, StartDate, EndDate, TotalDays) VALUES
(1, 1, 1, 1, '01-01-2010', '01-04-2010', 3),
(2, 2, 2, 2, '02-02-2010', '02-05-2010', 3),
(3, 3, 3, 3, '03-03-2010', '03-10-2010', 7)


/* ******************************************
	Problem 15.	Hotel Database
*********************************************/

CREATE DATABASE Hotel
GO

USE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(255) NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO Employees (Id, FirstName, LastName, Title) VALUES
(1, 'First', 'Firstev', 'Receptionist'),
(2, 'Second', 'Secondev', 'Porter'),
(3, 'Third', 'Thirdev', 'Maid')

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(50),
	EmergencyName NVARCHAR(50) NOT NULL,
	EmergencyNumber INT NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO Customers (AccountNumber, FirstName, LastName, EmergencyName, EmergencyNumber) VALUES
(1, 'First', 'Customer', 'Fire1', 123),
(2, 'Second', 'Customer', 'Fire2', 345),
(3, 'Third', 'Customer', 'Fire3', 678)

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO RoomStatus(RoomStatus) VALUES
('Free'),
('Occupied'),
('Booked')

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO RoomTypes(RoomType) VALUES
('Double Room'),
('Studio'),
('Apartment')

CREATE TABLE BedTypes (
	BedType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO BedTypes(BedType) VALUES
('Child Bed'),
('Normal Bed'),
('KingSize Bed')

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY NOT NULL,
	RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType) NOT NULL,
	BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType) NOT NULL,
	Rate DECIMAL(10, 2) NOT NULL,
	RoomStatus NVARCHAR(50) FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
	Notes NVARCHAR(MAX)
	)

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES
(1, 'Double Room', 'Kingsize Bed', 300, 'Booked'),
(2, 'Studio', 'Normal Bed', 344, 'Occupied'),
(3, 'Apartment', 'Child Bed', 400, 'Free')

CREATE TABLE Payments (
	Id INT PRIMARY KEY NOT NULL,
	EmployeeId        INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
    PaymentDate       DATE NOT NULL,
    AccountNumber     INT NOT NULL,
    FirstDateOccupied DATE NOT NULL,
    LastDateOccupied  DATE NOT NULL,
    TotalDays         INT NOT NULL,
    AmountCharged     DECIMAL(10, 2) NOT NULL,
    TaxRate           DECIMAL(10, 2) NOT NULL,
    TaxAmount         DECIMAL(10, 2) NOT NULL,
    PaymentTotal      DECIMAL(10, 2) NOT NULL,
    Notes             NVARCHAR(MAX)
	)

ALTER TABLE Payments
Add CONSTRAINT CHK_TotalDays CHECK(DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied) = TotalDays)

ALTER TABLE Payments
ADD CONSTRAINT CHK_TaxAmount CHECK(TaxAmount = TotalDays * TaxRate)

INSERT INTO Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied,
TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal) VALUES
(1, 1, '01-01-2015', 1, '01-01-2015', '01-05-2015', 4, 400, 100, 400, 400),
(2, 2, '02-02-2015', 1, '02-02-2015', '02-07-2015', 5, 500, 100, 500, 500),
(3, 3, '03-03-2015', 1, '03-03-2015', '03-10-2015', 7, 700, 100, 700, 700)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY NOT NULL,
	 EmployeeId    INT NOT NULL,
     DateOccupied  DATE NOT NULL,
     AccountNumber INT NOT NULL,
     RoomNumber    INT NOT NULL,
     RateApplied   DECIMAL(10, 2),
     PhoneCharge   VARCHAR(50) NOT NULL,
     Notes         NVARCHAR(MAX)
	 )

INSERT INTO Occupancies(Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, PhoneCharge) VALUES
(1, 1, '01-01-2012', 3, 1, '0888 123 456'),
(2, 2, '02-02-2013', 1, 3, '0888 999 999'),
(3, 3, '03-03-2013', 2, 2, '0888 111 111')

/* ******************************************
	Problem 16. Create SoftUni Database
*********************************************/

CREATE DATABASE SoftUni
GO

USE SoftUni

CREATE TABLE Towns (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL
	)

CREATE TABLE Addresses (
	Id INT PRIMARY KEY IDENTITY,
	AddressText NVARCHAR(30) NOT NULL,
	TownId INT CONSTRAINT FK_Addresses_Town FOREIGN KEY REFERENCES Towns(Id) NOT NULL
	)

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL
	)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	JobTitle NVARCHAR(30) NOT NULL,
	DepartmentId INT CONSTRAINT FK_Employees_Departments FOREIGN KEY REFERENCES 
	Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL (15, 2) NOT NULL,
	AddressId INT CONSTRAINT FK_Employees_Addresses FOREIGN KEY REFERENCES 
	Addresses(Id)
	)


/* ******************************************
	Problem 17. Backup Database
*********************************************/
BACKUP DATABASE SoftUni TO DISK = 'D:\SoftUni-backup.bak'

USE CarRental;

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni FROM DISK = 'D:\softuni-backup.bak';

/* ******************************************
	Problem 18.	Basic Insert
*********************************************/

INSERT INTO Towns ([Name]) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Departments ([Name]) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')


INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, 
HireDate, Salary) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, CONVERT(datetime, '01/02/2013', 103), 3500.00),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, CONVERT(datetime,'02/03/2004', 103), 4000.00),
('Maria', 'Petrova', 'Ivanova',	'Intern', 5, CONVERT(datetime,'28/08/2016', 103), 525.25),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, CONVERT(datetime, '09/12/2007', 103),	3000.00),
('Peter', 'Pan', 'Pan',	'Intern', 3, CONVERT(datetime, '28/08/2016', 103),	599.88)

/* ******************************************
	Problem 19. Basic Select All Fields
*********************************************/

SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

/* ******************************************
	Problem 20. Basic Select All Fields and Order Them
*********************************************/

SELECT * FROM Towns
ORDER BY [Name] ASC

SELECT * FROM Departments
ORDER BY [Name] ASC

SELECT * FROM Employees
ORDER BY Salary DESC

/* ******************************************
	Problem 21.	Basic Select Some Fields
*********************************************/

SELECT [Name] FROM Towns
ORDER BY [Name] ASC

SELECT [Name] FROM Departments
ORDER BY [Name] ASC

SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM Employees
ORDER BY Salary DESC

/* ******************************************
	Problem 22.	Increase Employees Salary
*********************************************/

UPDATE Employees 
SET Salary *= 1.10

SELECT [Salary] FROM Employees 

/* ******************************************
	Problem 23.	Decrease Tax Rate
*********************************************/

USE Hotel

--ALTER TABLE Payments
--DROP CONSTRAINT [CHK_TaxAmount];

UPDATE Payments
SET TaxRate *= 0.97

SELECT TaxRate FROM Payments

/* ******************************************
	Problem 24.	Delete All Records
*********************************************/

TRUNCATE TABLE Occupancies

