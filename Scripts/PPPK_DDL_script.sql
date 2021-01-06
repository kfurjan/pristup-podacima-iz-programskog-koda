CREATE DATABASE PPPK
GO

USE PPPK
GO

/**
 * Driver table.
 *
 * Columns:
 *   IDDriver	- primary key
 *   Firstname	- driver's first name
 *   Lastname	- driver's last name
 *   Telephone	- driver's telephone
 *   Telephone	- driver's driving licence number
 */
CREATE TABLE Driver 
(
	IDDriver	INT CONSTRAINT PK_Driver PRIMARY KEY,
	Firstname	NVARCHAR(100)	NOT NULL,
	Lastname	NVARCHAR(100)	NOT NULL,
	Telephone	NVARCHAR(100)	NOT NULL,
	DrivingLicenceNumber INT	NOT NULL
)
GO

/**
 * Car table.
 *
 * Columns:
 *   IDCar	- auto increment primary key
 *   Brand	- car's brand name
 *   Model	- car's model name
 *   Year	- year of manufacture
 *   InitialMileage	- initial mileage of the car
 */
CREATE TABLE Car 
(
	IDCar		INT CONSTRAINT PK_Car PRIMARY KEY,
	Brand		NVARCHAR(100)	NOT NULL,
	Model		NVARCHAR(100)	NOT NULL,
	Year		INT				NULL,
	InitialMileage	INT			NULL
)
GO

/**
 * City table.
 *
 * Columns:
 *   IDCity	- auto increment primary key
 *   Name	- city name
 *   Latitude	- city latitude
 *   Longitude	- city longitude
 *   Country	- city within country
 *   CountryCode	- two letter country code
 *   County			- city within local county
 *   Capital		- capital type
 *   Population		- total population with county
 *   PopulationProper	- total population without county
 */
CREATE TABLE City
(
	IDCity		INT CONSTRAINT PK_City PRIMARY KEY,
	Name		NVARCHAR(100)	NOT NULL,
	Latitude	FLOAT			NOT NULL,
	Longitude	FLOAT			NOT NULL,
	Country		NVARCHAR(20)	NULL,
	CountryCode NVARCHAR(2)		NULL,
	County		NVARCHAR(100)	NULL,
	Capital		NVARCHAR(100)	NULL,
	Population	INT				NULL,
	PopulationProper INT		NULL
)

/**
 * Fuel table.
 *
 * Columns:
 *   IDFuel	- auto increment primary key
 *   Time	- time when fuel was purchased
 *   DriverID	- driver that bought the fuel
 *   CityID		- city where fuel was bought
 *   Amount		- amount of fuel bought
 *   Price		- price for which fuel was bought
 */
CREATE TABLE Fuel 
(
	IDFuel		INT CONSTRAINT PK_Fuel PRIMARY KEY,
	Time		DATETIME NULL,
	DriverID	INT CONSTRAINT FK_Fuel_Driver
		FOREIGN KEY(DriverID) REFERENCES Driver(IDDriver),
	CityID		INT CONSTRAINT FK_Fuel_City
		FOREIGN KEY(CityID) REFERENCES City(IDCity),
	Amount		INT	NULL,
	Price		INT	NULL
)
GO

/**
 * Route table.
 *
 * Columns:
 *   IDRoute	- auto increment primary key
 *   TimeHours	- time (in hours) spent for specific route
 *   CityA		- city where route started
 *   CityB		- city where route ended
 *   Kilometers	- kilometers between city A and city B
 *   AvgSpeed	- average speed for specific route
 *   FuelUsed	- amount of fuel used for specific route
 */
CREATE TABLE Route
(
	IDRoute		INT CONSTRAINT PK_Route PRIMARY KEY,
	TimeHours	INT NULL,
	CityA		INT CONSTRAINT FK_Route_CityA
		FOREIGN KEY(CityA) REFERENCES City(IDCity),
	CityB		INT CONSTRAINT FK_Route_CityB
		FOREIGN KEY(CityB) REFERENCES City(IDCity),
	Kilometers	INT	NULL,
	AvgSpeed	INT NULL,
	FuelUsed	INT NULL
)
GO

