CREATE TABLE Employees
(
    Id INT,
    Name VARCHAR(50)
);

CREATE INDEX idx_employee
ON Employees(Name);