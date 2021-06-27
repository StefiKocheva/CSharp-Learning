CREATE VIEW V_EmployeeNameJobTitle AS SELECT 
	FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName as [Full name], 
	JobTitle
FROM Employees;
