DROP DATABASE IF EXISTS DISTRIBUTOR;
CREATE DATABASE DISTRIBUTOR;
USE DISTRIBUTOR;

/*Why ON DELETE CASCADE? 'cause if you want to change something, you use UPDATE, not delete and re-insert*/

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
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation) ON DELETE CASCADE
);

CREATE TABLE phoneNumbers
(
	idPhone INTEGER NOT NULL AUTO_INCREMENT,
	phone VARCHAR(50) NOT NULL,
	idWorker INTEGER NOT NULL,
	PRIMARY KEY(idPhone),
	FOREIGN KEY(idWorker) REFERENCES workers(idWorker) ON DELETE CASCADE
);

CREATE TABLE periodicities
(
	idPeriodicity INTEGER NOT NULL AUTO_INCREMENT,
	periodicity VARCHAR(50) NOT NULL,
	PRIMARY KEY(idPeriodicity)
);

CREATE TABLE magazines
(
	idMag INTEGER NOT NULL AUTO_INCREMENT,
	title VARCHAR(50) NOT NULL,
	idPeriodicity INTEGER NOT NULL,
	idOwner INTEGER NOT NULL,
	PRIMARY KEY(idMag),
	FOREIGN KEY(idOwner) REFERENCES workers(idWorker) ON DELETE CASCADE,
	FOREIGN KEY(idPeriodicity) REFERENCES periodicities(idPeriodicity) ON DELETE CASCADE
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
	PRIMARY KEY(idMagRelase),
	FOREIGN KEY(idMagazine) REFERENCES magazines(idMag) ON DELETE CASCADE
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
	FOREIGN KEY(idLocation) REFERENCES locations(idLocation) ON DELETE CASCADE,
	FOREIGN KEY(idOwner) REFERENCES workers(idWorker) ON DELETE CASCADE
);

