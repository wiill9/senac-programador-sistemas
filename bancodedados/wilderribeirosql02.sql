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
SELECT 
    *
FROM
    fornecedor;

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id) VALUES
('Celular X', 'Eletronicos', 2500.00, 30, 1),
('Notebook Y', 'Eletronicos', 4800.00, 15, 2),
('Mesa de Madeira', 'Moveis', 750.00, 10, 3),
('Cadeira Z', 'Moveis', 300.00, 25, 3),
('TV 50', 'Eletronicos', 3500.00, 8, 1);
SELECT 
    *
FROM
    produto;

INSERT INTO cliente (nome, cidade, idade) VALUES 
('João Silva', 'São Paulo', 35), 
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);
SELECT 
    *
FROM
    cliente;

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
(1, 2, '2024-03-10', 1), 
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);
SELECT 
    *
FROM
    pedido;
    
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

SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';

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

SELECT 
    id, produto_id, quantidade
FROM
    pedido
WHERE
    (SELECT 
            MAX(quantidade)
        FROM
            pedido);

SELECT 
    cidade, COUNT(*) AS total_cliente
FROM
    cliente
GROUP BY cidade
ORDER BY total_cliente DESC;

SELECT 
    p.nome, f.nome
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome;

SELECT 
    ped.*, produto_id, cliente.nome, produto.nome
FROM
    pedido ped
        INNER JOIN
    cliente ON ped.cliente_id = cliente.id
        INNER JOIN
    produto ON ped.produto_id = produto.id
ORDER BY ped.data_pedido;

SELECT 
    ped.*, cliente.nome, produto.nome, fornecedor.nome
FROM
    pedido ped
        INNER JOIN
    cliente ON ped.cliente_id = cliente.id
        INNER JOIN
    produto ON ped.produto_id = produto.id
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id;
    
    SELECT 
    cliente.nome,
    SUM(pedido.quantidade) AS totaldeprodutosadquiridos
FROM
    cliente
        INNER JOIN
    pedido ON cliente.id = pedido.cliente_id
GROUP BY cliente.nome
ORDER BY totaldeprodutosadquiridos DESC;

SELECT 
    nome, categoria, preco
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto p
        WHERE
            p.categoria = produto.categoria);
            
UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'Eletronicos';
    SELECT 
    *
FROM
    produto;

DELETE FROM pedido
WHERE
    cliente_id IN (SELECT 
        id
    FROM
        cliente
    
    WHERE
        cidade = 'Curitiba');
        SELECT 
    *
FROM
    pedido;
        
        insert into cliente (nome, cidade, idade) values 
        ('João Silva', 'Porto Alegre', 38);
        SELECT 
    *
FROM
    cliente;
        
       INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id)
VALUES (
    (SELECT id FROM produto WHERE nome = 'Notebook Y' LIMIT 1),
    2,
    '2024-03-25',
    (SELECT id FROM cliente WHERE nome = 'João Silva' LIMIT 1)
);
select * from pedido;

SELECT DISTINCT
    cliente.nome
FROM
    pedido ped
        INNER JOIN
    cliente ON ped.cliente_id = cliente.id
        INNER JOIN
    produto ON ped.produto_id = produto.id
WHERE
    produto.categoria = 'Moveis'; 