USE bzvydemhrsd1x1irmadz;
SELECT * FROM proyect_API;

ALTER TABLE proyect_API
ADD Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL, 
ADD Nombre VARCHAR(50),
ADD Apellidos VARCHAR(50),
ADD Correo VARCHAR(150),
ADD Notas VARCHAR(300),
ADD Enviado DATE;



INSERT INTO proyect_API (id, Nombre, Apellidos, Correo, Notas, Enviado)
VALUES(NULL,'Julian','Vélez','julian@gmail.com','Lorem ipsum dolor sit amet consectetur adipisicing elit. Illo enim sapiente atque veniam expedita ex at non. Voluptatem eaque suscipit quos ratione, velit dolores, magnam sequi dignissimos quaerat quia aspernatur.','2024-05-03');

