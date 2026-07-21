CREATE TABLE AuditLog
(
    Message VARCHAR(100)
);

CREATE TRIGGER StudentTrigger
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditLog
    VALUES('Student Inserted');
END;