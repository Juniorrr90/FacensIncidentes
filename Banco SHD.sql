use SHD

create table tb_usuario(
	usuario varchar(20) primary key,
	nome varchar(50) not null,
	senha varchar(10) not null,
	email varchar(30),
	id_unidade int not null,
	nivel int not null
	)

create table tb_unidade(
	id_unidade int identity primary key,
	nome varchar(60) not null,
	endereco varchar(60) not null,
	bairro varchar(30) not null,
	telefone varchar(10) not null,
	cod_cie int,
	email varchar(60)
	)

create table tb_chamados(
	id_chamado int identity primary key,
	id_unidade int not null,
	dtabertura datetime not null,
	estado varchar(10) not null,
	dtatendimento datetime not null,
	problema varchar(1000) not null,
	solucao varchar(1000) not null,
	id_usuario int not null,
	id_tecnico int
	)

select * from tb_usuario