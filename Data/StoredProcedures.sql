
CREATE PROCEDURE GetUserLikes
    @UserID VARCHAR(20)
AS
BEGIN
    SELECT l.*, p.ProductName, u.Email
    FROM LikeList l
    JOIN Products p ON l.ProductNo = p.No
    JOIN Users u ON l.UserID = u.UserID
    WHERE l.UserID = @UserID
END
