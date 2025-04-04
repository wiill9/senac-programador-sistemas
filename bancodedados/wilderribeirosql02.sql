USE senac;
DROP TABLE fornecedor;
CREATE TABLE fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);

DROP TABLE produto;
CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco decimal (10, 2) null, 
    estoque INT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id)
    );
    
    DROP TABLE cliente; 
    CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade varchar (50) not null,
    idade int null
    );
    
DROP TABLE pedido;
CREATE TABLE pedido (
 id INT PRIMARY KEY AUTO_INCREMENT,
 produto_id INT NOT NULL,
 quantidade int null, 
 data_pedido datetime not null, 
cliente_id INT NOT NULL,
FOREIGN KEY (cliente_id) REFERENCES cliente (id),
FOREIGN KEY (produto_id) REFERENCES produto (id)
);

INSERT INTO fornecedor (nome, cidade) VALUES
 ('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Movies&Co', 'Curitiba');
select * from fornecedor;

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id) VALUES
('Celular X', 'Eletronicos', 2500.00, 30, 1),
('Notebook Y', 'Eletronicos', 4800.00, 15, 2),
('Mesa de Madeira', 'Moveis', 750.00, 10, 3),
('Cadeira Z', 'Moveis', 300.00, 25, 3),
('TV 50', 'Eletronicos', 3500.00, 8, 1);
select * from produto;

INSERT INTO cliente (nome, cidade, idade) VALUES 
('João Silva', 'São Paulo', 35), 
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);
select * from cliente;

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
(1, 2, '2024-03-10', 1), 
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);
select * from pedido;

SELECT 
    *
FROM
    produto
WHERE
    categoria = 'Eletronicos'
ORDER BY preco > 3000 DESC; 

SELECT 
    *
FROM
    cliente
WHERE
    cidade != 'São Paulo' AND idade >= 30;
    
    SELECT 
    *
FROM
    pedido
WHERE
    data_pedido >= '2024-03-10 00:00:00'
        AND data_pedido <= '2024-03-15 23:59:59'; 

SELECT 
    *
FROM
    produto
ORDER BY estoque < 10 ASC;

select * from fornecedor 
where 
cidade != 'Rio de Janeiro' and nome like 'T%';

SELECT 
    categoria, AVG(preco)
FROM
    produto
GROUP BY categoria;

SELECT 
    cliente_id, COUNT(*)
FROM
    pedido
GROUP BY cliente_id;

SELECT 
    categoria, SUM(estoque)
FROM
    produto
GROUP BY categoria;



