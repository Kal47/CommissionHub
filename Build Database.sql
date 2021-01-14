CREATE TABLE "Artist" (
	"Artist_ID"	INTEGER NOT NULL UNIQUE,
	"Username"	TEXT NOT NULL UNIQUE,
	"Is_Open_For_Commisions"	INTEGER NOT NULL,
	"Type"	TEXT,
	"Location"	TEXT,
	"Commision_Info"	TEXT,
	PRIMARY KEY("Artist_ID" AUTOINCREMENT)
);

