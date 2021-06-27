CREATE DATABASE Softuni;

CREATE TABLE Towns(
	Id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[Name] NVARCHAR(20) NOT NULL,
);

CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	AddressText NVARCHAR(100),
	TownId INT FOREIGN KEY REFERENCES Towns(Id),
);

CREATE TABLE Departments(
	Id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[Name] NVARCHAR(20) NOT NULL,
);

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	FirstName NVARCHAR(20),
	MiddleName NVARCHAR(20),
	LastName NVARCHAR(20),
	JobTitle NVARCHAR(60), 
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
	HireDate DATETIME2,
	Salary MONEY, 
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id),
);