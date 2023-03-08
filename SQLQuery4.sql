/*
CREATE TABLE Produkt (
    ProduktID INT PRIMARY KEY,
    Produktnavn NVARCHAR(50),
    Pris DECIMAL(10,2),
	Antal int
);
*/

/*
INSERT INTO Produkt (ProduktID, Produktnavn, Pris)
VALUES 
    (1, 'Sko', ROUND(RAND() * 1000, 2)),
    (2, 'Jakke', ROUND(RAND() * 1000, 2)),
    (3, 'Trøje', ROUND(RAND() * 1000, 2)),
    (4, 'Boxershorts', ROUND(RAND() * 1000, 2)),
    (5, 'Strømper', ROUND(RAND() * 1000, 2)),
    (6, 'T-shirt', ROUND(RAND() * 1000, 2)),
    (7, 'Hue', ROUND(RAND() * 1000, 2)),
    (8, 'Bukser', ROUND(RAND() * 1000, 2));
*/


/*
CREATE TABLE Ordre (
    OrdreID INT PRIMARY KEY IDENTITY(1,1),
    KundeID INT NOT NULL,
    ProduktID INT NOT NULL,
    Antal INT NOT NULL,
    TotalPris DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Ordre_Produkt FOREIGN KEY (ProduktID) REFERENCES Produkt(ProduktID),
    CONSTRAINT FK_Ordre_Kunde FOREIGN KEY (KundeID) REFERENCES Kunde(KundeID)
);
*/