/**
 * TravelWarrantType table.
 *
 * Columns:
 *   IDTravelWarrantType	- auto increment primary key
 *   WarrantType			- constant for travel warrant type; Closed, Active, Future
 */
CREATE TABLE TravelWarrantType
(
	IDTravelWarrantType	INT CONSTRAINT PK_TravelWarrantType PRIMARY KEY,
	WarrantType			nvarchar(20) NOT NULL
)
GO

-- constants
INSERT INTO TravelWarrantType (IDTravelWarrantType, WarrantType) VALUES
	(1, 'CLOSED'),
	(2, 'ACTIVE'),
	(3, 'FUTURE')

/**
 * TravelWarrant table.
 *
 * Columns:
 *   IDTravelWarrant	- auto increment primary key
 *   DriverID			- driver data for specific travel warrant
 *   CarID				- car data for specific travel warrant
 *   TravelWarrantTypeID	- travel warrant type
 *   FuelID					- fuel data for specific travel warrant
 *   RouteID	- route data for specific travel warrant
 */
CREATE TABLE TravelWarrant 
(
	IDTravelWarrant	INT CONSTRAINT PK_TravelWarrant PRIMARY KEY,
	DriverID	INT CONSTRAINT FK_TravelWarrant_Driver
		FOREIGN KEY(DriverID) REFERENCES Driver(IDDriver),
	CarID		INT CONSTRAINT FK_TravelWarrant_Car
		FOREIGN KEY(CarID) REFERENCES Car(IDCar),
	TravelWarrantTypeID INT CONSTRAINT FK_TravelWarrant_TravelWarrantType
		FOREIGN KEY(TravelWarrantTypeID) REFERENCES TravelWarrantType(IDTravelWarrantType),
	FuelID		INT CONSTRAINT FK_TravelWarrant_Fuel
		FOREIGN KEY(FuelID) REFERENCES Fuel(IDFuel),
	RouteID		INT CONSTRAINT FK_TravelWarrant_Route
		FOREIGN KEY(RouteID) REFERENCES Route(IDRoute)
)
GO

CREATE PROCEDURE InsertExampleRecords
AS
BEGIN
	BEGIN TRY
		INSERT INTO Driver (IDDriver, Firstname, Lastname, Telephone, DrivingLicenceNumber) VALUES
			(1, 'Niki', 'Lauda', '123-456', 31975),
			(2, 'John', 'Doe', '456-123', 112233),
			(3, 'Mihajel', 'Šumaher', '987-321', 791155)

		INSERT INTO Car (IDCar, Brand, Model, Year, InitialMileage) VALUES
			(1, 'VW', 'Buba', 1998, 750000),
			(2, 'Zastava', '101', 2008, 30),
			(3, 'Audi', 'A4', 2014, 74503)

		INSERT INTO City (IDCity, Name, Latitude, Longitude, Country, CountryCode, County, Capital, Population, PopulationProper) VALUES
			(1, 'Zagreb', 45.8, 16.0, 'Croatia', 'HR', 'Zagreb, Grad', 'primary', 722526, 698966),
			(2, 'Split', 43.513889, 16.455833, 'Croatia', 'HR', 'Splitsko-Dalmatinska Županija', 'admin', 214741, 176314),
			(3, 'Varaždin', 46.304444, 16.337778, 'Croatia', 'HR', 'Varaždinska Županija', 'admin', 50000, 21474)

		INSERT INTO Fuel (IDFuel, Time, DriverID, CityID, Amount, Price) VALUES
			(1, '2018-08-10T12:23:45', 1, 1, 30, 300),
			(2, '2019-06-11T12:16:45', 2, 2, 45, 450),
			(3, '2020-04-07T12:12:45', 3, 3, 10, 100)

		INSERT INTO Route (IDRoute, TimeHours, CityA, CityB, Kilometers, AvgSpeed, FuelUsed) VALUES
			(1, 4, 1, 3, 100, 70, 10),
			(2, 8, 1, 2, 300, 60, 30),
			(3, 24, 2, 3, 400, 75, 60)

		INSERT INTO TravelWarrant (IDTravelWarrant, DriverID, CarID, TravelWarrantTypeID, FuelID, RouteID) VALUES
			(1, 1, 1, 1, 1, 1),
			(2, 2, 2, 2, 2, 2),
			(3, 3, 3, 3, 3, 3)
	END TRY
	BEGIN CATCH
	END CATCH
