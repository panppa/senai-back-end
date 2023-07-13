create database vendas;

use vendas;


create table clientes (
  id int primary key auto_increment,
  nome varchar (30),
  email varchar (50),
  telefone varchar (15),
  endereco varchar (50)
);

create table pessoa_fisica (
  cliente_id int primary key,
  cpf varchar (11),
  rg varchar (15),
 foreign key (cliente_id) references clientes(id)
);

create table pessoa_juridica (
  cliente_id int primary key,
  cnpj varchar (14),
  ie varchar (15),
 foreign key (cliente_id) references clientes(id)
);


create table vendas (
  id int primary key auto_increment,
  cliente_id int,
  valor_compra float,
  valor_imposto float,
  valor_total float,
  foreign key (cliente_id) references clientes(id)
);

-- Gpt pocando pra fazer insert 

-- Inserir clientes pessoa física
INSERT INTO clientes (nome, email, telefone, endereco)
VALUES
  ('Fulano Pessoa Física 1', 'fulano1@example.com', '123456789', 'Rua A'),
  ('Fulano Pessoa Física 2', 'fulano2@example.com', '987654321', 'Rua B'),
  ('Fulano Pessoa Física 3', 'fulano3@example.com', '555555555', 'Rua C');

-- Inserir clientes pessoa jurídica
INSERT INTO clientes (nome, email, telefone, endereco)
VALUES
  ('Empresa Jurídica 1', 'empresa1@example.com', '111111111', 'Av. X'),
  ('Empresa Jurídica 2', 'empresa2@example.com', '222222222', 'Av. Y'),
  ('Empresa Jurídica 3', 'empresa3@example.com', '333333333', 'Av. Z');

-- Inserir dados de pessoa física
INSERT INTO pessoa_fisica (cliente_id, cpf, rg)
VALUES
  (1, '12345678901', '0123456789'),
  (2, '98765432101', '9876543210'),
  (3, '55555555501', '5555555555');

-- Inserir dados de pessoa jurídica
INSERT INTO pessoa_juridica (cliente_id, cnpj, ie)
VALUES
  (4, '12345678901234', '1234567890'),
  (5, '98765432101234', '9876543210'),
  (6, '55555555501234', '5555555555');

-- Inserir vendas para pessoas físicas
INSERT INTO vendas (cliente_id, valor_compra, valor_imposto, valor_total)
VALUES
  (1, 100.00, 0.1, 110.00),
  (2, 200.00, 0.1, 220.00),
  (3, 300.00, 0.1, 330.00);

-- Inserir vendas para pessoas jurídicas
INSERT INTO vendas (cliente_id, valor_compra, valor_imposto, valor_total)
VALUES
  (4, 1000.00, 0.2, 1200.00),
  (5, 2000.00, 0.2, 2400.00),
  (6, 3000.00, 0.2, 3600.00);
  
  
