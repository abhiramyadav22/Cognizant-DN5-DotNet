SELECT *

FROM Users

WHERE user_id IN

(
    SELECT user_id
    FROM Registrations
);
