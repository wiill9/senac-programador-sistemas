create table endereco (
id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
    );
    insert into endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) values 
    ('Endereco do Neymar', 11, 'bairro', 'Municipio', 'SP', '00000001', NULL), 
   ('Endereco do Yuri', 9, 'bairro', 'Municipio', 'SP', '00000001', NULL);