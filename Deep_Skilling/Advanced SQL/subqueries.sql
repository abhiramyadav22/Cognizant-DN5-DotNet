SELECT Name
FROM Students
WHERE Id IN
(
    SELECT Id
    FROM Students
    WHERE Id > 1
);