DELIMITER //

CREATE PROCEDURE ShowUsers()

BEGIN

    SELECT * FROM Users;

END //

DELIMITER ;
CALL ShowUsers();