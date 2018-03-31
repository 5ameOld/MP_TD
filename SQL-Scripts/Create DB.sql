CREATE DATABASE TDM;

use TDM;

CREATE TABLE `Unit` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `HitPoints` decimal(12,4) NOT NULL,
  `Damage` decimal(12,4) NOT NULL,
  `Range` decimal(12,4) NOT NULL,
  `Speed` decimal(12,4) NOT NULL,
  `WoodCosts` decimal(12,4),
  `MetalCosts` decimal(12,4),
  `FoodCosts` decimal(12,4),
  `Armor` decimal(12,4) NOT NULL,
  `Penetration` decimal(12,4) NOT NULL,
  `AttackTurrets` bit(1) NOT NULL,
  PRIMARY KEY (`Id`)
);


CREATE TABLE Effect (
	Id varchar(50) primary key,
    `Name` varchar(255) NOT NULL,
    Duration decimal(12,4) NOT NULL
);

CREATE TABLE DamageType (
	Id varchar(50) primary key,
    `Name` varchar(255) not null
);

CREATE TABLE Ability (
	Id varchar(50) primary key,
    `Name` varchar(255) NOT NULL,
    Cooldown decimal(12,4) NOT NULL,
    Damage decimal(12,4) NOT NULL,
    EffectId varchar(50),
    DamageTypeId varchar(50),
    FOREIGN KEY (DamageTypeId) REFERENCES DamageType(Id) on delete cascade on update cascade,
    FOREIGN KEY (EffectId) REFERENCES Effect(Id) on delete cascade on update cascade
);

CREATE TABLE BuildingType (
	Id varchar(50) PRIMARY KEY,
    `Name` varchar(255) NOT NULL
);

CREATE TABLE Building (
	Id int PRIMARY KEY AUTO_INCREMENT,
    `Name`varchar(255) NOT NULL,
    BuildingSteps int NOT NULL,
    ProductionSpeed decimal(12,4) NOT NULL,
    UnitsPerStep int NOT NULL,
    BuildingTypeId varchar(50) NOT NULL,
    WoodCosts decimal(12,4),
	MetalCosts decimal(12,4),
    FoodCosts decimal(12,4),
    FOREIGN KEY (BuildingTypeId) REFERENCES BuildingType(Id) on update cascade on delete cascade
);

CREATE TABLE Ressource (
	Id varchar(50) PRIMARY KEY,
    `Name` varchar(255) NOT NULL
);

CREATE TABLE Worker (
	Id int PRIMARY KEY,
    BuildingSpeed decimal(12,4),
    FOREIGN KEY (Id) REFERENCES Unit(Id) on update cascade on delete cascade
);

CREATE TABLE BuildingRessoures (
	Id int PRIMARY KEY AUTO_INCREMENT,
    RessourceId varchar(50) NOT NULL,
    BuildingId int NOT NULL,
    FOREIGN KEY (RessourceId) REFERENCES Ressource(Id) on update cascade on delete cascade,
    FOREIGN KEY (BuildingId) REFERENCES Building(Id) on update cascade on delete cascade
);

CREATE TABLE BuildingUnit (
	Id int PRIMARY KEY AUTO_INCREMENT,
    UnitId int NOT NULL,
    BuildingId int NOT NULL,
    FOREIGN KEY (UnitId) REFERENCES Unit(Id) on update cascade on delete cascade,
    FOREIGN KEY (BuildingId) REFERENCES Building(Id) on update cascade on delete cascade
);