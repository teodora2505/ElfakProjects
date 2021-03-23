CREATE TABLE ODELJENJE(
ID NUMBER(5,0) PRIMARY KEY,
NAZIV VARCHAR(20) NOT NULL,
SMER VARCHAR(20)
);

CREATE TABLE KORISNIK(
ID NUMBER(5,0) PRIMARY KEY,
IME VARCHAR(20) NOT NULL,
PREZIME VARCHAR(20) NOT NULL,
DATUM_RODJENJA DATE,
POL CHAR(1) CHECK (POL IN ('M','Z')),
JMBG CHAR(13) NOT NULL,
USERNAME VARCHAR(20) NOT NULL,
PASSWORD VARCHAR(20) NOT NULL,
FADMINISTRATOR NUMBER(1,0) DEFAULT 0 CHECK (FADMINISTRATOR IN ('0','1')) NOT NULL,
FRODITELJ NUMBER(1,0) DEFAULT 0 CHECK (FRODITELJ IN ('0','1')) NOT NULL,
FNASTAVNIK NUMBER(1,0) DEFAULT 0 CHECK (FNASTAVNIK IN ('0','1')) NOT NULL,
STEPEN_STRUCNE_SPREME VARCHAR(20),
FUCENIK NUMBER(1,0) DEFAULT 0 CHECK (FUCENIK IN ('0','1')) NOT NULL,
ID_ODELJENJA NUMBER(5,0),
BR_OPRAVDANIH NUMBER(5,0),
BR_NEOPRAVDANIH NUMBER(5,0),
OCENA_IZ_VLADANJA NUMBER(1,0) CHECK (OCENA_IZ_VLADANJA IN ('1','2','3','4','5')),
CONSTRAINT ODELJ_FK FOREIGN KEY (ID_ODELJENJA) REFERENCES ODELJENJE (ID)
);

CREATE TABLE JE_RAZREDNI(
ID NUMBER(5,0) PRIMARY KEY,
ID_ODELJENJA NUMBER(5,0) NOT NULL,
ID_NASTAVNIKA NUMBER(5,0) NOT NULL,
DATUM_OD DATE,
DATUM_DO DATE,
CONSTRAINT O_FK FOREIGN KEY (ID_ODELJENJA) REFERENCES ODELJENJE (ID),
CONSTRAINT N_FK FOREIGN KEY (ID_NASTAVNIKA) REFERENCES KORISNIK (ID)
);

CREATE TABLE PREDMET(
ID NUMBER(5,0) PRIMARY KEY,
NAZIV VARCHAR(20) NOT NULL,
OPIS VARCHAR(100),
BR_CASOVA NUMBER(5,0) NOT NULL,
TIP_PREDMETA VARCHAR(20) CHECK (TIP_PREDMETA IN ('IZBORNI','OBAVEZNI')),
MIN_BR_UCENIKA NUMBER(5,0),
BLOK_NASTAVA CHAR(2) CHECK (BLOK_NASTAVA IN ('DA','NE')),
SPEC_KABINET CHAR(2) CHECK (SPEC_KABINET IN ('DA','NE'))
);

CREATE TABLE PREDSTAVLJA(
ID NUMBER(5,0) PRIMARY KEY,
ID_ODELJENJA NUMBER(5,0) NOT NULL,
ID_RODITELJA NUMBER(5,0) NOT NULL,
DATUM_OD DATE,
DATUM_DO DATE,
CONSTRAINT OD_FK FOREIGN KEY (ID_ODELJENJA) REFERENCES ODELJENJE (ID),
CONSTRAINT R_FK FOREIGN KEY (ID_RODITELJA) REFERENCES KORISNIK (ID)
);

CREATE TABLE FUNKCIJA(
ID NUMBER(5,0) PRIMARY KEY,
ID_RODITELJA NUMBER(5,0) NOT NULL,
DATUM_OD DATE,
DATUM_DO DATE,
TIP VARCHAR(20) CHECK (TIP IN ('PREDSEDNIK','ZAMENIK PREDSEDNIKA')),
CONSTRAINT RO_FK FOREIGN KEY (ID_RODITELJA) REFERENCES KORISNIK (ID)
);