END
GO

CREATE PROCEDURE CleanDatabaseRecords
AS
BEGIN
	ALTER TABLE Fuel
		NOCHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City
	ALTER TABLE Route
		NOCHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant
		NOCHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
	
	DELETE FROM Driver
	DELETE FROM Car
	DELETE FROM City
	DELETE FROM Fuel
	DELETE FROM Route
	DELETE FROM TravelWarrant

	ALTER TABLE Fuel 
		CHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City 
	ALTER TABLE Route 
		CHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant 
		CHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
END
GO

CREATE PROCEDURE GetAllDrivers
AS
BEGIN
	SELECT
		IDDriver,
		Firstname,
		Lastname,
		Telephone,
		DrivingLicenceNumber
	FROM Driver
END
GO

CREATE PROCEDURE CreateDriver
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@telephone nvarchar(100),
	@drivingLicenceNumber int
AS
BEGIN
	declare @maxIdDriver int
	select @maxIdDriver = isnull(max(IDDriver), 0) from Driver
	set @maxIdDriver = @maxIdDriver + 1
	
	INSERT INTO Driver (IDDriver, Firstname, Lastname, Telephone, DrivingLicenceNumber) VALUES
		(@maxIdDriver, @firstName, @lastName, @telephone, @drivingLicenceNumber)
END
GO

CREATE PROCEDURE UpdateDriver
	@idDriver int,
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@telephone nvarchar(100),
	@drivingLicenceNumber int
AS
BEGIN
	UPDATE Driver SET
		Firstname = @firstName,
		Lastname = @lastName,
		Telephone = @telephone,
		DrivingLicenceNumber = @drivingLicenceNumber
	WHERE IDDriver = @idDriver
END
GO

CREATE PROCEDURE DeleteDriver
	@idDriver int
AS
BEGIN
	ALTER TABLE Fuel
		NOCHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City
	ALTER TABLE Route
		NOCHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant
		NOCHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
	
	UPDATE Fuel SET DriverID = NULL WHERE DriverID = @idDriver
	UPDATE TravelWarrant SET DriverID = NULL WHERE DriverID = @idDriver
	DELETE FROM Driver WHERE IDDriver = @idDriver

	ALTER TABLE Fuel 
		CHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City 
	ALTER TABLE Route 
		CHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant 
		CHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
END
GO

CREATE PROCEDURE GetAllTravelWarrants
AS
BEGIN
	SELECT
		*,
		cf.Name as "FuelCity",
		ca.Name as "StartCity",
		cb.Name as "StopCity"
	FROM
		TravelWarrant as tw
	INNER JOIN Driver as d
		on d.IDDriver = tw.DriverID
	INNER JOIN Car as c
		on c.IDCar = tw.CarID
	INNER JOIN TravelWarrantType as twt
		on twt.IDTravelWarrantType = tw.TravelWarrantTypeID
	INNER JOIN Fuel as f
		on f.IDFuel = tw.FuelID
	INNER JOIN Route as r
		on r.IDRoute = tw.RouteID
	INNER JOIN City as cf
		on cf.IDCity = f.CityID
	INNER JOIN City as ca
		on ca.IDCity = r.CityA
	INNER JOIN City as cb
		on cb.IDCity = r.CityB
