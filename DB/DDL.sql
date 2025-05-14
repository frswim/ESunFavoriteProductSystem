
CREATE TABLE Users (
    UserID VARCHAR(20) PRIMARY KEY,
    UserName NVARCHAR(50),
    Email NVARCHAR(100),
    Account VARCHAR(20)
);

CREATE TABLE Products (
    No INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100),
    Price DECIMAL(18,2),
    FeeRate DECIMAL(5,2)
);

CREATE TABLE LikeList (
    SN INT PRIMARY KEY IDENTITY,
    ProductNo INT FOREIGN KEY REFERENCES Products(No),
    UserID VARCHAR(20) FOREIGN KEY REFERENCES Users(UserID),
    OrderNumber INT,
    Account VARCHAR(20),
    TotalFee DECIMAL(18,2),
    TotalAmount DECIMAL(18,2)
);