CREATE TABLE RASPORED(
ID NUMBER(5,0) PRIMARY KEY,
ID_ODELJENJA NUMBER(5,0) NOT NULL,
ID_PREDMETA NUMBER(5,0) NOT NULL,
DAN VARCHAR(20) CHECK (DAN IN ('PONEDELJAK','UTORAK','SREDA','CETVRTAK','PETAK')),
CAS NUMBER(5,0),
CONSTRAINT ODE_FK FOREIGN KEY (ID_ODELJENJA) REFERENCES ODELJENJE (ID),
CONSTRAINT P_FK FOREIGN KEY (ID_PREDMETA) REFERENCES PREDMET (ID)
);

CREATE TABLE PREDAJE(
ID NUMBER(5,0) PRIMARY KEY,
ID_NASTAVNIKA NUMBER(5,0) NOT NULL,
ID_PREDMETA NUMBER(5,0) NOT NULL,
CONSTRAINT NA_FK FOREIGN KEY (ID_NASTAVNIKA) REFERENCES KORISNIK (ID),
CONSTRAINT PR_FK FOREIGN KEY (ID_PREDMETA) REFERENCES PREDMET (ID)
);

CREATE TABLE JE_RODITELJ(
ID NUMBER(5,0) PRIMARY KEY,
ID_RODITELJA NUMBER(5,0) NOT NULL,
ID_UCENIKA NUMBER(5,0) NOT NULL,
CONSTRAINT ROD_FK FOREIGN KEY (ID_RODITELJA) REFERENCES KORISNIK (ID),
CONSTRAINT UC_FK FOREIGN KEY (ID_UCENIKA) REFERENCES KORISNIK (ID)
);

CREATE TABLE BROJ_TELEFONA(
ID NUMBER(5,0) PRIMARY KEY,
ID_KORISNIKA NUMBER(5,0) NOT NULL,
BR_TELEFONA VARCHAR(20) NOT NULL,
CONSTRAINT K_FK FOREIGN KEY (ID_KORISNIKA) REFERENCES KORISNIK (ID)
);

CREATE TABLE GODINA(
ID NUMBER(5,0) PRIMARY KEY,
ID_PREDMETA NUMBER(5,0) NOT NULL,
GODINA NUMBER(1,0) CHECK (GODINA > 0),
CONSTRAINT PRE_FK FOREIGN KEY (ID_PREDMETA) REFERENCES PREDMET (ID)
);

CREATE TABLE DRZI_CAS(
ID NUMBER(5,0) PRIMARY KEY,
ID_NASTAVNIKA NUMBER(5,0) NOT NULL,
ID_PREDMETA NUMBER(5,0) NOT NULL,
ID_ODELJENJA NUMBER(5,0) NOT NULL,
CONSTRAINT NAS_FK FOREIGN KEY (ID_NASTAVNIKA) REFERENCES KORISNIK (ID),
CONSTRAINT PRED_FK FOREIGN KEY (ID_PREDMETA) REFERENCES PREDMET (ID),
CONSTRAINT ODEL_FK FOREIGN KEY (ID_ODELJENJA) REFERENCES ODELJENJE (ID)
);

CREATE TABLE IMA_OCENU(
ID NUMBER(5,0) PRIMARY KEY,
ID_UCENIKA NUMBER(5,0) NOT NULL,
ID_PREDMETA NUMBER(5,0) NOT NULL,
TIP_OCENE VARCHAR(20) CHECK (TIP_OCENE IN ('BROJCANA','OPISNA')),
VREDNOST NUMBER(1,0) CHECK (VREDNOST IN ('1','2','3','4','5')),
OPIS VARCHAR(100),
CONSTRAINT PREDE_FK FOREIGN KEY (ID_PREDMETA) REFERENCES PREDMET (ID),
CONSTRAINT UCE_FK FOREIGN KEY (ID_UCENIKA) REFERENCES KORISNIK (ID)
);