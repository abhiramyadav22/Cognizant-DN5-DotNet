SELECT city,
COUNT(*) AS total_users
FROM Users
GROUP BY city;