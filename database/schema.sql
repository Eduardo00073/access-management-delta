create table Usuario
( 
	idUsuario int identity(1,1) not null primary key,
	Matricula_Acesso varchar(6) not null,
	Senha varchar(16) not null,
	Nome varchar(45) not null,
	Permissao bit not null
);


create table Computador
( 
	idComputador int identity(1,1) not null primary key,
	Laboratorio varchar(50) not null,
	Posicao int not null,
	Nome varchar(45) not null
);


create table Acesso_Computador
( 
	idAcesso int identity(1,1) not null primary key,
	idComputador int not null,
	idUsuario int not null,
	data datetime not null,
	constraint fk_Computador foreign key(idComputador) references Computador(idComputador),
	constraint fk_Usuario foreign key(idUsuario) references Usuario(idUsuario)
);
