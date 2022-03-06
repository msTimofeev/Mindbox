create table Products
(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50) NOT NULL
)

create table Categories
(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50) NOT NULL
)

create table Products_Categories
(
	Product_Id INT NOT NULL FOREIGN KEY REFERENCES Products(Id),
	Category_Id INT NOT NULL FOREIGN KEY REFERENCES Categories(Id)
)

SELECT p.Name, c.Name
FROM Products AS p
LEFT JOIN Products_Categories AS pc ON p.Id = pc.Product_Id
LEFT JOIN Categories AS c ON c.Id = pc.Category_Id