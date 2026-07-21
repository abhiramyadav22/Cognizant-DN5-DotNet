CREATE TABLE Feedback(

    feedback_id INT PRIMARY KEY AUTO_INCREMENT,

    user_name VARCHAR(100) NOT NULL,

    rating INT CHECK(rating >= 1 AND rating <= 5)

);