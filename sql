--------------------------------------------------------
--  File created - Saturday-December-25-2021   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ADMIT_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTDB"."ADMIT_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 6 NOCACHE  NOORDER  NOCYCLE
--------------------------------------------------------
--  DDL for Sequence BILL_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTDB"."BILL_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 23 CACHE 20 NOORDER  NOCYCLE
--------------------------------------------------------
--  DDL for Sequence WARD_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTDB"."WARD_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE
--------------------------------------------------------
--  DDL for Table APPOINTMENT
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."APPOINTMENT" 
   (	"APPOINTMENTID" NUMBER(6,0) NOT NULL ENABLE, 
	"DOCTORID" VARCHAR2(6) NOT NULL ENABLE, 
	"APPOINTMENTDATE" DATE NOT NULL ENABLE, 
	"PATIENT_NAME" VARCHAR2(30) NOT NULL ENABLE, 
	"PATIENTID" VARCHAR2(6), 
	 CONSTRAINT "APPOINTMENT_PK" PRIMARY KEY ("APPOINTMENTID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE, 
	 CONSTRAINT "APPOINTMENT_FK" FOREIGN KEY ("DOCTORID")
	  REFERENCES "PROJECTDB"."DOCTOR" ("DOCTORID") ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Table BONUS
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."BONUS" 
   (	"EMPID" VARCHAR2(6), 
	"SAL" NUMBER, 
	"COMM" NUMBER
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Table DOCTOR
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."DOCTOR" 
   (	"DOCTORID" VARCHAR2(6), 
	"DEPT" VARCHAR2(400), 
	"SCHEDULE" VARCHAR2(600), 
	"EMPID" VARCHAR2(6), 
	"DETAILS" VARCHAR2(200), 
	 CONSTRAINT "PK_DOCTOR" PRIMARY KEY ("DOCTORID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE, 
	 CONSTRAINT "FK_EMPID" FOREIGN KEY ("EMPID")
	  REFERENCES "PROJECTDB"."EMPLOYEES" ("EMPID") ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Table PATIENT
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."PATIENT" 
   (	"PATIENTID" VARCHAR2(6) NOT NULL ENABLE, 
	"NAME" VARCHAR2(30) NOT NULL ENABLE, 
	"BLOODGROUP" VARCHAR2(3) NOT NULL ENABLE, 
	"WEIGHT" NUMBER(3,0) NOT NULL ENABLE, 
	"AGE" NUMBER(3,0) NOT NULL ENABLE, 
	"PHONENO" NUMBER(11,0) NOT NULL ENABLE, 
	"EMERGENCYCONTACT" NUMBER(11,0) NOT NULL ENABLE, 
	"ADDRESS" VARCHAR2(100) NOT NULL ENABLE, 
	"SICKNESS" VARCHAR2(100) NOT NULL ENABLE, 
	 CONSTRAINT "PATIENT_PK" PRIMARY KEY ("PATIENTID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Table TESTS
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."TESTS" 
   (	"TESTID" NUMBER(3,0), 
	"TESTNAME" VARCHAR2(60), 
	"AMOUNT" NUMBER(5,0)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Table WARD
--------------------------------------------------------

  CREATE TABLE "PROJECTDB"."WARD" 
   (	"WARDNO" NUMBER(3,0) NOT NULL ENABLE, 
	"STATUS" NUMBER(1,0) NOT NULL ENABLE, 
	 CONSTRAINT "WARD_PK" PRIMARY KEY ("WARDNO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
REM INSERTING into PROJECTDB.ADMIT
SET DEFINE OFF;
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0001',1,'Discharged','24-DEC-21',null,null,100,100);
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0002',2,'Discharged','24-Dec-2021','25-Dec-2021',null,1,1);
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0003',3,'Active','25-Dec-2021',null,null,3,2);
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0004',4,'Active','23-Dec-2021',null,'D-0001',4,3);
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0005',5,'Active','14-Dec-2021',null,'D-0002',5,4);
Insert into PROJECTDB.ADMIT (PATIENTID,WARDNO,STATUS,ADMISSIONDATE,DISCHARGEDATE,ASSIGNEDDOCTOR,BILLID,ADMISSIONID) values ('P-0001',1,'Active','24-Dec-2021',null,'D-0001',6,5);
REM INSERTING into PROJECTDB.APPOINTMENT
SET DEFINE OFF;
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (1,'D-0003',to_date('24-DEC-21','DD-MON-RR'),'Nishad Khan',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (5,'D-0005',to_date('07-NOV-21','DD-MON-RR'),'Nahin Nasir',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (2,'D-0003',to_date('24-DEC-21','DD-MON-RR'),'Khan Al Shahriar',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (4,'D-0002',to_date('08-NOV-21','DD-MON-RR'),'Abul Hashem','P-0003');
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (44,'D-0005',to_date('26-DEC-21','DD-MON-RR'),'Tomal',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (21,'D-0006',to_date('24-DEC-21','DD-MON-RR'),'Naser',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (3,'D-0003',to_date('05-NOV-21','DD-MON-RR'),'Shahriar Akib',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (41,'D-0006',to_date('25-DEC-21','DD-MON-RR'),'Nuzat',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (42,'D-0006',to_date('25-DEC-21','DD-MON-RR'),'Shahriar Akib',null);
Insert into PROJECTDB.APPOINTMENT (APPOINTMENTID,DOCTORID,APPOINTMENTDATE,PATIENT_NAME,PATIENTID) values (43,'D-0003',to_date('26-DEC-21','DD-MON-RR'),'Abir Khan',null);
REM INSERTING into PROJECTDB.BILL
SET DEFINE OFF;
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (100,0,'None','P-0001',0);
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (4,0,'None','P-0004',0);
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (5,0,'None','P-0005',0);
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (6,0,'None','P-0001',0);
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (1,4900,'--------------------------------------------------------------------------------------------------------------------------
Invoice
12/25/2021 2:34:16 AM       P-0002    Kayser Alam
--------------------------------------------------------------------------------------------------------------------------
1.Admission Charge    .2000
2.Ambulance Tarrif    .1500
3 Blood Group + Rh Factor     .600
4 Cross Matching     .800
','P-0002',0);
Insert into PROJECTDB.BILL (BILLID,AMOUNT,BILLDETAILS,PATIENTID,DUE) values (3,0,'None','P-0003',0);
REM INSERTING into PROJECTDB.BONUS
SET DEFINE OFF;
Insert into PROJECTDB.BONUS (EMPID,SAL,COMM) values ('E-0004',32000,8000);
Insert into PROJECTDB.BONUS (EMPID,SAL,COMM) values ('E-0001',140000,15000);
Insert into PROJECTDB.BONUS (EMPID,SAL,COMM) values ('E-0002',120000,12000);
Insert into PROJECTDB.BONUS (EMPID,SAL,COMM) values ('E-0004',32000,8000);
Insert into PROJECTDB.BONUS (EMPID,SAL,COMM) values ('E-0007',110000,12000);
REM INSERTING into PROJECTDB.CHARGES
SET DEFINE OFF;
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (6,'Emergency Ward',1000);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (3,'OT Charge',8000);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (5,'Ambulance Tarrif',1500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (7,'Labour Room',4500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (8,'Day Care Bed',1500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (9,'HDU',7500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (10,'CT HDU',8200);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (1,'Cabin Charge',3500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (4,'Consultant Fee',1500);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (11,'ICU Charge',9000);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (12,'CCU Charge',6000);
Insert into PROJECTDB.CHARGES (SERVICEID,SERVICENAME,AMOUNT) values (2,'Admission Charge',2000);
REM INSERTING into PROJECTDB.DOCTOR
SET DEFINE OFF;
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0003','Nurology','Sat,Mon,   6:00 PM to 8:00 PM','E-0005','Neurology Specialist');
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0004','Pediatrician','Sun,Tue,   4:00 PM to 6:00 PM','E-0006','DMC');
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0005','Medicine','Sun, Tuesday,Thursday: 7PM-9PM','E-0007',null);
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0007','Psychology','Sun,Mon,Tue,Wed,   10:30 PM to 5:30 PM','E-0012',null);
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0006','Medicine','Sat,Mon,Wed,   5:30 PM to 8:30 PM','E-0010',null);
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0001','Cardiology','Thursday:7PM-10PM','E-0001',null);
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0002','Medicine','Mon,Wed:7PM-9PM','E-0002',null);
Insert into PROJECTDB.DOCTOR (DOCTORID,DEPT,SCHEDULE,EMPID,DETAILS) values ('D-0008','Nurology','Tue,Thu,   6:0 PM to 8:0 PM','E-0013',null);
REM INSERTING into PROJECTDB.EMPLOYEES
SET DEFINE OFF;
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0003','Keya Akter','A+',65,28,1770544722,1681382754,'Nikunja 2, R#12,H#32. Dhaka','None',32000,'Receiptionist','21-FEB-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0004','Hinata Uzumaki','AB+',72,27,1811544745,1721382787,'uttara  S#12 R#2 H#36. Dhaka','None',32000,'Receiptionist','21-FEB-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0001','Dr Kayes Ahamed','O+',83,56,1736378988,1826378777,'Gulshan, Dhaka','None',140000,'Doctor','21-FEB-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0011','Nishad Khan','AB+',73,23,1812121956,1812121956,'Joydebpur,Gazipur','None',15000,'Ward Boy','03-Jan-2019');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0009','Hinata Hyuga','AB+',72,27,1811544745,1721382787,'uttara  S#12 R#2 H#36. Dhaka','None',32000,'Receiptionist','21-Feb-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0012','Nishad Khan','AB+',70,29,1812121956,1711228345,'Kuril,Dhaka','None',45000,'Doctor','24-Feb-2020');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0002','Col Abdul Hashem','B+',78,57,1715004752,1829382741,'Gulshan 2, R#12,H#32. Dhaka','None',120000,'Doctor','21-FEB-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0006','Rejaul Kabir','A+',75,49,1715628679,1965628666,'Uttara','None',95000,'Doctor','21-FEB-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0010','Kayser Ahamed','O+',66,56,1937264899,1637264822,'uttara','None',90000,'Doctor','21-Feb-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0005','Dr Kayser Kabir','O+',68,49,1685478752,1715478712,'uttara, Dhaka','None',90000,'Doctor','21-Feb-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0007','Dr Rayhan Abir','A-',75,57,1815628880,1665628223,'Khilkhet, Nikunja 2','None',110000,'Doctor','21-Feb-2021');
Insert into PROJECTDB.EMPLOYEES (EMPID,ENAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,MEDICALHISTORY,SALARY,DESIGNATION,JOINNINGDATE) values ('E-0013','Kayes Khan','AB+',68,28,1711223344,1711223344,'Sundarban.Khulna','KMC, MBBS, MS ( Neurosurgery
Specialist in neurosurgeon & spinal surgeon',35000,'Doctor','17-Mar-2021');
REM INSERTING into PROJECTDB.PATIENT
SET DEFINE OFF;
Insert into PROJECTDB.PATIENT (PATIENTID,NAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,SICKNESS) values ('P-0005','Niloy Sarker','AB+',69,26,1886378718,1961278742,'Dhanmondi, 32','Diarrhea');
Insert into PROJECTDB.PATIENT (PATIENTID,NAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,SICKNESS) values ('P-0004','Slam Mia','O+',59,47,1776278718,1376278720,'Kishorganj sadar','Dengue');
Insert into PROJECTDB.PATIENT (PATIENTID,NAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,SICKNESS) values ('P-0002','Kayser Alam','AB-',73,29,1786297471,1696297471,'Notunbazar, nurerchala','High Fever, Nausea');
Insert into PROJECTDB.PATIENT (PATIENTID,NAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,SICKNESS) values ('P-0003','Abul Hashem','AB+',72,58,1976278733,1876278428,'Badda, 82/34A, Dhaka ','Kidney Stone');
Insert into PROJECTDB.PATIENT (PATIENTID,NAME,BLOODGROUP,WEIGHT,AGE,PHONENO,EMERGENCYCONTACT,ADDRESS,SICKNESS) values ('P-0001','Sakib Ahmed','O+',67,27,1876298354,1274298354,'gulshan 2, 78/A','Fever,Cold');
REM INSERTING into PROJECTDB.SALGRADE
SET DEFINE OFF;
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (1,150000,200000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (2,120000,150000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (5,60000,75000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (3,100000,120000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (4,75000,100000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (6,40000,60000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (7,30000,40000);
Insert into PROJECTDB.SALGRADE (GRADE,LOSAL,HISAL) values (8,15000,30000);
REM INSERTING into PROJECTDB.TESTS
SET DEFINE OFF;
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (2,'Covid-19',3000);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (3,'ECG',200);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (4,' Blood Group + Rh Factor',600);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (5,' Cross Matching',800);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (6,' HBs Ag (Screening)',600);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (7,' Urine R/E',900);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (8,' Urine C/S',600);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (9,' HIV 1/2 (Screening)',700);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (10,'Dengue IgM',900);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (11,'Chikungunya Antibodies IgM & IgG',1200);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (12,'HBs Ag',1300);
Insert into PROJECTDB.TESTS (TESTID,TESTNAME,AMOUNT) values (1,'RBC',800);
REM INSERTING into PROJECTDB.USERS
SET DEFINE OFF;
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('A-0123','pass','Admin',1);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0005','1234','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0001','1234','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('E-0003','815789','Receptionist',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0003','489856','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0004','388945','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0007','561154','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('A-1234','804734','Admin',1);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('E-0004','743652','Receptionist',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0002','502926','Doctor',0);
Insert into PROJECTDB.USERS (USERID,PASSWORD,ROLE,STATUS) values ('D-0008','226555','Doctor',0);
REM INSERTING into PROJECTDB.WARD
SET DEFINE OFF;
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (1,1);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (3,1);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (9,0);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (5,1);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (7,1);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (4,1);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (6,0);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (2,0);
Insert into PROJECTDB.WARD (WARDNO,STATUS) values (8,0);
--------------------------------------------------------
--  DDL for Index PK_BILL
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTDB"."PK_BILL" ON "PROJECTDB"."BILL" ("BILLID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Index PK_DOCTOR
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTDB"."PK_DOCTOR" ON "PROJECTDB"."DOCTOR" ("DOCTORID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Index WARD_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTDB"."WARD_PK" ON "PROJECTDB"."WARD" ("WARDNO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Index PATIENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTDB"."PATIENT_PK" ON "PROJECTDB"."PATIENT" ("PATIENTID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Index ADMIT_CON
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTDB"."ADMIT_CON" ON "PROJECTDB"."ADMIT" ("ADMISSIONID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"
--------------------------------------------------------
--  DDL for Trigger APPOINMENT_LIMITER
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTDB"."APPOINMENT_LIMITER" 
Before Insert on APPOINTMENT
For Each Row
Declare
N number;
Begin
select count(*) into N from appointment where DOCTORID=:new.DOCTORID and APPOINTMENTDATE=:new.APPOINTMENTDATE;

if N>30 then
raise_application_error(-20205,'Appointment Limit Excceds, Try selecting another date');
end if;
end;
ALTER TRIGGER "PROJECTDB"."APPOINMENT_LIMITER" ENABLE
--------------------------------------------------------
--  DDL for Trigger BILLID_SEQ_TRIGGER
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTDB"."BILLID_SEQ_TRIGGER" 
BEFORE INSERT ON BILL
FOR EACH ROW
declare
d number(8);
BEGIN
if (:new.BILLID IS NULL) then 
Select BILL_SEQ.NEXTVAL into d from dual;
:new.BILLID :=d;
end if;
END;
ALTER TRIGGER "PROJECTDB"."BILLID_SEQ_TRIGGER" ENABLE
--------------------------------------------------------
--  DDL for Trigger BI_WARD
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTDB"."BI_WARD" 
  before insert on "WARD"               
  for each row  
begin   
    select "WARD_SEQ".nextval into :NEW.WARDNO from dual; 
end; 

ALTER TRIGGER "PROJECTDB"."BI_WARD" ENABLE
--------------------------------------------------------
--  DDL for Trigger EMPLOYEE_DELETE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTDB"."EMPLOYEE_DELETE" 
After Delete on EMPLOYEES
For Each Row
Declare 
did doctor.doctorid%type;
eid employees.empid%type;
des employees.designation%type;

Begin

if :old.designation='Doctor' then
select  doctorid into did from doctor where empid=:old.empid;
delete from users where userid=did;
elsif :old.designation='Receiptionist' then
delete from users where userid=:old.empid;
end if;
end;
ALTER TRIGGER "PROJECTDB"."EMPLOYEE_DELETE" ENABLE
--------------------------------------------------------
--  DDL for Trigger PATIENT_DISCHARGE_MONITOR
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTDB"."PATIENT_DISCHARGE_MONITOR" 
Before Update of status on Admit
FOR EACH ROW
Declare
dueAmount BILL.due%type;
Begin
select due into dueAmount  from bill where patientid=:old.patientid;
if dueAmount>0 then
       raise_application_error(-20202,'Patient has Due bill');

end if;
EXCEPTION
when no_data_found then
raise_application_error(-20204,'No data Found');
end;
ALTER TRIGGER "PROJECTDB"."PATIENT_DISCHARGE_MONITOR" ENABLE
--------------------------------------------------------
--  DDL for Procedure EMPLOYEES_INSERT_UPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "PROJECTDB"."EMPLOYEES_INSERT_UPDATE" (eno employees.empid%type, name employees.ename%type,bg employees.bloodgroup%type,wt employees.weight%type,ag employees.age%type,pno employees.phoneno%type,epno employees.emergencycontact%type,adr employees.address%type,mhistory employees.medicalhistory%type,sal employees.salary%type,des employees.designation%type, jDate employees.joinningdate%type)
is

begin

if(Valid_Emp(eno))then
Update employees set ename = name,bloodgroup=bg,weight=wt,age=ag,phoneno= pno,emergencycontact= epno,address= adr ,medicalhistory= mhistory,salary=sal,designation=des,joinningDate=jDate where empid =eno;
dbms_output.put_line('Updated');
else
Insert into employees values(eno,name,bg,wt,ag,pno,epno,adr,mhistory,sal,des,jDate);
dbms_output.put_line('Inserted');

end if;
end;
--------------------------------------------------------
--  DDL for Procedure SHOWDOCTOR
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "PROJECTDB"."SHOWDOCTOR" (id doctor.doctorid%type)
is
eid doctor.empid%type;
d doctor.dept%type;
s doctor.schedule%type;
dt doctor.details%type;
name employees.ename%type;

begin

select empid,dept,schedule,details into eid,d,s,dt from doctor where doctorid=id;
select ename into name from employees where employees.empid=eid;

dbms_output.put_line(name||' '||d||' '||s||' '||dt); 
end;
--------------------------------------------------------
--  DDL for Package EMPLOYEE_PACKAGE
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "PROJECTDB"."EMPLOYEE_PACKAGE" as 
procedure employee_CRUD(queryType in varchar2,eid in employees.empid%type,name in employees.ename%type,bg in employees.bloodgroup%type,wt in employees.weight%type,ag in employees.age%type,pno in employees.phoneNo%type,eCon in employees.emergencyContact%type,adrs in employees.address%type,medh in employees.medicalhistory%type,sal in employees.salary%type,des in employees.designation%type,jDate in employees.joinningDate%type,result out number); 
procedure Id_Generator(eid out employees.empid%type); end employee_package;
--------------------------------------------------------
--  DDL for Package USER_PACKAGE
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "PROJECTDB"."USER_PACKAGE" as
PROCEDURE LoginAuthentication(uid in users.userid%type,pass users.password%type,result out users.role%type);
PROCEDURE User_Insert_Update_Delete(uid in users.userid%type,pass in users.password%type,rl in users.role%type,st users.status%type,queryType in VARCHAR2);
FUNCTION User_Validity(uid users.userid%type) return boolean;
end user_package;
--------------------------------------------------------
--  DDL for Package Body EMPLOYEE_PACKAGE
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "PROJECTDB"."EMPLOYEE_PACKAGE" as
procedure employee_CRUD(queryType in varchar2,eid in employees.empid%type,name in employees.ename%type,bg in employees.bloodgroup%type,wt in employees.weight%type,ag in employees.age%type,pno in employees.phoneNo%type,eCon in employees.emergencyContact%type,adrs in employees.address%type,medh in  employees.medicalhistory%type,sal in employees.salary%type,des in employees.designation%type,jDate in employees.joinningDate%type,result out number)
is 
Begin

  if(queryType='insert')then
     insert into employees values(eid,name,bg,wt,ag,pno,eCon,adrs,medh,sal,des,jDate);
     result:=1;
  elsif(queryType='update')then
      update employees set ename=name,bloodgroup=bg,weight=wt,age=ag,phoneno=pno,emergencyContact=eCon,address=adrs,medicalhistory=medh,salary=sal,designation=des,joinningDate=jDate where empid=eid;
       result:=1;
  elsif(queryType='delete')then
       delete from employees where empid=eid;
       result:=1;
   else 
       result:=0;


end if;
end employee_CRUD;




procedure Id_Generator(eid out employees.empid%type)
is

eno employees.empid%type;
Begin
select max(empid) into eno  from employees;
eid:=eno;
end Id_generator;
end employee_package;
--------------------------------------------------------
--  DDL for Package Body USER_PACKAGE
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "PROJECTDB"."USER_PACKAGE" as
PROCEDURE LoginAuthentication(uid in users.userid%type,pass in users.password%type,result out users.role%type)
is
rl users.role%type;
c number;
begin

select role into rl from users where userid=uid and password=pass and status=1;
select count(*) into c from users where userid=uid and password=pass and status=1;
if(c=1) then
result:=rl;
else
result:='null';
end if;
exception
 when no_data_found then
 result:='null';
end LoginAuthentication;


PROCEDURE User_Insert_Update_Delete(uid in users.userid%type,pass in users.password%type,rl in users.role%type,st users.status%type,queryType in VARCHAR2)
is
Begin

if(queryType ='insert')then
      insert into users values(uid,pass,rl,st);
elsif(queryType ='update')then
   if(User_Validity(uid))then
      update users set password=pass,role=rl,status=st where userid=uid;
    end if;
elsif(queryType ='delete')then
     delete from users where userid=uid;
end if;
end User_Insert_Update_Delete;


FUNCTION User_Validity(uid users.userid%type) return boolean
is
u users.userid%type;
begin
select userid into u from users where userid=uid;
if(u=uid)then
   return true;
else 
   return false;
end if;
exception
 when no_data_found then
 return false;
end User_Validity;
end user_package;
--------------------------------------------------------
--  DDL for Function ISDOCTORAVAILABLE
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "PROJECTDB"."ISDOCTORAVAILABLE" (did doctor.doctorid%type,s doctor.schedule%type)
return boolean
is
select * from doctor where doctorid=did and schedule like s%;
end;
--------------------------------------------------------
--  DDL for Function SHOWAPPOINTMENT
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "PROJECTDB"."SHOWAPPOINTMENT" (did in appointment.doctorid%type,aDate in appointment.appointmentDate%type)return boolean
is
begin
select *from appointment where doctorid=did and appointmentdate=aDate ;
end;
--------------------------------------------------------
--  DDL for Function VALID_EMP
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "PROJECTDB"."VALID_EMP" (eno employees.empid%type) 
return boolean is eid employees.empid%type; 
begin 
select empid into eid from employees where empid=eno; 
if(eid=eno)then 
return true; 
else
return false; 
end if; 
exception when no_data_found 
then 
return false; 
end;
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."USERS" ADD CONSTRAINT "PK_USERS" PRIMARY KEY ("USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
 
  ALTER TABLE "PROJECTDB"."USERS" MODIFY ("PASSWORD" NOT NULL ENABLE)
 
  ALTER TABLE "PROJECTDB"."USERS" MODIFY ("ROLE" NOT NULL ENABLE)
--------------------------------------------------------
--  Constraints for Table CHARGES
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."CHARGES" ADD CONSTRAINT "CHARGES_PK" PRIMARY KEY ("SERVICEID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
--------------------------------------------------------
--  Constraints for Table BILL
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."BILL" ADD CONSTRAINT "PK_BILL" PRIMARY KEY ("BILLID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
 
  ALTER TABLE "PROJECTDB"."BILL" MODIFY ("PATIENTID" NOT NULL ENABLE)
 
  ALTER TABLE "PROJECTDB"."BILL" MODIFY ("DUE" NOT NULL ENABLE)
--------------------------------------------------------
--  Constraints for Table DOCTOR
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."DOCTOR" ADD CONSTRAINT "PK_DOCTOR" PRIMARY KEY ("DOCTORID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE
--------------------------------------------------------
--  Ref Constraints for Table APPOINTMENT
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."APPOINTMENT" ADD CONSTRAINT "APPOINTMENT_FK" FOREIGN KEY ("DOCTORID")
	  REFERENCES "PROJECTDB"."DOCTOR" ("DOCTORID") ENABLE
--------------------------------------------------------
--  Ref Constraints for Table DOCTOR
--------------------------------------------------------

  ALTER TABLE "PROJECTDB"."DOCTOR" ADD CONSTRAINT "FK_EMPID" FOREIGN KEY ("EMPID")
	  REFERENCES "PROJECTDB"."EMPLOYEES" ("EMPID") ENABLE
