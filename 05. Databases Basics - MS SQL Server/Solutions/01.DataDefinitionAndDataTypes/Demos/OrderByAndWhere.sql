SELECT 
	s.FirstName + ' ' + LastName AS FullName,
	s.Age,
	s.AverageGrade
FROM Students s
WHERE s.AverageGrade NOT BETWEEN 4 AND 6
ORDER BY FullName ASC; /*Otherwise DESC*/