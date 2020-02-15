CREATE TABLE Contas (
    email VARCHAR(80) NOT NULL PRIMARY KEY,
    senha VARCHAR(32) NOT NULL,
	nome  VARCHAR(60) NOT NULL,
	tipoConta CHAR(4) NOT NULL, --admi user
	foto TEXT
  )

CREATE TABLE Produtos (
    Codigo INT NOT NULL PRIMARY KEY IDENTITY,
   	Nome VARCHAR(70) NOT NULL,
    Preço DECIMAL(7,2) NOT NULL,
    Estoque INT NOT NULL
  )

CREATE TABLE Compras (
    Codigo INT NOT NULL PRIMARY KEY IDENTITY,
    Codigo_produtos VARCHAR(70) NOT NULL,
    Email_Usuario VARCHAR(80) NOT NULL
  )

  SELECT * FROM Contas where tipoConta='user';

  SELECT * FROM Compras;
  SELECT * FROM Produtos;


  INSERT INTO Contas (email, nome, senha, tipoConta) VALUES ('joao@gmail.com','João','1234', 'admi'), ('mrswlady@outlook.com','Vladmir','1234','admi'), ('edu.dovale@gmail.com','Eduardo do Vale','1234','admi');
  INSERT INTO Contas (email, nome, senha, tipoConta) VALUES ('jojo@gmail.com','Jonathan','1234','user')

  INSERT INTO Contas (email, nome, senha, tipoConta)
