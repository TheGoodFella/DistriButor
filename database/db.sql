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
	PRIMARY KEY(idLocation)
);

CREATE TABLE workers
(
	idWorker INTEGER NOT NULL AUTO_INCREMENT,
	lastname VARCHAR(50) NOT NULL,
	name VARCHAR(50) NOT NULL,
	email VARCHAR(50),
	dateOfBirth DATE NOT NULL,
	city VARCHAR(50) NOT NULL,
	zipCode VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	idLocation INTEGER NOT NULL,
	PRIMARY KEY(idWorker),
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation)
);

CREATE TABLE phoneNumbers
(
	idPhone INTEGER NOT NULL AUTO_INCREMENT,
	phone VARCHAR(50) NOT NULL,
	idWorker INTEGER NOT NULL,
	PRIMARY KEY(idPhone),
	FOREIGN KEY(idWorker) REFERENCES workers(idWorker)
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
	nameRelase VARCHAR(50),
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
	city VARCHAR(50) NOT NULL,
	zipCode VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	idLocation INTEGER NOT NULL,
	NewsStandPhoneN VARCHAR(50) NOT NULL,
	idOwner INTEGER NOT NULL,
	PRIMARY KEY(idNewsStand,piva),
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation),
	FOREIGN KEY(idOwner) REFERENCES workers(idWorker)
);