END
GO

CREATE PROCEDURE GetAllCars
AS
BEGIN
	SELECT
		*
	FROM Car
END
GO

CREATE PROCEDURE GetAllCities
AS
BEGIN
	SELECT
		*
	FROM City
END
GO

CREATE PROCEDURE DeleteTravelWarrant
	@idTravelWarrant int
AS
BEGIN
	DELETE
	FROM TravelWarrant
	WHERE IDTravelWarrant = @idTravelWarrant
END
GO

CREATE PROCEDURE UpdateTravelWarrant
	@idTravelWarrant int,
	@idDriver int,
	@idCar int,
	@idTravelWarrantType int,
	@idRoute int,
	@idCityA int,
	@idCityB int,
	@timeHours int
AS
BEGIN
	UPDATE Route
	SET 
		CityA = @idCityA,
		CityB = @idCityB,
		TimeHours = @timeHours
	WHERE IDRoute = @idRoute

	UPDATE TravelWarrant
	SET
		DriverID = @idDriver,
		CarID = @idCar,
		TravelWarrantTypeID = @idTravelWarrantType
	WHERE IDTravelWarrant = @idTravelWarrant
END
GO

CREATE PROCEDURE CreateTravelWarrant
	@idDriver int,
	@idCar int,
	@idTravelWarrantType int,
	@idCityA int,
	@idCityB int,
	@timeHours int
AS
BEGIN
	declare @maxIdRoute int
	SELECT @maxIdRoute = ISNULL(MAX(IDRoute), 0) FROM ROUTE
	set @maxIdRoute = @maxIdRoute + 1
	INSERT INTO Route (IDRoute, TimeHours, CityA, CityB, Kilometers, AvgSpeed, FuelUsed) VALUES
		(@maxIdRoute, @timeHours, @idCityA, @idCityB, 0, 0, 0)

	declare @maxIdFuel int
	SELECT @maxIdFuel = MAX(IDFuel) FROM Fuel
	set @maxIdFuel = @maxIdFuel + 1
	INSERT INTO Fuel (IDFuel, Time, DriverID, CityID, Amount, Price)  VALUES
		(@maxIdFuel, '2018-08-10T12:23:45', @idDriver, @idCityA, 0, 0)

	declare @maxIdTravelWarrant int
	SELECT @maxIdTravelWarrant = MAX(IDTravelWarrant) FROM TravelWarrant
	set @maxIdTravelWarrant = @maxIdTravelWarrant + 1
	INSERT INTO TravelWarrant (IDTravelWarrant, DriverID, CarID, TravelWarrantTypeID, FuelID, RouteID) VALUES
		(@maxIdTravelWarrant, @idDriver, @idCar, @idTravelWarrantType, @maxIdFuel, @maxIdRoute)
END
GO

CREATE PROCEDURE InsertDriver
	@idDriver int,
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@telephone nvarchar(100),
	@drivingLicenceNumber int
AS
BEGIN
	INSERT INTO Driver (IDDriver, Firstname, Lastname, Telephone, DrivingLicenceNumber) VALUES
		(@idDriver, @firstName, @lastName, @telephone, @drivingLicenceNumber)
END
GO

CREATE PROCEDURE InsertCar
	@idCar int,
	@brand nvarchar(100),
	@model nvarchar(100),
	@year int,
	@initialMileage int
AS
BEGIN
	INSERT INTO Car (IDCar, Brand, Model, Year, InitialMileage) VALUES
		(@idCar, @brand, @model, @year, @initialMileage)
END
GO

CREATE PROCEDURE InsertCity
	@idCity int,
	@name nvarchar(100),
	@latitude float,
	@longitude float,
	@country nvarchar(100),
	@countryCode nvarchar(2),
	@county nvarchar(100),
	@capital nvarchar(100),
	@population int,
	@populationProper int
