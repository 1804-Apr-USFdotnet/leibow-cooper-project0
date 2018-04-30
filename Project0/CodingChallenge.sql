CREATE DATABASE CodingChallenge
GO

CREATE SCHEMA Business
GO

CREATE TABLE Business.Products(
	[ID] int PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) not null,
	price decimal not null
)


CREATE TABLE Business.Customers(
	[ID] int PRIMARY KEY IDENTITY,
	Firstname NVARCHAR(30) not null,
	Lastname NVARCHAR(30) not null,
	CardNumber int not null
)

CREATE TABLE Business.Orders(
	[ID] int PRIMARY KEY IDENTITY,
	ProductID int  FOREIGN KEY REFERENCES Business.Products,
	CustomerID int FOREIGN KEY REFERENCES Business.Customers
)

INSERT INTO Business.Products ([Name], price)
VALUES('Hand saw', 20.33);

INSERT INTO Business.Products ([Name], price)
VALUES('Shovel', 30.44);

INSERT INTO Business.Products ([Name], price)
VALUES('Drill', 45.30);

INSERT INTO Business.Customers(Firstname, Lastname, Cardnumber)
VALUES('Cooper', 'Leibow', 123456);

INSERT INTO Business.Customers(Firstname, Lastname, Cardnumber)
VALUES('Samantha', 'Hoffman', 123123);

INSERT INTO Business.Customers(Firstname, Lastname, Cardnumber)
VALUES('Adam', 'Kiejdan', 133333);

INSERT INTO Business.Orders(ProductID, CustomerID)
VALUES(1,1);

INSERT INTO Business.Orders(ProductID, CustomerID)
VALUES(2,1);

INSERT INTO Business.Orders(ProductID, CustomerID)
VALUES(3,3);

INSERT INTO Business.Products ([Name], price)
VALUES('IPhone', 200.00);

INSERT INTO Business.Customers(Firstname, Lastname, Cardnumber)
VALUES('Jane', 'Smith', 345345);

INSERT INTO Business.Orders(ProductID, CustomerID)
VALUES(4,4);

SELECT FirstName FROM Business.Customers
INNER JOIN Business.Orders 
ON Business.Customers.ID = Business.Orders.CustomerID
WHERE CustomerID = 4;

SELECT [Name], totalSales FROM Business.Products
INNER JOIN Business.Orders ON Business.Products.ID = Business.Orders.ID
GROUP BY [Name], totalSales
HAVING Business.Products.[Name] = 'IPhone'
COUNT(ProductID) AS NumOfProducts
PRODUCT(NumoOfProducts)




UPDATE Business.Products
SET price = 250.00
WHERE [Name] = 'IPHONE'

SELECT price FROM Business.Products