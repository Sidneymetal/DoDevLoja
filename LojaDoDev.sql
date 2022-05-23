CREATE TABLE Pedido(
  id_Pedido INTEGER PRIMARY KEY,
  produtos VARCHAR (300),
  valor_Total DECIMAL,
  status_Pedido VARCHAR (300),
  dada_Pedito DATE,
  id_produto INTEGER,
  id_admin INTEGER
);
CREATE TABLE Usuario(
  id_Usuario INTEGER PRIMARY KEY,
  nome VARCHAR (300),
  email VARCHAR (300),
  senha VARCHAR (20)
);
CREATE TABLE Cliente(
  id_Cliente INTEGER PRIMARY KEY,
  nome VARCHAR(300),
  cpf VARCHAR (11),
  endereco VARCHAR (300)
);
CREATE TABLE Admin(
  id_Admin INTEGER PRIMARY KEY,
  cnpj VARCHAR (11),
  id_cliente INTEGER,
  id_usuario INTEGER
);
CREATE TABLE Mouse(
  id_Mouse INTEGER PRIMARY KEY,
  dpi BOOLEAN
);
CREATE TABLE Teclado(
  id_Teclado INTEGER PRIMARY KEY,
  mecanico BOOLEAN 
);
CREATE TABLE Headset(
  id_Headset INTEGER PRIMARY KEY,
  surround BOOLEAN 
);
CREATE TABLE Produto(
  id_Produto INTEGER PRIMARY KEY,
  nome VARCHAR (300),
  marca VARCHAR (300),
  descricao VARCHAR (300),
  valor_Produto DECIMAL,
  estoque INTEGER,
  id_teclado INTEGER,
  id_mouse INTEGER,
  id_headset INTEGER
);

ALTER TABLE Pedido ADD FOREIGN KEY (id_produto) REFERENCES Produto(id_produto);
ALTER TABLE Pedido ADD FOREIGN KEY (id_adm) REFERENCES ADMIN(id_admin);
ALTER TABLE ADMIN ADD FOREIGN KEY (id_cliente) REFERENCES Usuario(id_Cliente);
ALTER TABLE ADMIN ADD FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario);
ALTER TABLE Produto ADD FOREIGN KEY (id_mouse) REFERENCES Mouse(id_mouse);
ALTER TABLE Produto ADD FOREIGN KEY (id_teclado) REFERENCES Teclado(id_Teclado);
ALTER TABLE Produto ADD FOREIGN KEY (id_headset) REFERENCES Headset(id_headset);

