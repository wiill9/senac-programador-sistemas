use senac;
drop table cliente;
create table cliente (
id int primary key auto_increment,
nome VARCHAR (100) not null,
idade int null,
cidade VARCHAR (100) not null, 
saldo decimal (10, 2) null
);

insert into cliente (
nome, idade, cidade, saldo) values 
('Carlos', 45, 'Sao Paulo', 250000),
('Mariana', 32, 'Rio de Janeiro', 320050), 
('Pedro', 27, 'Belo Horizonte', 150075),
('Fernanda', 38, 'Curitiba', 420000);

select * from cliente
where
cidade = 'Rio de Janeiro';

select * from cliente
ORDER BY saldo >= 2000 desc;

select * from cliente
where
idade >= 30;

select * from cliente 
where 
idade >= 25 and idade <= 40;

select * from cliente 
where 
nome like 'F%';

select * from cliente 
where
cidade != 'Sao Paulo' and cidade != 'Curitiba';

use senac;
drop table pedido;
create table pedido (
id int primary key auto_increment,
cliente_id INT NOT NULL,
valor decimal (10, 2) not null,
data_pedido DATETIME NOT NULL,
FOREIGN KEY (cliente_id) REFERENCES cliente (id)
 );
 insert into pedido (
cliente_id, valor, data_pedido) values 
 (1, 500.00, '2024-03-10'),
 (2, 1200.00, '2024-03-12'),
 (3, 300.50, '2024-03-15'),
 (1, 800.00, '2024-03-18');
 
 select * from pedido;

select count(*) from pedido;

select AVG(valor) from pedido;

select cliente_id, sum(valor) from pedido group by cliente_id;

select
 p.id, c.nome, p.valor
 from
pedido p 
INNER JOIN 
cliente c on p.cliente_id = c.id;

select 
c.id, c.nome, p.valor
from
cliente c 
LEFT JOIN  
pedido p on c.id = p.cliente_id;

select 
c.id, c.nome, p.id as pedido, p.valor
from 
cliente c
 Inner Join pedido p on c.id = p.cliente_id
 where p.valor > ( select AVG(valor) from pedido);
 
 select c. *
 from
 cliente c 
 where c.id in(select p.cliente_id from pedido p where p.valor > 1000); 
 
 insert into cliente (nome, cidade) 
 values ('Rafael', 'Porto Alegre');
 
 select * from cliente;
 
 





 








