CREATE TABLE Customers
(
    CustomerId INT,
    CustomerName VARCHAR(50)
);

CREATE TABLE Orders
(
    OrderId INT,
    CustomerId INT
);

SELECT Customers.CustomerName,
Orders.OrderId
FROM Customers
INNER JOIN Orders
ON Customers.CustomerId =
Orders.CustomerId;