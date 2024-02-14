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
    CustomerId INT NOT NULL,
    PackageId INT NOT NULL,
    FOREIGN KEY (CustomerId)
    REFERENCES Customers(CustomerId),
    FOREIGN KEY (PackageId)
    REFERENCES Packages(PackageId)
  )