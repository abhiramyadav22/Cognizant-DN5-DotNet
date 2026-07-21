CREATE TABLE Registrations(

    registration_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    event_id INT

);
INSERT INTO Registrations(user_id,event_id)
VALUES
(1,1),
(2,2);
SELECT u.full_name,
e.title

FROM Users u

INNER JOIN Registrations r
ON u.user_id = r.user_id

INNER JOIN Events e
ON e.event_id = r.event_id;