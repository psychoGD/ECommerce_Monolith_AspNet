CREATE TABLE Favorites(
	"FavoritesID" INT NOT NULL IDENTITY(1,1),
	"ProductID" int NULL,
	"CustomerID" nchar (5) NULL
	CONSTRAINT "PK_Favorites" PRIMARY KEY  CLUSTERED 
	(
		"FavoritesID"
	),
	CONSTRAINT "FK_Favorites_Customers" FOREIGN KEY 
	(
		"CustomerID"
	) REFERENCES "dbo"."Customers" (
		"CustomerID"
	),
)