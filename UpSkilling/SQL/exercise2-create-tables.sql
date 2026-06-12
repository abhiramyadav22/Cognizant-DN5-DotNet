CREATE TABLE Users(

    user_id INT PRIMARY KEY AUTO_INCREMENT,
    full_name VARCHAR(100),
    email VARCHAR(100),
    city VARCHAR(50)

);

CREATE TABLE Events(

    event_id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(100),
    city VARCHAR(50),
    status VARCHAR(20)

);