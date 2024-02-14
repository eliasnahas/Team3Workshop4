  ALTER TABLE Customers
  ADD Username varchar(30);

  ALTER TABLE Customers
  ADD Password varchar(30);

  UPDATE Customers
  SET Customers.Username = LOWER(SUBSTRING(Customers.CustFirstName, 1, 1) + Customers.CustLastName);

  UPDATE Customers
  SET Customers.[Password] = 'password';

  CREATE TABLE CustomerPackage
  (
	CustomerPackageId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CustomerId INT NOT NULL,
	PackageId INT NOT NULL,
	FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
	FOREIGN KEY (PackageId) REFERENCES Packages(PackageId)
  )

  ALTER TABLE Customers
  ALTER COLUMN CustEmail nvarchar(50) NULL;