use senac;
drop table cliente; 
CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    nome_social VARCHAR(100) NULL,
    datadenascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);
insert into cliente (nome, datadenascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) values 
('Neymar JR', '1992-02-05', 'neymar@email.com', 11999999991, 0, 3, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco do Neymar')),
('Yuri Alberto', '2001-03-18', 'yuri@email.com', 11911111112, 0, 0, 1, 0, (select id from endereco where logradouro = 'Endereco do Yuri'));

select * from cliente;