ALTER TABLE Cleaners
ADD FOREIGN KEY (BankDetailsId) REFERENCES [CleanerBankDetails](BankDetailsId);