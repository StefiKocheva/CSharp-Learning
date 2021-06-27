CREATE DATABASE Hotel;

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	FirstName NVARCHAR(20), 
	LastName NVARCHAR(20), 
	Title NVARCHAR(30), 
	Notes NVARCHAR(MAX),
);

INSERT INTO Employees VALUES
('Stefani', 'Kocheva', NULL, NULL),
('Stefani', 'Kocheva', NULL, NULL),
('Stefani', 'Kocheva', NULL, NULL);

CREATE TABLE Customers(
	AccountNumber INT PRIMARY KEY IDENTITY(1, 1), 
	FirstName NVARCHAR(20), 
	LastName NVARCHAR(20),  
	PhoneNumber NVARCHAR(15),
	EmergencyName NVARCHAR(30),
	EmergencyNumber NVARCHAR(20),
	Notes NVARCHAR(MAX),
);

INSERT INTO Customers VALUES
('Nikolay', 'Stoyanov', '0895268528', 'Emergency', '112', NULL),
('Nikolay', 'Stoyanov', '0895268528', 'Emergency', '112', NULL),
('Nikolay', 'Stoyanov', '0895268528', 'Emergency', '112', NULL);

CREATE TABLE RoomStatus(
	RoomStatus NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX),
);

INSERT INTO RoomStatus VALUES
('Free', NULL),
('Rent', NULL),
('Busy', NULL);

CREATE TABLE RoomTypes(
	RoomType NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX),
);

INSERT INTO RoomTypes VALUES
('Apartment', NULL),
('Double room', NULL),
('Single room', NULL);

CREATE TABLE BedTypes(
	BedType NVARCHAR(20) PRIMARY KEY,
	Notes NVARCHAR(MAX),
);

INSERT INTO BedTypes VALUES
('Double', NULL),
('Single', NULL),
('Double and single', NULL);

CREATE TABLE Rooms(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	RoomType NVARCHAR(20) NOT NULL, 
	BedType NVARCHAR(20) NOT NULL, 
	Rate NVARCHAR(20),  
	RoomStatus NVARCHAR(MAX) NOT NULL,
	Notes NVARCHAR(MAX),
);

INSERT INTO Rooms VALUES
('Apartment', 'Double', 'Excellent', 'Free', NULL),
('Apartment', 'Double', 'Excellent', 'Free', NULL),
('Apartment', 'Double', 'Excellent', 'Free', NULL);

CREATE TABLE Payments(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	EmployeeId INT NOT NULL, 
	PaymentDate DATETIME NOT NULL,
	DateOccupied DATETIME, 
	AccountNumber INT NOT NULL,
	RoomNumber NVARCHAR(4),
	FirstDateOccupied DATETIME NOT NULL,
	LastDateOccupied DATETIME NOT NULL,
	TotalDays INT NOT NULL,
	AmountCharged MONEY,
	TaxRate MONEY,
	TaxAmount MONEY,
	PaymentTotal MONEY,
	Notes NVARCHAR(MAX),
);

INSERT INTO Payments VALUES
(1, '12-01-2019', '01-13-2020', 1232, '897', '12-01-2019','01-13-2020', 2, 25.80, 2.50, 4.20, 30.00, NULL),
(1, '12-01-2019', '01-13-2020', 1231, '89', '12-01-2019', '01-13-2020', 2, 25.80, 2.50, 4.20, 30.00, NULL),
(1, '12-01-2019', '01-13-2020', 1235, '8', '12-01-2019', '01-13-2020', 2, 25.80, 2.50, 4.20, 30.00, NULL);

CREATE TABLE Occupancies(
	Id INT PRIMARY KEY IDENTITY(1, 1), 
	EmployeeId INT NOT NULL, 
	DateOccupied DATETIME, 
	AccountNumber NVARCHAR(15),
	RoomNumber NVARCHAR(4),
	RateApplied NVARCHAR(20), 
	PhoneCharge BIT,
	Notes NVARCHAR(MAX),
);

INSERT INTO Occupancies VALUES
(1, '12-01-2019', '878970098', '123', 'Excellent', 'true', NULL),
(1, '12-01-2019', '878970098', '123', 'Excellent', 'true', NULL),
(1, '12-01-2019', '878970098', '123', 'Excellent', 'true', NULL);