#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: RAYON
#------------------------------------------------------------

CREATE TABLE RAYON(
        num_ray  Varchar (10) NOT NULL ,
        intitule Varchar (50) NOT NULL
	,CONSTRAINT RAYON_PK PRIMARY KEY (num_ray)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: GROUPE
#------------------------------------------------------------

CREATE TABLE GROUPE(
        code_group Varchar (100) NOT NULL ,
        libelle    Varchar (50) NOT NULL
	,CONSTRAINT GROUPE_PK PRIMARY KEY (code_group)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: DISCIPLINE
#------------------------------------------------------------

CREATE TABLE DISCIPLINE(
        code_dis   Varchar (100) NOT NULL ,
        intitule   Varchar (50) NOT NULL ,
        code_group Varchar (100) NOT NULL
	,CONSTRAINT DISCIPLINE_PK PRIMARY KEY (code_dis)

	,CONSTRAINT DISCIPLINE_GROUPE_FK FOREIGN KEY (code_group) REFERENCES GROUPE(code_group)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: EDITEUR
#------------------------------------------------------------

CREATE TABLE EDITEUR(
        num_editeur Varchar (100) NOT NULL ,
        nom         Varchar (50) NOT NULL
	,CONSTRAINT EDITEUR_PK PRIMARY KEY (num_editeur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: AUTEUR
#------------------------------------------------------------

CREATE TABLE AUTEUR(
        code_auteur Varchar (100) NOT NULL ,
        nom         Varchar (50) NOT NULL ,
        prenom      Varchar (50) NOT NULL
	,CONSTRAINT AUTEUR_PK PRIMARY KEY (code_auteur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: DOCUMENT
#------------------------------------------------------------

CREATE TABLE DOCUMENT(
        code_doc       Varchar (100) NOT NULL ,
        titre          Varchar (100) NOT NULL ,
        annee_edition  Int NOT NULL ,
        nb_exemp       Int NOT NULL ,
        nb_exemp_dispo Int NOT NULL ,
        couverture     Longblob NOT NULL ,
        num_ray        Varchar (10) NOT NULL ,
        code_auteur    Varchar (100) NOT NULL ,
        num_editeur    Varchar (100) NOT NULL ,
        code_dis       Varchar (100) NOT NULL
	,CONSTRAINT DOCUMENT_PK PRIMARY KEY (code_doc)

	,CONSTRAINT DOCUMENT_RAYON_FK FOREIGN KEY (num_ray) REFERENCES RAYON(num_ray)
	,CONSTRAINT DOCUMENT_AUTEUR0_FK FOREIGN KEY (code_auteur) REFERENCES AUTEUR(code_auteur)
	,CONSTRAINT DOCUMENT_EDITEUR1_FK FOREIGN KEY (num_editeur) REFERENCES EDITEUR(num_editeur)
	,CONSTRAINT DOCUMENT_DISCIPLINE2_FK FOREIGN KEY (code_dis) REFERENCES DISCIPLINE(code_dis)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ADHERENT
#------------------------------------------------------------

CREATE TABLE ADHERENT(
        num_adherent Varchar (100) NOT NULL ,
        photo        Longblob NOT NULL ,
        nom          Varchar (50) NOT NULL ,
        prenom       Varchar (50) NOT NULL ,
        nationalite  Varchar (50) NOT NULL ,
        telephone    Int NOT NULL ,
        email        Varchar (50) NOT NULL ,
        categorie    Varchar (50) NOT NULL ,
        type         Varchar (50) NOT NULL ,
        etat         Varchar (50) NOT NULL ,
        login        Varchar (50) NOT NULL ,
        mot_passe    Varchar (50) NOT NULL
	,CONSTRAINT ADHERENT_AK UNIQUE (login,mot_passe)
	,CONSTRAINT ADHERENT_PK PRIMARY KEY (num_adherent)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ETUDIANT
#------------------------------------------------------------

CREATE TABLE ETUDIANT(
        num_adherent Varchar (100) NOT NULL ,
        niveau_etud  Varchar (50) NOT NULL ,
        categorie_SP Varchar (50) NOT NULL ,
        photo        Longblob NOT NULL ,
        nom          Varchar (50) NOT NULL ,
        prenom       Varchar (50) NOT NULL ,
        nationalite  Varchar (50) NOT NULL ,
        telephone    Int NOT NULL ,
        email        Varchar (50) NOT NULL ,
        categorie    Varchar (50) NOT NULL ,
        type         Varchar (50) NOT NULL ,
        etat         Varchar (50) NOT NULL ,
        num_carte    Int NOT NULL ,
        login        Varchar (50) NOT NULL ,
        mot_passe    Varchar (50) NOT NULL
	,CONSTRAINT ETUDIANT_AK UNIQUE (num_carte,login,mot_passe)
	,CONSTRAINT ETUDIANT_PK PRIMARY KEY (num_adherent)

	,CONSTRAINT ETUDIANT_ADHERENT_FK FOREIGN KEY (num_adherent) REFERENCES ADHERENT(num_adherent)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ENSEIGNANT
#------------------------------------------------------------

CREATE TABLE ENSEIGNANT(
        num_adherent    Varchar (100) NOT NULL ,
        domaine_rech    Varchar (100) NOT NULL ,
        matiere_enseign Varchar (100) NOT NULL ,
        photo           Longblob NOT NULL ,
        nom             Varchar (50) NOT NULL ,
        prenom          Varchar (50) NOT NULL ,
        nationalite     Varchar (50) NOT NULL ,
        telephone       Int NOT NULL ,
        email           Varchar (50) NOT NULL ,
        categorie       Varchar (50) NOT NULL ,
        type            Varchar (50) NOT NULL ,
        etat            Varchar (50) NOT NULL ,
        mat_ensei       Int NOT NULL ,
        login           Varchar (50) NOT NULL ,
        mot_passe       Varchar (50) NOT NULL
	,CONSTRAINT ENSEIGNANT_AK UNIQUE (mat_ensei,login,mot_passe)
	,CONSTRAINT ENSEIGNANT_PK PRIMARY KEY (num_adherent)

	,CONSTRAINT ENSEIGNANT_ADHERENT_FK FOREIGN KEY (num_adherent) REFERENCES ADHERENT(num_adherent)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: EMPRUNTER
#------------------------------------------------------------

CREATE TABLE EMPRUNTER(
        code_doc     Varchar (100) NOT NULL ,
        num_adherent Varchar (100) NOT NULL ,
        date_emprunt Date NOT NULL ,
        date_retour  Date NOT NULL
	,CONSTRAINT EMPRUNTER_PK PRIMARY KEY (code_doc,num_adherent)

	,CONSTRAINT EMPRUNTER_DOCUMENT_FK FOREIGN KEY (code_doc) REFERENCES DOCUMENT(code_doc)
	,CONSTRAINT EMPRUNTER_ADHERENT0_FK FOREIGN KEY (num_adherent) REFERENCES ADHERENT(num_adherent)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RESERVER
#------------------------------------------------------------

CREATE TABLE RESERVER(
        code_doc         Varchar (100) NOT NULL ,
        num_adherent     Varchar (100) NOT NULL ,
        date_reservation Date NOT NULL
	,CONSTRAINT RESERVER_PK PRIMARY KEY (code_doc,num_adherent)

	,CONSTRAINT RESERVER_DOCUMENT_FK FOREIGN KEY (code_doc) REFERENCES DOCUMENT(code_doc)
	,CONSTRAINT RESERVER_ETUDIANT0_FK FOREIGN KEY (num_adherent) REFERENCES ETUDIANT(num_adherent)
)ENGINE=InnoDB;

