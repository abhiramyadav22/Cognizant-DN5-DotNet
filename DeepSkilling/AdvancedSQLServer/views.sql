CREATE TABLE Students
(
    Id INT,
    Name VARCHAR(50)
);

CREATE VIEW StudentView AS
SELECT Name FROM Students;

SELECT * FROM StudentView;