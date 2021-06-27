CREATE DATABASE Movies;

CREATE TABLE Directors(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	DirectorName NVARCHAR(40),
	Notes NVARCHAR(MAX),
);

INSERT INTO Directors VALUES
('Nikolay', 'Something interesting'),
('Nikolay', 'Something interesting'),
('Nikolay', 'Something interesting'),
('Nikolay', 'Something interesting'),
('Nikolay', 'Something interesting');

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	GenreName NVARCHAR(40),
	Notes NVARCHAR(MAX),
);

INSERT INTO Genres VALUES
('Horror', 'Something interesting'),
('Horror', 'Something interesting'),
('Horror', 'Something interesting'),
('Horror', 'Something interesting'),
('Horror', 'Something interesting');

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	CategoryName NVARCHAR(40),
	Notes NVARCHAR(MAX),
);

INSERT INTO Categories VALUES
('For adults', 'Something interesting'),
('For adults', 'Something interesting'),
('For adults', 'Something interesting'),
('For adults', 'Something interesting'),
('For adults', 'Something interesting');

CREATE TABLE Movies(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Title NVARCHAR(40),
	DirectorId INT NOT NULL,
	CopyrightYear NVARCHAR(4),
	[Length] TIME,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating NVARCHAR(10),
	Notes NVARCHAR(MAX),
);

INSERT INTO Movies VALUES
('Me', 1, 2020, '01:23:34', 1, 1, 'Excellent', 'Something interesting'),
('Me', 1, 2020, '01:23:34', 1, 1, 'Excellent', 'Something interesting'),
('Me', 1, 2020, '01:23:34', 1, 1, 'Excellent', 'Something interesting'),
('Me', 1, 2020, '01:23:34', 1, 1, 'Excellent', 'Something interesting'),
('Me', 1, 2020, '01:23:34', 1, 1, 'Excellent', 'Something interesting');