INSERT INTO Towns VALUES
('Sofia'),
('Plovdiv'), 
('Varna'), 
('Burgas');

INSERT INTO Departments VALUES
('Engineering'), 
('Sales'), 
('Marketing'), 
('Software Development'), 
('Quality Assurance');

INSERT INTO Employees(FirstName, MiddleName, LastName, JobTitle, HireDate, Salary, DepartmentId) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', '02-01-2013', 3500.00, 4),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', '03-02-2004', 4000.00, 1),
('Maria', 'Petrova', 'Ivanova', 'Intern', '08-28-2016', 525.25, 5),
('Georgi', 'Teziev', 'Ivanov', 'CEO', '12-09-2007', 3000.00, 2),
('Peter', 'Pan', 'Pan', 'Intern', '08-28-2016', 599.88, 3);
