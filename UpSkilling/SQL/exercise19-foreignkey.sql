CREATE TABLE Booking(

    booking_id INT PRIMARY KEY AUTO_INCREMENT,

    user_id INT,

    FOREIGN KEY(user_id)

    REFERENCES Users(user_id)

);
