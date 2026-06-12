SELECT city,
COUNT(*) AS total

FROM Users

GROUP BY city

HAVING COUNT(*) >= 1;