# suisuisuisusui
howcouldyouleaveus
database:::::::::
use master;
Create database BankSystem3
use BankSystem3;
create table bank(
	bank_id INT PRIMARY KEY,
	bank_name	varchar(40),
	bank_address VARCHAR(255),
	bank_branches varchar(40)
	
	);
CREATE TABLE Branch (
  branch_id INT PRIMARY KEY,
  bank_id INT,
  branch_number VARCHAR(50),
  bank_address VARCHAR(255),
  FOREIGN KEY (Bank_id) REFERENCES Bank(Bank_id)
);

CREATE TABLE Customer (
  customer_id INT PRIMARY KEY,
  costumer_ssn VARCHAR(20),
  customer_name VARCHAR(255),
  customer_phone VARCHAR(20),
  customer_address VARCHAR(255)
);

CREATE TABLE Account (
  account_number INT PRIMARY KEY,
  customer_id INT,
  account_balance DECIMAL(10,2),
  account_type VARCHAR(50),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_iD)
);

CREATE TABLE Loan (
  LoanID INT PRIMARY KEY,
  BranchID INT,
  CustomerID INT,
  LoanType VARCHAR(50),
  LoanAmount DECIMAL(10,2),
  FOREIGN KEY (BranchID) REFERENCES Branch(branch_id),
  FOREIGN KEY (CustomerID) REFERENCES Customer(customer_id)
);



-- Insert explicit values
INSERT INTO Bank (bank_id, bank_name, bank_branches, bank_address)
VALUES
  (1, 'Bank A', 'Branch A', 'Address A'),
  (2, 'Bank B', 'Branch B', 'Address B'),
  (3, 'Bank C', 'Branch C', 'Address C'),
  (4, 'Bank D', 'Branch D', 'Address D'),
  (5, 'Bank E', 'Branch E', 'Address E');

