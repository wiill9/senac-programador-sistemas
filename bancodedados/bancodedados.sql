CREATE TABLE  IF NOT EXISTS livro (
 id INT primary KEY AUTO_INCREMENT,
 titulo VARCHAR (100) NOT NULL,
 data_depublicacao DATETIME NOT NULL,
 numero_paginas INT NULL,
 preco DECIMAL(10, 2) NULL, 
 isbn VARCHAR (17) NOT NULL UNIQUE,
 id_genero INT NOT NULL,
 id_editora INT NOT NULL,
 id_autor INT NOT NULL,
 FOREIGN KEY (id_genero) REFERENCES genero (id),
 FOREIGN KEY (id_editora) REFERENCES editora (id),
 FOREIGN KEY (id_autor) REFERENCES autor (id)
);


 
 INSERT INTO livro (
   titulo,
 data_depublicacao,
 numero_paginas,
 preco,
 genero,
 editotra,
 isbn ,
 autor )
 
   VALUES (
   'titulo do meu livro',
   '2006-07-11 00:00:00', 
    250,
    129.99,
   'futebol',
   'editora', 
   '1978-3-16 148410-0', 
   'wilder ribeiro'
   );
   INSERT INTO livro (
   titulo,
 data_depublicacao,
 numero_paginas,
 preco,
 genero,
 editotra,
 isbn ,
 autor )
 
 VALUES (
 'O Hobbit',
 '1937-09-21',
 310,
 79.99,
 'fantasia',
 'george allen',	
 978-0-618-00221-3,
 'J.R.R Tolkien'
 );
 
 
 
  
   
   
   
   select * from livro;