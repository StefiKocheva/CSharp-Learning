CREATE DATABASE CarRental;

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	CategoryName NVARCHAR(30), 
	DailyRate TINYINT, 
	WeeklyRate TINYINT, 
	MonthlyRate TINYINT, 
	WeekendRate TINYINT,
);

INSERT INTO Categories VALUES 
('Car', 2, 14, 60, 15),
('Bus', 2, 14, 60, 15),
('Truck', 2, 14, 60, 15);

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	PlateNumber INT, 
	Manufacturer NVARCHAR(15), 
	Model NVARCHAR(25), 
	CarYear INT, 
	CategoryId INT NOT NULL,
	Doors INT,
	Picture VARBINARY(MAX),
	Condition BIT,
	Available BIT,
);

INSERT INTO Cars VALUES
(567, 'Unknown', 'Lada', 1960, 7, 4, NULL, 'true', 'true'),
(897, 'Unknown', 'Lada', 1960, 5, 4, NULL, 'true', 'true'),
(689, 'Unknown', 'Lada', 1960, 7, 4, NULL, 'true', 'true');

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	FirstName NVARCHAR(20), 
	LastName NVARCHAR(20), 
	Title NVARCHAR(30), 
	Notes NVARCHAR(MAX),
);

INSERT INTO Employees VALUES
('Sombody', 'Unknown', 'Selling Lada', NULL),
('Sombody', 'Unknown', 'Selling Lada', NULL),
('Sombody', 'Unknown', 'Selling Lada', NULL);

CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	DriverLicenceNumber INT, 
	FullName NVARCHAR(100), 
	[Address] NVARCHAR(50),
	City NVARCHAR(30),
	ZIPCode INT,
	Notes NVARCHAR(MAX),
);

INSERT INTO Customers VALUES
(78, 'Stefani Kocheva', 'Batak 27', 'Pazardzik', 4400, NULL),
(9, 'Stefani Kocheva', 'Batak 27', 'Pazardzik', 4400, NULL),
(689, 'Stefani Kocheva', 'Batak 27', 'Pazardzik', 4400, NULL);

CREATE TABLE RentalOrders(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	EmployeeId INT NOT NULL, 
	CustomerId INT NOT NULL, 
	CarId INT NOT NULL,
	TankLevel INT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied INT,
	TaxRate INT,
	OrderStatus NVARCHAR(MAX),
	Notes NVARCHAR(MAX),
);

INSERT INTO RentalOrders VALUES
(1, 2, 3, 8, 20, 160, 160, '08-08-2019', '12-01-2019', NULL, 96, 89, NULL, NULL),
(1, 2, 3, 5, 20, 160, 160, '08-08-2019', '12-01-2019', NULL, 94, 43, NULL, NULL),
(1, 2, 3, 9, 20, 160, 160, '08-08-2019', '12-01-2019', NULL, 34, 12, NULL, NULL);