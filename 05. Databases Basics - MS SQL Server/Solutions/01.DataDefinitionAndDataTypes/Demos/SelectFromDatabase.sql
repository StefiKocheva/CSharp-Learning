SELECT * /* Select all; TOP(count) - if you want to choose the top results. */
FROM Students;

SELECT /* Select concrete columns */
	s.FirstName,
	s.LastName
FROM Students s;

SELECT
	s.FirstName + ' ' + s.LastName AS FullName, /* Concatenation */
	s.Age
FROM Students s;