AS
BEGIN
	INSERT INTO City (IDCity, Name, Latitude, Longitude, Country, CountryCode, County, Capital, Population, PopulationProper) VALUES
		(@idCity, @name, @latitude, @longitude, @country, @countryCode, @county, @capital, @population, @populationProper)
END
GO

CREATE PROCEDURE InsertFuel
	@idFuel int,
	@time DateTime,
	@driverId int,
	@cityID int,
	@amount int,
	@price int
AS
BEGIN
	INSERT INTO Fuel (IDFuel, Time, DriverID, CityID, Amount, Price) VALUES
		(@idFuel, @time, @driverId, @cityID, @amount, @price)
END
GO

CREATE PROCEDURE InsertRoute
	@idRoute int,
	@timeHours int,
	@cityAId int,
	@cityBId int,
	@kilometers int,
	@avgSpeed int,
	@fuelUsed int
AS
BEGIN
	INSERT INTO Route (IDRoute, TimeHours, CityA, CityB, Kilometers, AvgSpeed, FuelUsed) VALUES
		(@idRoute, @timeHours, @cityAId, @cityBId, @kilometers, @avgSpeed, @fuelUsed)
END
GO

CREATE PROCEDURE InsertTravelWarrant
	@idTravelWarrant int,
	@driverId int,
	@carId int,
	@travelWarrantTypeId int,
	@fuelId int,
	@routeId int
AS
BEGIN
	INSERT INTO TravelWarrant (IDTravelWarrant, DriverID, CarID, TravelWarrantTypeID, FuelID, RouteID) VALUES
		(@idTravelWarrant, @driverId, @carId, @travelWarrantTypeId, @fuelId, @routeId)
END
GO

CREATE PROC SelectRouteData
	@idRoute int
AS
BEGIN
	SELECT 
		r.IDRoute,
		r.TimeHours,
		ca.Name as CityA,
		cb.Name as CityB,
		r.Kilometers,
		r.AvgSpeed,
		r.FuelUsed
	FROM Route as r
		inner join City as ca
	on ca.IDCity = r.CityA 
		inner join City as cb
	on cb.IDCity = r.CityB
	where IDRoute = @idRoute
END
GO

CREATE PROC GetAllRoutes
AS
BEGIN
	SELECT 
		r.IDRoute,
		r.TimeHours,
		ca.IDCity as IDCityA,
		ca.Name as CityA,
		cb.IDCity as IDCityB,
		cb.Name as CityB,
		r.Kilometers,
		r.AvgSpeed,
		r.FuelUsed
	FROM Route as r
		inner join City as ca
	on ca.IDCity = r.CityA 
		inner join City as cb
	on cb.IDCity = r.CityB
END
GO

CREATE PROC CreateRoute
	@timeHours int,
	@kilometers int,
	@idCityA int,
	@idCityB int,
	@avgSpeed int,
	@fuelUsed int
AS
BEGIN
	declare @idRoute int
	select @idRoute = isnull(max(IDRoute), 0) from Route

	set @idRoute = @idRoute + 1

	INSERT INTO Route (IDRoute, TimeHours, Kilometers, CityA, CityB, AvgSpeed, FuelUsed) VALUES
		(@idRoute, @timeHours, @kilometers, @idCityA, @idCityB, @avgSpeed, @fuelUsed)
END
GO

CREATE PROC UpdateRoute
	@idRoute int,
	@timeHours int,
	@kilometers int,
	@idCityA int,
	@idCityB int,
	@avgSpeed int,
	@fuelUsed int
AS
BEGIN
	UPDATE Route
	SET 
		TimeHours = @timeHours,
		Kilometers = @kilometers,
		CityA = @idCityA,
		CityB = @idCityB,
		AvgSpeed = @avgSpeed,
		FuelUsed = @fuelUsed
	WHERE IDRoute = @idRoute
