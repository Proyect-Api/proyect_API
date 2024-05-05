USE bzvydemhrsd1x1irmadz;
SELECT * FROM bzvydemhrsd1x1irmadz;
SELECT * FROM Notas;

ALTER TABLE Notas
ADD Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL, 
ADD Nombre VARCHAR(50),
ADD Apellidos VARCHAR(50),
ADD Correo VARCHAR(150),
ADD Notas VARCHAR(300),
ADD Enviado DATE;



INSERT INTO Notas (id, Nombre, Apellidos, Correo, Notas, Enviado)
VALUES(NULL,'Wiliam','Moriarty','wiliam@gmail.com','Es más listo que Moriarty, como demuestra el hecho de que él y Sherlock organizaran una docena de planes diferentes sobre el encuentro en el tejado de aquel hospital en La caída de Reichenbach.','2024-05-03');

