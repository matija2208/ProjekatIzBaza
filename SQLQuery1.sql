create table pinouts
(
	id integer primary key identity(1,1),
	broj_pinova integer not null
);

create table pin
(
	id integer primary key identity(1,1),
	naziv varchar(20) not null,
	opis varchar(500),
	pinNo integer not null,
	pinout integer not null references pinouts(id)
);

create table kategorije
(
	id integer primary key identity(1,1),
	naziv varchar(20),
);
create table podkategorije
(
	id integer primary key identity(1,1),
	naziv varchar(20),
	idKategorije integer not null references kategorije(id)
);

create table cipovi
(
	id integer primary key identity(1,1),
	sifra varchar(30) not null,
	opis varchar(500) not null,
	pdf varchar(1000) not null,
	kolicina integer default 0,
	pinout integer not null references pinouts(id),
	idKategorije integer not null references kategorije(id),
	idPodkategorije integer not null references podkategorije(id)
);

