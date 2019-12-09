DROP TABLE variety_university
/*(είδη πανεπιστημείων)*/
CREATE TABLE variety_university
(
vID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
vName varchar(50) NOT NULL 
);

DROP TABLE university
/*(πανεπιστημεio ελλάδος)*/
CREATE TABLE university
(
unID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
unName varchar(50) NOT NULL, 
vID int NOT NULL,
	CONSTRAINT fk_university FOREIGN KEY(vID) REFERENCES variety_university (vID)
);

DROP TABLE school_sector
/*(σχολή-τομέας)*/
CREATE TABLE school_sector
(
sectID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
sectName varchar(50) NOT NULL,
unID int NOT NULL,
	CONSTRAINT fk_school_sector FOREIGN KEY(unID) REFERENCES university (unID)
);

DROP TABLE department
/*(τμήματα)*/
CREATE TABLE department
(
dID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
dName varchar(50) NOT NULL,
dCode int NOT NULL,/*κωδικο σχολης*/
durationStudy int NOT NULL,
dLink varchar(50) NOT NULL, /*how press link and new frame??? vb???*/
/*dBase int NOT NULL,*/
dNote varchar(1000) NOT NULL,
dCity varchar(20) NOT NULL,
sectID int NOT NULL,
	CONSTRAINT fk_department FOREIGN KEY(sectID) REFERENCES school_sector (sectID)
);

DROP TABLE scientific_field
/*(επιστημονικό πεδίο)*/
CREATE TABLE scientific_field
(
scienID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
scienName varchar(50) NOT NULL
);

DROP TABLE department_scientific_field
CREATE TABLE department_scientific_field
(
dID int NOT NULL,
scienID int NOT NULL,

	PRIMARY KEY (dID,scienID),
	
	CONSTRAINT fk1_department_scientific_field FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_scientific_field FOREIGN KEY(scienID) REFERENCES scientific_field (scienID)
);

DROP TABLE extra_courses
CREATE TABLE extra_courses
(
extraID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
extraName varchar(50) NOT NULL
);

DROP TABLE department_extra_courses
CREATE TABLE department_extra_courses
(
dID int NOT NULL,
extraID int NOT NULL,
	
	PRIMARY KEY(dID,extraID),
	
	CONSTRAINT fk1_department_extra_courses FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_extra_courses FOREIGN KEY(extraID) REFERENCES extra_courses (extraID)
);

DROP TABLE direction
/*(κατευθυνση)*/
CREATE TABLE direction
(
directionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
directionName varchar(100) NOT NULL,
dID int NOT NULL,
	CONSTRAINT fk_direction FOREIGN KEY(dID) REFERENCES department (dID)
);

DROP TABLE postgraduate
/*(μεταπτυχειακά)*/
CREATE TABLE postgraduate
(
gradID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
gradName varchar(50) NOT NULL,
gradNote varchar(150) NOT NULL,
unID int NOT NULL,
	CONSTRAINT fk_postgraduate FOREIGN KEY(unID) REFERENCES university (unID)
);

DROP TABLE department_postgraduate
/*το χρειαζομαστε?????????*/
CREATE TABLE department_postgraduate
(
dID int NOT NULL,
gradID int NOT NULL,

	PRIMARY KEY(dID,gradID),
	
	CONSTRAINT fk1_department_postgraduate FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_postgraduate FOREIGN KEY(gradID) REFERENCES postgraduate (gradID)
	
);

DROP TABLE profession_job
/*(επάγγελμα)*/
CREATE TABLE profession_job
(
jobID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
jobName varchar(50) NOT NULL,
jobNote varchar(200) NOT NULL
);

DROP TABLE department_profession_job
CREATE TABLE department_profession_job
(
dID int NOT NULL,
jobID int NOT NULL,

	PRIMARY KEY(dID,jobID),
	
	CONSTRAINT fk1_department_profession_job FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_profession_job FOREIGN KEY(jobID) REFERENCES profession_job (jobID)
);

/*///////////bale insert*/

DROP TABLE professional_rightsNote
/* (επαγγελματικά δικαιώματα) */
CREATE TABLE professional_rightsNote
(
rID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
rName varchar(2000) NOT NULL
);

DROP TABLE department_professional_rightsNote
CREATE TABLE department_professional_rightsNote
(
dID int NOT NULL,
rID int NOT NULL,

	PRIMARY KEY(dID,rID),
	
	CONSTRAINT fk1_department_professional_rightsNote FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_professional_rightsNote FOREIGN KEY(rID) REFERENCES professional_rightsNote (rID)
);

DROP TABLE indicative_employment_places
/* (ενδεικτικοί χώροι απασχόλησης) */
CREATE TABLE indicative_employment_places
(
plID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
plName varchar(550) NOT NULL,
);

DROP TABLE department_indicative_employment_places
CREATE TABLE department_indicative_employment_places
(
dID int NOT NULL,
plID int NOT NULL,

	PRIMARY KEY(dID,plID),
	
	CONSTRAINT fk1_department_indicative_employment_places FOREIGN KEY(dID) REFERENCES department (dID),
	CONSTRAINT fk2_department_indicative_employment_places FOREIGN KEY(plID) REFERENCES indicative_employment_places (plID)
);

DROP TABLE base
/*βάσεις πανελληνίων*/
CREATE TABLE base
(
/*bID int NOT NULL IDENTITY(1,1) PRIMARY KEY,*/
bNum int NOT NULL,
bYear int NOT NULL,
dID int NOT NULL,

	PRIMARY KEY(dID,bYear),

	CONSTRAINT fk1_department FOREIGN KEY(dID) REFERENCES department (dID),

)

























