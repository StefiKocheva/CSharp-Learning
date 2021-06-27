CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] NVARCHAR(50) NOT NULL,
	Picture VARBINARY(MAX) CHECK (DATALENGTH(Picture) <= 2097152),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL(5, 2),
	Gender CHAR(1) NOT NULL CHECK (Gender = 'm' OR Gender = 'f'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX),
);

INSERT INTO People VALUES
('Nikolay', NULL, 1.85, 91.00, 'm', '2005-08-08', NULL),
('Niki', NULL, 1.85, 91.00, 'm', '2005-08-08', NULL),
('Bebeto', NULL, 1.85, 91.00, 'm', '2005-08-08', NULL),
('Nikito', NULL, 1.85, 91.00, 'm', '2005-08-08', NULL),
('Nikolay', NULL, 1.85, 91.00, 'm', '2005-08-08', NULL);