END
GO

CREATAE PROC DeleteRoute
	@idRoute int
AS
BEGIN
	ALTER TABLE TravelWarrant
	NOCHECK CONSTRAINT FK_TravelWarrant_Route

	DELETE
	FROM Route
	WHERE IDRoute = @idRoute

	ALTER TABLE TravelWarrant 
		CHECK CONSTRAINT FK_TravelWarrant_Route
END
GO

ALTER PROC GetAllDatabaseData
AS
BEGIN
	SELECT
		tw.IDTravelWarrant,
		twt.IDTravelWarrantType,
		d.IDDriver,
		d.Firstname,
		d.Lastname,
		d.Telephone,
		d.DrivingLicenceNumber,
		c.IDCar,
		c.Brand,
		c.Model,
		c.Year,
		c.InitialMileage,
		f.IDFuel,
		f.Time,
		f.DriverID,
		f.CityID,
		f.Amount,
		f.Price,
		ct.IDCity,
		ct.Name,
		ct.Latitude,
		ct.Longitude,
		ct.Country,
		ct.CountryCode,
		ct.County,
		ct.Capital,
		ct.Population,
		ct.PopulationProper,
		r.IDRoute,
		r.TimeHours,
		r.CityA,
		r.CityB,
		r.Kilometers,
		r.AvgSpeed,
		r.FuelUsed
	FROM
		TravelWarrant as tw
	INNER JOIN Driver as d
		on d.IDDriver = tw.DriverID
	INNER JOIN Car as c
		on c.IDCar = tw.CarID
	INNER JOIN TravelWarrantType as twt
		on twt.IDTravelWarrantType = tw.TravelWarrantTypeID
	INNER JOIN Fuel as f
		on f.IDFuel = tw.FuelID
	INNER JOIN City as ct
		on ct.IDCity = f.CityID
	INNER JOIN Route as r
		on r.IDRoute = tw.RouteID
	ORDER BY tw.IDTravelWarrant
END
GO

CREATE PROCEDURE CleanDatabaseRecordsAfterExport
AS
BEGIN
	ALTER TABLE Fuel
		NOCHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City
	ALTER TABLE Route
		NOCHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant
		NOCHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
	
	DELETE FROM Driver
	DELETE FROM Car
	DELETE FROM Fuel
	DELETE FROM Route
	DELETE FROM TravelWarrant

	ALTER TABLE Fuel 
		CHECK CONSTRAINT FK_Fuel_Driver, FK_Fuel_City 
	ALTER TABLE Route 
		CHECK CONSTRAINT FK_Route_CityA, FK_Route_CityB
	ALTER TABLE TravelWarrant 
		CHECK CONSTRAINT FK_TravelWarrant_Driver, FK_TravelWarrant_Car, FK_TravelWarrant_Fuel, FK_TravelWarrant_Route
END
GO

CREATE PROC CreateFuel
	@time datetime,
	@idDriver int,
	@idCity int,
	@amount int,
	@price int
AS
BEGIN
	declare @maxIdFuel int
	select @maxIdFuel = isnull(max(IDFuel), 0) from Fuel
	set @maxIdFuel = @maxIdFuel + 1
	
	INSERT INTO Fuel(IDFuel, Time, DriverID, CityID, Amount, Price) VALUES
		(@maxIdFuel, @time, @idDriver, @idCity, @amount, @price)
END
GO

CREATE PROC CreateCar
	@brand nvarchar(100),
	@model nvarchar(100),
	@year int,
	@initialMileage int
AS
BEGIN
	declare @maxIdCar int
	select @maxIdCar = isnull(max(IDCar), 0) from Car
	set @maxIdCar = @maxIdCar + 1
	
	INSERT INTO Car(IDCar, Brand, Model, Year, InitialMileage) VALUES
		(@maxIdCar, @brand, @model, @year, @initialMileage)
END
GO