CREATE TABLE AthleticsClubs(
AthleticsClubID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ClubName varchar(25) Not Null,
);

CREATE TABLE Athlete (
AthleteID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
AthleteName varchar(15) NOT NULL,
  AthleticsClubID int IDENTITY(1,1),
AthleteDOB Date,
CONSTRAINT AthleticsClubs_FK1 FOREIGN KEY (AthleticsClubID) REFERENCES AthleticsClubs(AthleticsClubID)
);

CREATE TABLE Event(
EventID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
EventName varchar(15),
EventTime time
);

CREATE TABLE AthleteEvents(
AthleteID int IDENTITY(1,1),
EventID int IDENTITY(1,1) , 
CONSTRAINT AthleteEvents_PK PRIMARY KEY (EventID, AtheleteID),
CONSTRAINT AthleteEvents_FK1 FOREIGN KEY (EventID) REFERENCES Event(EventID),
CONSTRAINT Athlete_FK2 FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID)
