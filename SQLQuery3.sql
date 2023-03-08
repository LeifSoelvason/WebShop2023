/*
CREATE TABLE Kunde (
    KundeID INT IDENTITY(1,1) PRIMARY KEY,
    Fornavn VARCHAR(50) NOT NULL,
    Efternavn VARCHAR(50) NOT NULL,
	Username VARCHAR (50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
	
);
*/


/*
CREATE TABLE Adresse (
    AdresseID INT IDENTITY(1,1) PRIMARY KEY,
	Gadenavn VARCHAR(50) NOT NULL,
    Gadenummer int NOT NULL,
    Postnummer int NOT NULL,
	ByNavn VARCHAR (50) NOT NULL,
	KundeID INT NOT NULL,
    FOREIGN KEY (KundeID) REFERENCES Kunde(KundeID)
);
*/