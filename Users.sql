CREATE DATABASE HangMan
USE HangMan

CREATE TABLE User ( Username NVARCHAR(50) CONSTRAINT pk_Username PRIMARY KEY,
			  Password NVARCHAR(50),
			  Games BIGINT,
			);