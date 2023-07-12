CREATE table users(
id int auto_increment primary key,
name varchar(20) not null unique,
password varchar(20) not null
);
insert into users (name, password) values ('pan', 'senha');
select id, name, MD5(password) as hashed_password from users;