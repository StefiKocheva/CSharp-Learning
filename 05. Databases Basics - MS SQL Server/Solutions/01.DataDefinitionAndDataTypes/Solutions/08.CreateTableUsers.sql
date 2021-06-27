CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Username NVARCHAR(30) NOT NULL,
	[Password] NVARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX) CHECK (DATALENGTH(ProfilePicture) <= 921600),
	LastLoginTime DATETIME2,
	IsDeleted BIT,
);

INSERT INTO Users VALUES
('stefi9', '1234sk', NULL, '12-01-2019', 'true'),
('stefi10', '1234sk', NULL, '12-01-2019', 'true'),
('stefi11', '1234sk', NULL, '12-01-2019', 'true'),
('stefi12', '1234sk', NULL, '12-01-2019', 'true'),
('stefi13', '1234sk', NULL, '12-01-2019', 'true');