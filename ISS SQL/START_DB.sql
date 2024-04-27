CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY,
    Username VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(50) NOT NULL
);


INSERT INTO Users (Username, Password, Role) 
VALUES ('TheBabby', 'thebabby', 'Artist');

INSERT INTO Users (Username, Password, Role) 
VALUES ('sergiu', 'sergiu', 'Normal');

INSERT INTO Users (Username, Password, Role) 
VALUES ('admin', 'admin', 'Admin');