CREATE TABLE soldCopies
(
	idSoldCopies INTEGER NOT NULL AUTO_INCREMENT,
	nSoldCopies INTEGER NOT NULL,
	areInvoiced BOOLEAN NOT NULL,
	idMagRelase INTEGER NOT NULL,
	idNewsStand INTEGER NOT NULL,
	PRIMARY KEY(idSoldCopies),
	FOREIGN KEY(idMagRelase) REFERENCES magRelases(idMagRelase),
	FOREIGN KEY(idNewsStand) REFERENCES newsStands(idNewsStand)
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


/*TRIGGER*/
DELIMITER $

CREATE TRIGGER TRG_UPDATE_SOLDCOPIES BEFORE INSERT ON tasks FOR EACH ROW 
BEGIN 
	DECLARE _isReturn INTEGER;
	DECLARE _deliveredCopies INTEGER;
	IF (NEW.typeTask="returner") THEN
		SELECT tasks.nCopies FROM tasks WHERE tasks.idNewsStand=NEW.idNewsStand AND tasks.idMagRelase=NEW.idMagRelase AND tasks.typeTask="deliver" INTO _deliveredCopies;
		INSERT INTO soldCopies VALUES (NULL,(_deliveredCopies-NEW.nCopies),FALSE,NEW.idMagRelase,NEW.idNewsStand);
	END IF;
END $

DELIMITER ;
/*END TRIGGER*/


/*INSERT*/

INSERT INTO locations VALUES (1,"Italy","Trentino","Trento"),(2,"Germany","Geneva","Geneva");

INSERT INTO workers VALUES (1,"white","jack","whitej@domain.com","1980-02-01","Vernier","1214","Chemin De-Sales 3",2),(2,"rossi","mario","marior@domain.com","1979-03-10","Arco","38062","Via Castello 1",1),(3,"bianchi","luca","bianchil@domain.com","1979-10-11","Arco","38062","via chiesa 2",1),(4,"verdi","fabio","fabiov@domain.com","1962-11-16","Arco","38062","Via Segantini 1",1),(5,"rossini","daniele","danieler@domain.com","1992-10-05","Arco","38062","via italia5",1);

INSERT INTO phoneNumbers VALUES (1,"0464-510001",3),(2,"0464-510002",2),(3,"004122-123652",1),(4,"0464-511919",4),(7,"0464-510005",5);

INSERT INTO magazines VALUES (1,"La Busa","monthly",4),(2,"La Befusa","monthly",1);

INSERT INTO magRelases VALUES (1,1,53,"2016-04-01","April number",2,50),(2,1,54,"2016-05-01","May april",2,50);

INSERT INTO newsStands VALUES (1,"tabacchino arco","piva000001","Arco","38062","Via Mantova 1",1,"0464-510003",2),(2,"news stand genevas","piva000002","Arco","38062","Chemin De-Sales 3",2,"0464-510004",3);

INSERT INTO jobs VALUES (1,"Consegna numero aprile","2016-04-02"),(2,"Consegna numero maggio","2016-05-01");

INSERT INTO tasks VALUES (1,"deliver may copies",35,"deliver",2,1,5,2),(2,"deliver may copies",10,"deliver",2,2,5,2),(3,"deliver april copies",10,"deliver",1,1,5,1),(4,"get april copies back",8,"returner",1,1,5,2);

/*END INSERT*/


/*PROCEDURES*/
DELIMITER $$

CREATE PROCEDURE showtask(_taskType VARCHAR(50))
BEGIN
	SELECT workers.lastname, workers.name, newsStands.businessName,newsStands.city, newsStands.address, tasks.nCopies, tasks.typeTask, tasks.taskName, jobs.idJob, jobs.jobName, magRelases.magNumber AS mag_number FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN jobs ON jobs.idJob=tasks.idJob JOIN magRelases ON magRelases.idMagRelase=tasks.idMagRelase where tasks.typeTask=_taskType;

END $$

CREATE PROCEDURE showSoldCopies()
BEGIN
	SELECT newsStands.businessName, soldCopies.nSoldCopies, magRelases.nameRelase,magRelases.magNumber, IF(soldCopies.areInvoiced=1,"true","false") AS areInvoiced FROM soldCopies JOIN newsStands ON soldCopies.idNewsStand=newsStands.idNewsStand JOIN magRelases ON soldCopies.idMagRelase=magRelases.idMagRelase;
END $$

CREATE PROCEDURE allProvince()
BEGIN
	SELECT DISTINCT locations.province FROM locations ORDER BY(locations.province);
END $$

CREATE PROCEDURE workerPhoneNumbers()
BEGIN
	SELECT workers.lastname,workers.name, phoneNumbers.phone FROM workers JOIN phoneNumbers ON workers.idWorker=phoneNumbers.idWorker;
END $$

CREATE PROCEDURE allOwners()
BEGIN
	SELECT DISTINCT workers.lastname, workers.name FROM workers ORDER BY(workers.lastname);
END $$

CREATE PROCEDURE allWorkers()
BEGIN
	SELECT DISTINCT workers.lastname, workers.name,workers.dateOfBirth,workers.city,workers.zipCode,workers.address,locations.province FROM workers JOIN locations ON workers.idLocation=locations.idLocation ORDER BY(workers.lastname);
END $$

CREATE PROCEDURE test()
BEGIN
declare _x INTEGER;
SELECT locations.idLocation FROM locations WHERE idLocation=1 into _x;
	IF(_x = NULL) THEN SELECT "hello"; END IF;

END $$

CREATE PROCEDURE workersPhoneNumber()
BEGIN
	SELECT  phoneNumbers.phone, workers.lastname, workers.name FROM workers JOIN phoneNumbers ON workers.idWorker=phoneNumbers.idWorker ORDER BY(workers.lastname);
END $$

DELIMITER ;
/*END PROCEDURES*/


/*FUNCTIONS*/

DELIMITER $$

CREATE FUNCTION checkLogIn
(

)
RETURNS INTEGER /*1: you are logged in if you can get 1*/
BEGIN
	RETURN 1;
END $$

CREATE FUNCTION insertLocation
(
	_country VARCHAR(50),
	_region VARCHAR(50),
	_province VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists*/
BEGIN
	
	IF EXISTS(SELECT * FROM locations
	WHERE UPPER(locations.country)=UPPER(_country) AND UPPER(locations.province) = UPPER(_province)) THEN
		RETURN 0;
	END IF;
	
	INSERT INTO locations VALUES (NULL,_country,_region,_province);
	
	RETURN 1;
END $$

CREATE FUNCTION insertPhoneNumber
(
	_phoneN VARCHAR(50),
	_lastnameOwner VARCHAR(50),
	_nameOwner VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: owner doesn't exists*/
BEGIN
	DECLARE _idOwn INTEGER;
	
	IF EXISTS(SELECT * FROM phoneNumbers
	WHERE phoneNumbers.phone = _phoneN) THEN
		RETURN 0;
	END IF;
	
	SELECT workers.idWorker FROM workers WHERE workers.lastname=_lastnameOwner AND workers.name=_nameOwner INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 2;
	END IF;
	
	IF(_idOwn > 0) THEN
	
		INSERT INTO phoneNumbers VALUES (NULL, _phoneN, _idOwn);
		RETURN 1;
	END IF;
END $$

CREATE FUNCTION insertWorker
(
	_lastname VARCHAR(50),
	_name VARCHAR(50),
	_email VARCHAR(50),
	_dateOfBirth VARCHAR(10),
	_province VARCHAR(50),
	_city VARCHAR(50),
	_zipCode VARCHAR(50),
	_address VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: province doesn't exists*/
BEGIN
	DECLARE _idloc INTEGER;
	
	IF EXISTS(SELECT * FROM workers
	WHERE workers.lastname = _lastname AND workers.name = _name) THEN
		RETURN 0;
	END IF;
	
	SELECT locations.idLocation FROM locations WHERE locations.province=_province INTO _idloc;
	
	SELECT IFNULL(_idloc,-1) INTO _idloc; /*if exists is null, return -1*/
	
	IF(_idloc = -1 ) THEN
		RETURN 2;
	END IF;
	
	IF (_idloc > 0) THEN
		INSERT INTO workers VALUES (NULL, _lastname,_name,_email,_dateOfBirth,_city,_zipCode,_address,_idloc);
		RETURN 1;
	END IF;
	
END $$

CREATE FUNCTION insertNewsStand
(
	_businessName VARCHAR(50),
	_piva VARCHAR(50),
	_city VARCHAR(50),
	_zipCode VARCHAR(10),
	_address VARCHAR(50),
	_province VARCHAR(50),
	_newsstandPhone VARCHAR(50),
	_lastnameOwner VARCHAR(50),
	_nameOwner VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: province doesn't exists, 3: owner doesn't exists*/
BEGIN
	DECLARE _idloc INTEGER;
	DECLARE _idOwn INTEGER;
	
	IF EXISTS(SELECT * FROM newsStands
	WHERE newsStands.businessName = _businessName AND newsStands.piva=_piva) THEN
		RETURN 0;
	END IF;
	
	SELECT locations.idLocation FROM locations WHERE locations.province=_province INTO _idloc;
	SELECT IFNULL(_idloc, -1) INTO _idloc; /*if province does not exists, return -1*/
	IF(_idloc = -1 ) THEN
		RETURN 2;
	END IF;
	
	SELECT workers.idWorker FROM workers WHERE workers.lastname=_lastnameOwner AND workers.name=_nameOwner INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 3;
	END IF;
	
	IF (_idloc > 0 AND _idOwn > 0) THEN
		INSERT INTO newsStands VALUES (NULL,_businessName,_piva,_city,_zipCode,_address,_idloc,_newsstandPhone,_idOwn);
		RETURN 1;
	END IF;
	
END $$

CREATE FUNCTION insertMagazine
(
	_title VARCHAR(50),
	_periodicity VARCHAR(50),
	_lastnameOwner VARCHAR(50),
	_nameOwner VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: owner does not exist*/
BEGIN
	DECLARE _idOwn INTEGER;
	
	IF EXISTS(SELECT * FROM magazines
	WHERE magazines.title = _title) THEN
		RETURN 0;
	END IF;
	
	SELECT workers.idWorker FROM workers WHERE workers.lastname=_lastnameOwner AND workers.name=_nameOwner INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 2;
	END IF;
	
	INSERT INTO magazines VALUES (NULL,_title,_periodicity,_idOwn);
	
	RETURN 1;
END $$

DELIMITER ;

/*END FUNCTIONS*/


/*USERS*/
CREATE USER 'guest'@'%' IDENTIFIED BY 'guest';	

GRANT SELECT ON DISTRIBUTOR.* TO 'guest'@'%';

GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showtask TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showSoldCopies TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allProvince TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allOwners TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.workerPhoneNumbers TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allWorkers TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.workersPhoneNumber TO 'guest'@'%';

GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertLocation TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertPhoneNumber TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertWorker TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertNewsStand TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.checkLogIn TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertMagazine TO 'guest'@'%';
/*END USERS*/









