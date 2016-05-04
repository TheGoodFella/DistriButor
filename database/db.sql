DROP DATABASE IF EXISTS DISTRIBUTOR;
CREATE DATABASE DISTRIBUTOR;
USE DISTRIBUTOR;

/*TABLES*/

CREATE TABLE locations
(
	idLocation INTEGER NOT NULL AUTO_INCREMENT,
	country VARCHAR(50) NOT NULL,
	region VARCHAR(50) NOT NULL,
	province VARCHAR(50) NOT NULL,
	city VARCHAR(50) NOT NULL,
	zipCode VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	PRIMARY KEY(idLocation)
);

CREATE TABLE phoneNumbers
(
	idPhone INTEGER NOT NULL AUTO_INCREMENT,
	phone VARCHAR(50) NOT NULL,
	PRIMARY KEY(idPhone)
);

CREATE TABLE workers
(
	idWorker INTEGER NOT NULL AUTO_INCREMENT,
	lastname VARCHAR(50) NOT NULL,
	name VARCHAR(50) NOT NULL,
	email VARCHAR(50),
	dateOfBirth DATE NOT NULL,
	idLocation INTEGER NOT NULL,
	idPhone INTEGER NOT NULL,
	PRIMARY KEY(idWorker),
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation),
	FOREIGN KEY(idPhone) REFERENCES phoneNumbers(idPhone)
);

CREATE TABLE magazines
(
	idMag INTEGER NOT NULL AUTO_INCREMENT,
	title VARCHAR(50) NOT NULL,
	periodicity ENUM ("daily","monthly") NOT NULL,
	idOwner INTEGER NOT NULL,
	PRIMARY KEY(idMag),
	FOREIGN KEY(idOwner) REFERENCES workers(idWorker)
);

CREATE TABLE magRelases
(
	idMagRelase INTEGER NOT NULL AUTO_INCREMENT,
	idMagazine INTEGER NOT NULL,
	magNumber INTEGER NOT NULL,
	dateRelase DATE NOT NULL,
	PRIMARY KEY(idMagRelase, magNumber),
	FOREIGN KEY(idMagazine) REFERENCES magazines(idMag)
);

CREATE TABLE newsStands
(
	idNewsStand INTEGER NOT NULL AUTO_INCREMENT,
	businessName VARCHAR(50) NOT NULL,
	piva VARCHAR(50) NOT NULL,
	idLocation INTEGER NOT NULL,
	idPhone INTEGER NOT NULL,
	idOwner INTEGER NOT NULL,
	PRIMARY KEY(idNewsStand,piva),
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation),
	FOREIGN KEY(idPhone) REFERENCES phoneNumbers(idPhone),
	FOREIGN KEY(idOwner) REFERENCES workers(idWorker)
);

CREATE TABLE jobs
(
	idJob INTEGER NOT NULL AUTO_INCREMENT,
	jobName VARCHAR(50),
	_date DATE NOT NULL,
	PRIMARY KEY(idJob)
);

CREATE TABLE magsInvolved
(
	idMagsInv INTEGER NOT NULL,
	nCopies INTEGER NOT NULL,
	idMagRelase INTEGER NOT NULL,
	typeTask ENUM ("deliver","returner") NOT NULL,
	PRIMARY KEY(idMagsInv),
	FOREIGN KEY(idMagRelase) REFERENCES magRelases(idMagRelase)
);

CREATE TABLE tasks
(
	idTask INTEGER NOT NULL AUTO_INCREMENT,
	taskName VARCHAR(50),
	idNewsStand INTEGER NOT NULL,
	idWorker INTEGER NOT NULL,
	idJob INTEGER NOT NULL,
	idMagsInv INTEGER NOT NULL,
	PRIMARY KEY(idTask),
	FOREIGN KEY(idNewsStand) REFERENCES newsStands(idNewsStand),
	FOREIGN KEY(idWorker) REFERENCES workers(idWorker),
	FOREIGN KEY(idJob) REFERENCES jobs(idJob),
	FOREIGN KEY(idMagsInv) REFERENCES magsInvolved(idMagsInv)
);


/*END TABLES*/


/*INSERT*/

INSERT INTO locations VALUES (1,"Italy","Trentino","Trento","Arco","38062","Via Mantova 1"),(2,"Italy","Trentino","Trento","Arco","38062","Via Marconi 2"),(3,"Germany","Geneva","Geneva","Vernier","1214","Chemin De-Sales 3"),(4,"Italy","Trentino","Trento","Arco","38062","Via Segantini 1"),(5,"Italy","Trentino","Trento","Arco","38062","Via Castello 1"),(6,"Italy","Trentino","Trento","Arco","38062","Via Chiesa 2");

INSERT INTO phoneNumbers VALUES (1,"0464-510001"),(2,"0464-510002"),(3,"004122-123652"),(4,"0464-511919"),(5,"0464-510003"),(6,"0464-510004"),(7,"0464-510005");

INSERT INTO workers VALUES (1,"white","jack","whitej@domain.com","1980-02-01",3,3),(2,"rossi","mario","marior@domain.com","1979-03-10",1,2),(3,"bianchi","luca","bianchil@domain.com","1979-10-11",2,1),(4,"verdi","fabio","fabiov@domain.com","1962-11-16",4,4),(5,"rossini","daniele","danieler@domain.com","1992-10-05",6,7);

INSERT INTO magazines VALUES (1,"La Busa","monthly",4),(2,"La Befusa","monthly",1);

INSERT INTO magRelases VALUES (1,1,53,"2016-04-01"),(2,1,54,"2016-05-01");

INSERT INTO newsStands VALUES (1,"tabacchino arco","piva000001",1,5,2),(2,"tabacchino castello","piva000002",2,6,3);

INSERT INTO jobs VALUES (1,"Consegna numero aprile","2016-04-02"),(2,"Consegna numero maggio","2016-05-01");

INSERT INTO magsInvolved VALUES (1,35,2,"deliver"),(2,10,2,"deliver"),(3,9,1,"returner");

INSERT INTO tasks VALUES (1,"delivery",1,5,1,1),(2,"delivery",2,5,2,2),(3,"return",1,5,2,3);

/*END INSERT*/


/*QUERIES*/
/*show tasks delivering mags*/
select workers.lastname, workers.name, newsStands.businessName, locations.address AS newsStands_Address, magsInvolved.nCopies, magsInvolved.typeTask FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN magsInvolved ON magsInvolved.idMagsInv=tasks.idTask where magsInvolved.typeTask="deliver";

/*show tasks returning mag*/
select workers.lastname, workers.name, newsStands.businessName, locations.address AS newsStands_Address, magsInvolved.nCopies, magsInvolved.typeTask FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN magsInvolved ON magsInvolved.idMagsInv=tasks.idTask where magsInvolved.typeTask="returner";
/*END QUERIES*/


