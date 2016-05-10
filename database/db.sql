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
	address VARCHAR(50) NOT NULL,
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
	priceToPublic NUMERIC(5,2) NOT NULL,
	percentToNS INTEGER NOT NULL,
	PRIMARY KEY(idMagRelase, magNumber),
	FOREIGN KEY(idMagazine) REFERENCES magazines(idMag)
);

CREATE TABLE newsStands
(
	idNewsStand INTEGER NOT NULL AUTO_INCREMENT,
	businessName VARCHAR(50) NOT NULL,
	piva VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
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

CREATE TABLE tasks
(
	idTask INTEGER NOT NULL AUTO_INCREMENT,
	taskName VARCHAR(50),
	nCopies INTEGER NOT NULL,
	typeTask ENUM ("deliver","returner") NOT NULL,
	idMagRelase INTEGER NOT NULL,
	idNewsStand INTEGER NOT NULL,
	idWorker INTEGER NOT NULL,
	idJob INTEGER NOT NULL,
	PRIMARY KEY(idTask),
	FOREIGN KEY(idNewsStand) REFERENCES newsStands(idNewsStand),
	FOREIGN KEY(idWorker) REFERENCES workers(idWorker),
	FOREIGN KEY(idJob) REFERENCES jobs(idJob),
	FOREIGN KEY(idMagRelase) REFERENCES magRelases(idMagRelase)
);


/*END TABLES*/


/*INSERT*/

INSERT INTO locations VALUES (1,"Italy","Trentino","Trento","Arco","38062"),(2,"Germany","Geneva","Geneva","Vernier","1214");

INSERT INTO phoneNumbers VALUES (1,"0464-510001"),(2,"0464-510002"),(3,"004122-123652"),(4,"0464-511919"),(5,"0464-510003"),(6,"0464-510004"),(7,"0464-510005");

INSERT INTO workers VALUES (1,"white","jack","whitej@domain.com","1980-02-01","Chemin De-Sales 3",2,3),(2,"rossi","mario","marior@domain.com","1979-03-10","Via Castello 1",1,2),(3,"bianchi","luca","bianchil@domain.com","1979-10-11","via chiesa 2",1,1),(4,"verdi","fabio","fabiov@domain.com","1962-11-16","Via Segantini 1",1,4),(5,"rossini","daniele","danieler@domain.com","1992-10-05","via italia5",1,7);

INSERT INTO magazines VALUES (1,"La Busa","monthly",4),(2,"La Befusa","monthly",1);

INSERT INTO magRelases VALUES (1,1,53,"2016-04-01",2,50),(2,1,54,"2016-05-01",2,50);

INSERT INTO newsStands VALUES (1,"tabacchino arco","piva000001","Via Mantova 1",1,5,2),(2,"news stand genevas","piva000002","Chemin De-Sales 3",2,6,3);

INSERT INTO jobs VALUES (1,"Consegna numero aprile","2016-04-02"),(2,"Consegna numero maggio","2016-05-01");

INSERT INTO tasks VALUES (1,"deliver may copies",35,"deliver",2,1,5,2),(2,"deliver may copies",10,"deliver",2,2,5,2),(3,"get april copies back",8,"returner",1,1,5,2);

/*END INSERT*/


/*QUERIES*/

/*END QUERIES*/


/*PROCEDURES*/
DELIMITER $$
CREATE PROCEDURE showtask(_taskType VARCHAR(50))
BEGIN
	SELECT workers.lastname, workers.name, newsStands.businessName,locations.city, newsStands.address, tasks.nCopies, tasks.typeTask, jobs.idJob, jobs.jobName, magRelases.magNumber AS mag_number FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN jobs ON jobs.idJob=tasks.idJob JOIN magRelases ON magRelases.idMagRelase=tasks.idMagRelase where tasks.typeTask=_taskType;

END $$
DELIMITER ;
/*END FUNCTIONS*/

/*USERS*/
CREATE USER 'guest'@'%' IDENTIFIED BY 'guest';
GRANT SELECT, EXECUTE ON distributor.* TO 'guest'@'%';
/*END USERS*/










