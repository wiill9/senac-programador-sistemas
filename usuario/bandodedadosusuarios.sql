Create database usuario;
use usuario;
CREATE TABLE usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(50) NOT NULL
);
insert into usuario (email, senha) values 
('neymar.jr@email.com', 'Brun@123'),
('pablo.vittar@email.com', '12345Abc!'),
('sukuna.silva@email.com', 'Sete7Sete!');

SELECT 
    *
FROM
    usuario;