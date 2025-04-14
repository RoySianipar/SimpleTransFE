-- Membuat database baru untuk sistem bank
CREATE DATABASE BankDB;
GO

-- Gunakan database tersebut
USE BankDB;
GO

-- Create Tabel Accounts
CREATE TABLE Accounts (
    AccountNumber VARCHAR(20) PRIMARY KEY,
    AccountHolderName VARCHAR(100) NOT NULL,
    Balance DECIMAL(18,2) NOT NULL DEFAULT 0
);
GO

-- Create Tabel Transactions
CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    AccountNumber VARCHAR(20) NOT NULL,
    TransactionType VARCHAR(20) CHECK (TransactionType IN ('Deposit', 'Withdrawal')),
    Amount DECIMAL(18,2) NOT NULL CHECK (Amount > 0),
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (AccountNumber) REFERENCES Accounts(AccountNumber)
);
GO

-- Insert Untuk Saldo Awal
INSERT INTO Accounts (AccountNumber, AccountHolderName, Balance)
VALUES ('1234567890', 'Sempurna', 10000000);

-- Execute Cek logic sudah berjalan atau tidak
EXEC PerformTransaction '1234567890', 'Deposit', 500000;
EXEC PerformTransaction '1234567890', 'Withdrawal', 9000000;

-- Menambah kolom untuk solusi Soal 3
ALTER TABLE Transactions
ADD Balance DECIMAL(18,2) NULL;