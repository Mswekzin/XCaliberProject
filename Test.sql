CREATE TABLE Athlete (
AthleteID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
AthleteName varchar2(15),
AthleteDOB Date,
CONSTRAINT AthleticsClubs_FK1 FOREIGN KEY (ClubName) REFERENCES AthleticsClubs(ClubName)
);
CREATE TABLE AthleticsClubs(
AthleticsClubID in IDENTITY(1,1) NOT NULL PRIMARY KEY,
ClubName varchar2(25),
);

CREATE TABLE Event(
EventID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
EventName varchar2(15),
EventTime time
);

CREATE TABLE AthleteEvents(
AthleteID int IDENTITY(1,1),
EventID int IDENTITY(1,1) , 
CONSTRAINT AthleteEvents_PK PRIMARY KEY (EventID, AtheleteID),
CONSTRAINT AthleteEvents_FK1 FOREIGN KEY (EventID) REFERENCES Event(EventID),
CONSTRAINT Athlete_FK2 FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID)
);
