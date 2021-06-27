SELECT *
FROM Teachers;

SELECT *
FROM Subjects

SELECT 
	t.FirstName + ' ' + t.LastName AS FullName,
	s.[Name]
FROM Teachers t
INNER JOIN Subjects s ON t.SubjectId = s.Id;