CREATE TABLE soldCopies
(
	idSoldCopies INTEGER NOT NULL AUTO_INCREMENT,
	nSoldCopies INTEGER NOT NULL,
	areInvoiced BOOLEAN NOT NULL,
	idMagRelase INTEGER NOT NULL,
	idNewsStand INTEGER NOT NULL,
	_dateInvoice DATE,
	PRIMARY KEY(idSoldCopies),
	FOREIGN KEY(idMagRelase) REFERENCES magRelases(idMagRelase) ON DELETE CASCADE,
	FOREIGN KEY(idNewsStand) REFERENCES newsStands(idNewsStand) ON DELETE CASCADE
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
	FOREIGN KEY(idNewsStand) REFERENCES newsStands(idNewsStand) ON DELETE CASCADE,
	FOREIGN KEY(idWorker) REFERENCES workers(idWorker) ON DELETE CASCADE,
	FOREIGN KEY(idJob) REFERENCES jobs(idJob) ON DELETE CASCADE,
	FOREIGN KEY(idMagRelase) REFERENCES magRelases(idMagRelase) ON DELETE CASCADE
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
		INSERT INTO soldCopies VALUES (NULL,(_deliveredCopies-NEW.nCopies),FALSE,NEW.idMagRelase,NEW.idNewsStand, NULL);
	END IF;
END $

DELIMITER ;
/*END TRIGGER*/

/*INSERT*/

INSERT INTO locations VALUES (1,"Italy","Trentino","Trento"),(2,"Germany","Geneva","Geneva");

INSERT INTO workers VALUES (1,"white","jack","whitej@domain.com","1980-02-01","Vernier","1214","Chemin De-Sales 3",2),(2,"rossi","mario","marior@domain.com","1979-03-10","Arco","38062","Via Castello 1",1),(3,"bianchi","luca","bianchil@domain.com","1979-10-11","Arco","38062","via chiesa 2",1),(4,"verdi","fabio","fabiov@domain.com","1962-11-16","Arco","38062","Via Segantini 1",1),(5,"rossini","daniele","danieler@domain.com","1992-10-05","Arco","38062","via italia5",1);

INSERT INTO phoneNumbers VALUES (1,"0464-510001",3),(2,"0464-510002",2),(3,"004122-123652",1),(4,"0464-511919",4),(7,"0464-510005",5);

INSERT INTO periodicities VALUES (1,"daily"),(2,"monthly");

INSERT INTO magazines VALUES (1,"La Busa",2,4),(2,"rivista2",2,1);

INSERT INTO magRelases VALUES (1,1,53,"2016-04-01","April number",2,50),(2,1,54,"2016-05-01","May number",2,50),(3,2,1,"2016-01-01","Jan number",2,50),(4,2,2,"2016-02-01","Feb number",2,50);

INSERT INTO newsStands VALUES (1,"tabacchino arco","piva000001","Arco","38062","Via Mantova 1",1,"0464-510003",2),(2,"news stand genevas","piva000002","Arco","38062","Chemin De-Sales 3",2,"0464-510004",3);

INSERT INTO jobs VALUES (1,"Consegna numero aprile","2016-04-02"),(2,"Consegna numero maggio","2016-05-01"),(3,"june job","2016-06-01");

INSERT INTO tasks VALUES (1,"deliver may copies",35,"deliver",2,1,5,2),(2,"deliver may copies",10,"deliver",2,2,5,2),(3,"deliver april copies",10,"deliver",1,1,5,1),(4,"get april copies back",8,"returner",1,1,5,2),(5,"get may copies back",5,"returner",2,2,5,3);

/*END INSERT*/

UPDATE soldCopies SET soldCopies.areInvoiced=1, soldCopies._dateInvoice=CURDATE() WHERE soldCopies.idMagRelase=2 AND soldCopies.idNewsStand=2;

/*PROCEDURES*/
DELIMITER $$

CREATE PROCEDURE showtaskByType(_taskType VARCHAR(50))
BEGIN
	SELECT workers.lastname, workers.name, newsStands.businessName,newsStands.city, newsStands.address, tasks.nCopies, tasks.typeTask, tasks.taskName, jobs.idJob, jobs.jobName, magRelases.magNumber AS mag_number FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN jobs ON jobs.idJob=tasks.idJob JOIN magRelases ON magRelases.idMagRelase=tasks.idMagRelase where tasks.typeTask=_taskType;

END $$

CREATE PROCEDURE showAllTasks()
BEGIN
	SELECT tasks.taskName, tasks.typeTask, tasks.nCopies, workers.lastname, workers.name, newsStands.businessName,newsStands.city, newsStands.address AS newsStandAddress, jobs.jobName, magRelases.magNumber AS mag_number FROM tasks JOIN workers ON tasks.idWorker=workers.idWorker JOIN newsStands ON
tasks.idNewsStand=newsStands.idNewsStand JOIN locations ON locations.idLocation=newsStands.idLocation JOIN jobs ON jobs.idJob=tasks.idJob JOIN magRelases ON magRelases.idMagRelase=tasks.idMagRelase;

END $$

CREATE PROCEDURE showSoldCopies()
BEGIN
	SELECT newsStands.businessName, soldCopies.nSoldCopies, magRelases.nameRelase,magRelases.magNumber, IF(soldCopies.areInvoiced=1,"true","false") AS areInvoiced, soldCopies._dateInvoice AS invoiceDate FROM soldCopies JOIN newsStands ON soldCopies.idNewsStand=newsStands.idNewsStand JOIN magRelases ON soldCopies.idMagRelase=magRelases.idMagRelase;
END $$

CREATE PROCEDURE showSoldCopiesInvoiced(_invoiced INTEGER) /*1 to show invoiced copies, 0 to show not invoiced copies*/
BEGIN
	SELECT newsStands.businessName, soldCopies.nSoldCopies, magRelases.nameRelase,magRelases.magNumber, IF(soldCopies.areInvoiced=1,"true","false") AS areInvoiced, soldCopies._dateInvoice AS invoiceDate  FROM soldCopies JOIN newsStands ON soldCopies.idNewsStand=newsStands.idNewsStand JOIN magRelases ON soldCopies.idMagRelase=magRelases.idMagRelase WHERE soldCopies.areInvoiced=_invoiced;
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
DECLARE _x INTEGER;
SELECT locations.idLocation FROM locations WHERE idLocation=1 into _x;
	IF(_x = NULL) THEN SELECT "hello"; END IF;

END $$

CREATE PROCEDURE workersPhoneNumber()
BEGIN
	SELECT  phoneNumbers.phone, workers.lastname, workers.name FROM workers JOIN phoneNumbers ON workers.idWorker=phoneNumbers.idWorker ORDER BY(workers.lastname);
END $$

CREATE PROCEDURE allMagazines()
BEGIN
	SELECT magazines.title, periodicities.periodicity, workers.lastname AS lastnameOwner,workers.name AS nameOwner FROM magazines JOIN periodicities ON magazines.idPeriodicity=periodicities.idPeriodicity JOIN workers ON magazines.idOwner=workers.idWorker;
END $$

CREATE PROCEDURE allPeriods()
BEGIN
	SELECT periodicities.periodicity FROM periodicities;
END $$

CREATE PROCEDURE allMagazinesName()
BEGIN
	SELECT magazines.title FROM magazines;
END $$

CREATE PROCEDURE allMagRelases()
BEGIN
	SELECT magazines.title,magRelases.magNumber,magRelases.dateRelase,magRelases.nameRelase,magRelases.priceToPublic, magRelases.percentToNS FROM magRelases JOIN magazines ON magRelases.idMagazine=magazines.idMag;
END $$

CREATE PROCEDURE allLocations()
BEGIN
	SELECT locations.country,locations.region,locations.province FROM locations;
END $$

CREATE PROCEDURE allJobs()
BEGIN
	SELECT jobs.jobName,jobs._date AS JobDate FROM jobs;
END $$

CREATE PROCEDURE allNewsstands()
BEGIN
	SELECT newsStands.businessName,newsStands.piva,newsStands.zipCode,newsStands.address,newsStands.NewsStandPhoneN,locations.country,locations.region,locations.province,newsStands.city,workers.lastname,workers.name
	FROM newsStands JOIN locations ON newsStands.idLocation=locations.idLocation JOIN workers ON newsStands.idOwner=workers.idWorker;
END $$

/*
CREATE FUNCTION jobExist
(
	_jobName VARCHAR(50),
	_jobDate VARCHAR(10)
)
*/

CREATE PROCEDURE tasksByJob(
	_jobName VARCHAR(50),
	_jobDate VARCHAR(10)
)
BEGIN
	DECLARE _idJob INTEGER;
	
	SELECT jobExist(_jobName,_jobDate) INTO _idJob;
	SELECT IFNULL(_idJob, -1) INTO _idJob; /*if job does not exists, return -1*/
	
	SELECT tasks.taskName,tasks.nCopies, tasks.typeTask,tasks.taskName, magRelases.magNumber,magazines.title,newsStands.businessName,newsStands.address,workers.lastname,workers.name,jobs.jobName,jobs._date
	FROM tasks
	JOIN magRelases ON tasks.idMagRelase=magRelases.idMagRelase
	JOIN magazines ON magRelases.idMagazine=magazines.idMag
	JOIN newsStands ON tasks.idNewsStand=newsStands.idNewsStand
	JOIN workers ON workers.idWorker=tasks.idWorker
	JOIN jobs ON jobs.idJob=tasks.idJob WHERE jobs.idJob=_idJob;
END $$

CREATE PROCEDURE relaseNumbersByMagName
(
	_magName VARCHAR(50)
)
BEGIN
	SELECT magRelases.magNumber FROM magRelases JOIN magazines ON magRelases.idMagazine=magazines.idMag AND magazines.title=_magName;
END $$

CREATE PROCEDURE allJobsByDate
(
	_JobDate VARCHAR(10)
)
BEGIN
	SELECT jobs.jobName FROM jobs WHERE jobs._date = _jobDate;
END $$

CREATE PROCEDURE allBusinessName()
BEGIN
	SELECT newsStands.businessName FROM newsStands;
END $$

CREATE PROCEDURE allTaskType()
BEGIN
	SELECT "deliver", "returner";
END $$

CREATE PROCEDURE allJobsDate()
BEGIN
	SELECT jobs._date FROM jobs ORDER BY(jobs._date);
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

CREATE FUNCTION locationExist
(
	_province VARCHAR(50)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT locations.idLocation FROM locations WHERE UPPER(locations.province) = UPPER(_province) INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertLocation
(
	_country VARCHAR(50),
	_region VARCHAR(50),
	_province VARCHAR(50),
	_type INTEGER,  /*0: insert,1:update,2:delete*/
	_id INTEGER
)
RETURNS INTEGER /*1: success, 0: already exists, 2:empty or null fields, 3: updated, 4:deleted*/
BEGIN
	DECLARE _idOwn INTEGER;
	IF(_type=1) 
	THEN 
		UPDATE locations SET locations.country=_country, locations.region=_region,locations.province=_province WHERE locations.idLocation=_id;
		RETURN 3;
	END IF;
	IF(_type=0) THEN
		IF NULLIF(_country, '') IS NULL THEN RETURN 2; END IF;
		IF NULLIF(_region, '') IS NULL THEN RETURN 2; END IF;
		IF NULLIF(_province, '') IS NULL THEN RETURN 2; END IF;
	
		IF (SELECT locationExist(_province) > 0) THEN RETURN 0; END IF; /*already exist*/
	
		INSERT INTO locations VALUES (NULL,_country,_region,_province);
	
		RETURN 1;
	END IF;
	
	IF(_type=2) THEN
		RETURN 4;
	END IF;
END $$

CREATE FUNCTION phoneExist
(
	_phoneN VARCHAR(50)
)
RETURNS INTEGER /*0: already exist, 1:not exist*/
BEGIN
	DECLARE _id INTEGER;
	
	SELECT phoneNumbers.idPhone FROM phoneNumbers WHERE phoneNumbers.phone = _phoneN INTO _id;
	
	RETURN _id;
END $$

CREATE FUNCTION insertPhoneNumber
(
	_phoneN VARCHAR(50),
	_lastnameOwner VARCHAR(50),
	_nameOwner VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: owner doesn't exists, 3:empty or null fields*/
BEGIN
	DECLARE _idOwn INTEGER;
	
	IF NULLIF(_phoneN, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_lastnameOwner, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_nameOwner, '') IS NULL THEN RETURN 3; END IF;
	
	IF (SELECT phoneExist(_phoneN) > 0) THEN RETURN 0; END IF; /*already exist*/
	
	SELECT workerExist(_lastnameOwner,_nameOwner) INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 2;
	END IF;
	
	IF(_idOwn > 0) THEN
	
		INSERT INTO phoneNumbers VALUES (NULL, _phoneN, _idOwn);
		RETURN 1;
	END IF;
END $$

CREATE FUNCTION workerExist
(
	_lastname VARCHAR(50),
	_name VARCHAR(50)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT workers.idWorker FROM workers WHERE workers.lastname = _lastname AND workers.name = _name INTO _id;
	RETURN _id;
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
RETURNS INTEGER /*1: success, 0: already exists, 2: province doesn't exists, 3: empty or null fields*/
BEGIN
	DECLARE _idloc INTEGER;
	
	IF NULLIF(_lastname, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_name, '') IS NULL THEN RETURN 3; END IF;
	/*mail not listed beacuse mail is not NOT NULL marked*/
	IF NULLIF(_dateOfBirth, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_province, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_city, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_zipCode, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_address, '') IS NULL THEN RETURN 3; END IF;
	
	IF (SELECT workerExist(_lastname,_name) > 0) THEN
		RETURN 0;
	END IF;
	
	SELECT locationExist(_province) INTO _idloc;
	
	SELECT IFNULL(_idloc,-1) INTO _idloc; /*if exists is null, return -1*/
	
	IF(_idloc = -1 ) THEN
		RETURN 2;
	END IF;
	
	IF (_idloc > 0) THEN
		INSERT INTO workers VALUES (NULL, _lastname,_name,_email,_dateOfBirth,_city,_zipCode,_address,_idloc);
		RETURN 1;
	END IF;
	
END $$

CREATE FUNCTION newsStandExist
(
	_businessName VARCHAR(50)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT newsStands.idNewsStand FROM newsStands WHERE newsStands.businessName = _businessName INTO _id;
	RETURN _id;
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
RETURNS INTEGER /*1: success, 0: already exist, 2: province doesn't exist, 3: owner doesn't exist, 4: empty or null fields*/
BEGIN
	DECLARE _idloc INTEGER;
	DECLARE _idOwn INTEGER;
	
	IF NULLIF(_businessName, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_piva, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_city, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_zipCode, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_address, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_province, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_newsstandPhone, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_lastnameOwner, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_nameOwner, '') IS NULL THEN RETURN 4; END IF;
	
	IF (SELECT newsStandExist(_businessName) > 0) THEN
		RETURN 0;
	END IF;
	
	SELECT locationExist(_province) INTO _idloc;
	SELECT IFNULL(_idloc, -1) INTO _idloc; /*if province does not exists, return -1*/
	IF(_idloc = -1 ) THEN
		RETURN 2;
	END IF;
	
	SELECT workerExist(_lastnameOwner,_nameOwner) INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 3;
	END IF;
	
	IF (_idloc > 0 AND _idOwn > 0) THEN
		INSERT INTO newsStands VALUES (NULL,_businessName,_piva,_city,_zipCode,_address,_idloc,_newsstandPhone,_idOwn);
		RETURN 1;
	END IF;
	
END $$

CREATE FUNCTION magazineExist
(
	_title VARCHAR(50)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT magazines.idMag FROM magazines WHERE magazines.title = _title INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertMagazine
(
	_title VARCHAR(50),
	_periodicity VARCHAR(50),
	_lastnameOwner VARCHAR(50),
	_nameOwner VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2: owner does not exist, 3:periodicity does not exist, 4:empty or null fields*/
BEGIN
	DECLARE _idOwn INTEGER;
	DECLARE _idPeriod INTEGER;
	
	IF NULLIF(_title, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_periodicity, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_lastnameOwner, '') IS NULL THEN RETURN 4; END IF;
	IF NULLIF(_nameOwner, '') IS NULL THEN RETURN 4; END IF;
	
	IF (SELECT magazineExist(_title) > 0) THEN
		RETURN 0;
	END IF;
	
	SELECT workerExist(_lastnameOwner,_nameOwner) INTO _idOwn;
	SELECT IFNULL(_idOwn, -1) INTO _idOwn; /*if owner does not exists, return -1*/
	if(_idOwn = -1) THEN 
		RETURN 2;
	END IF;
	
	SELECT periodExist(_periodicity) INTO _idPeriod;
	SELECT IFNULL(_idPeriod, -1) INTO _idPeriod; /*if owner does not exists, return -1*/
	if(_idPeriod = -1) THEN 
		RETURN 3;
	END IF;
	
	INSERT INTO magazines VALUES (NULL,_title,_idPeriod,_idOwn);
	
	RETURN 1;
END $$

CREATE FUNCTION periodExist
(
	_period VARCHAR(50)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT periodicities.idPeriodicity FROM periodicities WHERE UPPER(periodicities.periodicity)=UPPER(_period) INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertPeriod
(
	_period VARCHAR(50)
)
RETURNS INTEGER /*1: success, 0: already exists, 2:empty or null fields*/
BEGIN
	
	IF NULLIF(_period, '') IS NULL THEN RETURN 2; END IF;
	
	IF (SELECT periodExist(_period) > 0) THEN
		RETURN 0;
	END IF;
	
	INSERT INTO periodicities VALUES (NULL,_period);
	
	RETURN 1;
END $$

CREATE FUNCTION magRelaseExist
(
	_idMag INTEGER,
	_magNumber INTEGER
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT magRelases.idMagRelase FROM magRelases WHERE UPPER(magRelases.idMagazine)=UPPER(_idMag) AND UPPER(magRelases.magNumber) = UPPER(_magNumber) INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertMagRelase
(
	_magName VARCHAR(50),
	_magNumber INTEGER,
	_dateRelase VARCHAR(10),
	_nameRelase VARCHAR(50),
	_priceToPublic NUMERIC(5,2),
	_percentToNS INTEGER
)
RETURNS INTEGER /*1: success, 0: already exists, 2:magazine does not exist, 3:empty or null fields*/
BEGIN
	DECLARE _idMag INTEGER;
	
	IF NULLIF(_magName, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_magNumber, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_dateRelase, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_nameRelase, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_priceToPublic, '') IS NULL THEN RETURN 3; END IF;
	IF NULLIF(_percentToNS, '') IS NULL THEN RETURN 3; END IF;
	
	SELECT magazineExist(_magName) INTO _idMag;
	SELECT IFNULL(_idMag, -1) INTO _idMag; /*if magazine does not exists, return -1*/
	if(_idMag = -1) THEN 
		RETURN 2;
	END IF;
	
	IF (SELECT magRelaseExist(_idMag,_magNumber) > 0) THEN
		RETURN 0;
	END IF;
	
	INSERT INTO magRelases VALUES (NULL,_idMag,_magNumber,_dateRelase, _nameRelase,_priceToPublic,_percentToNS);
	
	RETURN 1;
END $$

/*
idJob INTEGER NOT NULL AUTO_INCREMENT,
	jobName VARCHAR(50),
	_date DATE NOT NULL,
	PRIMARY KEY(idJob)
*/

CREATE FUNCTION jobExist
(
	_jobName VARCHAR(50),
	_jobDate VARCHAR(10)
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT jobs.idJob FROM jobs WHERE UPPER(jobs.jobName)=UPPER(_jobName) AND UPPER(jobs._date) = UPPER(_jobDate) INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertJob
(
	_jobName VARCHAR(50),
	_jobDate VARCHAR(10)
)
RETURNS INTEGER /*1: success, 0: already exists, 2:empty or null fields*/
BEGIN
	IF NULLIF(_jobName, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_jobDate, '') IS NULL THEN RETURN 2; END IF;
	
	IF (SELECT jobExist(_jobName,_jobDate)) THEN
		RETURN 0;
	END IF;
	
	INSERT INTO jobs VALUES (NULL, _jobName,_jobDate);
	
	RETURN 1;
END $$


CREATE FUNCTION howManyJobs
(

)
RETURNS INTEGER /*return the amount of jobs*/
BEGIN
	DECLARE _nJobs INTEGER;
	SELECT COUNT(jobs.idJob) FROM jobs INTO _nJobs;
	RETURN _nJobs;
END $$

/*
idTask INTEGER NOT NULL AUTO_INCREMENT,
	taskName VARCHAR(50),
	nCopies INTEGER NOT NULL,
	typeTask ENUM ("deliver","returner") NOT NULL,
	idMagRelase INTEGER NOT NULL,
	idNewsStand INTEGER NOT NULL,
	idWorker INTEGER NOT NULL,
	idJob INTEGER NOT NULL,
	
idMagRelase INTEGER NOT NULL AUTO_INCREMENT,
	idMagazine INTEGER NOT NULL,
	magNumber INTEGER NOT NULL,
	dateRelase DATE NOT NULL,
	nameRelase VARCHAR(50),
	priceToPublic NUMERIC(5,2) NOT NULL,
	percentToNS INTEGER NOT NULL,
*/

CREATE FUNCTION taskExist
(
	_taskName VARCHAR(50),
	_idJob INTEGER,
	_idNS INTEGER
)
RETURNS INTEGER 
BEGIN
	DECLARE _id INTEGER;
	SELECT tasks.idTask FROM tasks WHERE UPPER(tasks.taskName)=UPPER(_taskName) AND UPPER(tasks.idJob)=UPPER(_idJob) AND UPPER(tasks.idNewsStand)=UPPER(_idNS)INTO _id;
	RETURN _id;
END $$

CREATE FUNCTION insertTask
(
	_taskName VARCHAR(50),
	_nCopies INTEGER,
	_typeTask VARCHAR(8),
	_magTitle VARCHAR(50), 	/*For MagRelase*/
	_magNumber INTEGER, 	/*For MagRelase*/
	_nsBusinessName VARCHAR(50), /*For NewsStands*/
	_lastname VARCHAR(50), 	/*For workers*/
	_name VARCHAR(50),		/*For workers*/
	_jobName VARCHAR(50), 	/*For jobs*/
	_jobDate VARCHAR(10)	/*For jobs*/
)
RETURNS INTEGER /*1: success, 0: already exists, 2:empty or null fields, 3:magRelase does not exist, 4:worker does not exist, 5:job does not exist, 6:newsstand does not exist, 7:magazine does not exist*/
BEGIN
	DECLARE _idMag INTEGER;
	DECLARE _idWorker INTEGER;
	DECLARE _idJob INTEGER;
	DECLARE _idNS INTEGER;

	IF NULLIF(_taskName, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_nCopies, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_typeTask, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_magTitle, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_magNumber, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_nsBusinessName, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_lastname, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_name, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_jobName, '') IS NULL THEN RETURN 2; END IF;
	IF NULLIF(_jobDate, '') IS NULL THEN RETURN 2; END IF;
	
	/*get the magRelases id*/
	SELECT magazineExist(_magTitle)	INTO _idMag;
	SELECT IFNULL(_idMag, -1) INTO _idMag; /*if magazine does not exists, return 7*/
	if(_idMag = -1) THEN 
		RETURN 7;
	END IF;
	SELECT magRelaseExist(_idMag,_magNumber) INTO _idMag;
	SELECT IFNULL(_idMag, -1) INTO _idMag; /*if magRelase does not exists, return 3*/
	if(_idMag = -1) THEN 
		RETURN 3;
	END IF;
	
	/*get the worker id*/
	SELECT workerExist(_lastname, _name) INTO _idWorker;
	SELECT IFNULL(_idWorker, -1) INTO _idWorker; /*if owner does not exists, return 4*/
	if(_idWorker = -1) THEN 
		RETURN 4;
	END IF;
	
	/*get the job id*/
	SELECT jobExist(_jobName, _jobDate) INTO _idJob;
	SELECT IFNULL(_idJob, -1) INTO _idJob; /*if owner does not exists, return 5*/
	if(_idJob = -1) THEN 
		RETURN 5;
	END IF;
	
	/*get the newsstand id*/
	SELECT newsStandExist(_nsBusinessName) INTO _idNS;
	SELECT IFNULL(_idNS, -1) INTO _idNS; /*if magazine does not exists, return 6*/
	if(_idNS = -1) THEN 
		RETURN 6;
	END IF;
	
	IF (SELECT taskExist(_taskName,_idJob,_idNS) > 0) THEN
		RETURN 0;
	END IF;
	
	INSERT INTO tasks VALUES (NULL,_taskName,_nCopies,_typeTask,_idMag,_idNS,_idWorker,_idJob);
	
	RETURN 1;
END $$

DELIMITER ;

/*END FUNCTIONS*/


/*USERS*/
CREATE USER 'guest'@'%' IDENTIFIED BY 'guest';	

GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showtaskByType TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showSoldCopies TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allProvince TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allOwners TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.workerPhoneNumbers TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allWorkers TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.workersPhoneNumber TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allMagazines TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allPeriods TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allMagazinesName TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allMagRelases TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allLocations TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.tasksByJob TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.relaseNumbersByMagName TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allJobsByDate TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allBusinessName TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allTaskType TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allJobsDate TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showAllTasks TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allJobs TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.allNewsstands TO 'guest'@'%';
GRANT EXECUTE ON PROCEDURE DISTRIBUTOR.showSoldCopiesInvoiced TO 'guest'@'%';

GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertLocation TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertPhoneNumber TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertWorker TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertNewsStand TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.checkLogIn TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertMagazine TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertPeriod TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertMagRelase TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertJob TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.howManyJobs TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.insertTask TO 'guest'@'%';
GRANT EXECUTE ON FUNCTION DISTRIBUTOR.locationExist TO 'guest'@'%';
/*END USERS*/









