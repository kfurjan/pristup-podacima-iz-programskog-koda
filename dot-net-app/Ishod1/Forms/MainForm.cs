using Ishod1.Dao;
using Ishod1.Factory;
using Ishod1.Model;
using Ishod1.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Ishod1.Forms
{
    public partial class MainForm : Form
    {
        private const string XML_ROUTE_PATH = @"../../route.xml";
        private const string XML_DATABASE_PATH = @"../../database_data.xml";
        private static readonly IRepository repository = RepositoryFactory.GetInstance(typeof(SqlRepository));

        public MainForm() => InitializeComponent();

        private void TbControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                if (TbControl.SelectedTab.Text == TbPageDrivers.Text)
                {
                    ShowListBoxData(LbDrivers, repository.GetAllDrivers(LbInfo));
                }
                else if (TbControl.SelectedTab.Text == TbPageTravelWarrants.Text)
                {
                    ShowListBoxData(LbTravelWarrants, repository.GetAllTravelWarrants());
                    LoadTravelWarrantCbs();
                }
                else
                {
                    ShowListBoxData(LbRoutes, repository.GetAllRoutes());
                    LoadRoutesCbs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 'Drivers' tab page

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                ShowListBoxData(LbDrivers, repository.GetAllDrivers(LbInfo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbDrivers_SelectedIndexChanged(object sender, EventArgs e)
            => ShowDriverForm(LbDrivers.SelectedItem as Driver);

        private void BtnClearDriversForm_Click(object sender, EventArgs e)
            => TbPageDrivers.Controls.OfType<TextBox>().ToList().ForEach(c => c.Text = string.Empty);

        private void BtnDeleteDriver_Click(object sender, EventArgs e)
        {
            try
            {
                repository.DeleteDriver(int.Parse(TbIdDriver.Text));
                ShowListBoxData(LbDrivers, repository.GetAllDrivers(LbInfo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdateDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormInvalid())
                {
                    repository.UpdateDriver(new Driver
                        (
                            int.Parse(TbIdDriver.Text.Trim()),
                            TbFirstName.Text.Trim(),
                            TbLastName.Text.Trim(),
                            TbTelephone.Text.Trim(),
                            int.Parse(TbDrivingLicenceNumber.Text.Trim())
                        ));
                    ShowListBoxData(LbDrivers, repository.GetAllDrivers(LbInfo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddNewDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormInvalid())
                {
                    repository.CreateDriver(new Driver
                        (
                            TbFirstName.Text.Trim(),
                            TbLastName.Text.Trim(),
                            TbTelephone.Text.Trim(),
                            int.Parse(TbDrivingLicenceNumber.Text.Trim())
                        ));
                    ShowListBoxData(LbDrivers, repository.GetAllDrivers(LbInfo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 'Travel warrants' tab page

        private void LbTravelWarrants_SelectedIndexChanged(object sender, EventArgs e)
            => ShowTravelWarrantForm(LbTravelWarrants.SelectedItem as TravelWarrant);

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            try
            {
                LbTravelWarrants.DataSource = repository.GetAllTravelWarrants()
                      .Where(tw => tw.TravelWarrantType == TravelWarrantType.CLOSED)
                      .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnActive_Click(object sender, EventArgs e)
        {
            try
            {
                LbTravelWarrants.DataSource = repository.GetAllTravelWarrants()
                      .Where(tw => tw.TravelWarrantType == TravelWarrantType.ACTIVE)
                      .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFuture_Click(object sender, EventArgs e)
        {
            try
            {
                LbTravelWarrants.DataSource = repository.GetAllTravelWarrants()
                      .Where(tw => tw.TravelWarrantType == TravelWarrantType.FUTURE)
                      .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            try
            {
                LbTravelWarrants.DataSource = repository.GetAllTravelWarrants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteTW_Click(object sender, EventArgs e)
        {
            try
            {
                repository.DeleteTravelWarrant(int.Parse(TbTravelWarrantID.Text.Trim()));
                ShowListBoxData(LbTravelWarrants, repository.GetAllTravelWarrants());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdateTW_Click(object sender, EventArgs e)
        {
            try
            {
                Route route = (LbTravelWarrants.SelectedItem as TravelWarrant).Route;
                route.CityA = CbStartCities.SelectedItem as City;
                route.CityB = CbStopCities.SelectedItem as City;
                route.TimeHours = int.Parse(TbTravelTime.Text.Trim());

                TravelWarrant travelWarrant = new TravelWarrant
                {
                    IDTravelWarrant = int.Parse(TbTravelWarrantID.Text.Trim()),
                    Driver = CbDrivers.SelectedItem as Driver,
                    Car = CbCars.SelectedItem as Car,
                    TravelWarrantType = (TravelWarrantType)CbTravelWarrantType.SelectedIndex,
                    Route = route
                };

                repository.UpdateTravelWarrant(travelWarrant);
                ShowListBoxData(LbTravelWarrants, repository.GetAllTravelWarrants());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateTW_Click(object sender, EventArgs e)
        {
            try
            {
                TravelWarrant travelWarrant = new TravelWarrant
                {
                    IDTravelWarrant = int.Parse(TbTravelWarrantID.Text.Trim()),
                    Driver = CbDrivers.SelectedItem as Driver,
                    Car = CbCars.SelectedItem as Car,
                    TravelWarrantType = (TravelWarrantType)CbTravelWarrantType.SelectedIndex,
                    Route = new Route
                    {
                        TimeHours = int.Parse(TbTravelTime.Text.Trim()),
                        CityA = CbStartCities.SelectedItem as City,
                        CityB = CbStopCities.SelectedItem as City,
                    }
                };

                repository.CreateTravelWarrant(travelWarrant);
                ShowListBoxData(LbTravelWarrants, repository.GetAllTravelWarrants());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 'Routes' tab page

        private void LoadRoutesCbs()
        {
            try
            {
                CbCitiesA.DataSource = repository.GetAllCities();
                CbCitiesB.DataSource = repository.GetAllCities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbTwsRoutes_SelectedIndexChanged(object sender, EventArgs e)
        => ShowRouteForm(LbRoutes.SelectedItem as Route);

        private void ShowRouteForm(Route route)
        {
            TbIdRoute.Text = route.IDRoute.ToString();
            TbTimeHours.Text = route.TimeHours.ToString();
            TbKilometers.Text = route.Kilometers.ToString();
            TbAvgSpeed.Text = route.AvgSpeed.ToString();
            TbFuelUsed.Text = route.FuelUsed.ToString();

            CbCitiesA.SelectedIndex = CbStartCities.Items.
                Cast<City>()
                .ToList()
                .FindIndex(c => c.IDCity == route.CityA.IDCity);

            CbCitiesB.SelectedIndex = CbStartCities.Items.
                Cast<City>()
                .ToList()
                .FindIndex(c => c.IDCity == route.CityB.IDCity);
        }

        private void BtnExportXml_Click(object sender, EventArgs e)
        {
            DataSet ds = repository.SelectRouteData((LbRoutes.SelectedItem as Route).IDRoute);
            ds.WriteXml(XML_ROUTE_PATH, XmlWriteMode.WriteSchema);
        }

        private void BtnImportXml_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XML_ROUTE_PATH);

                StringBuilder routeString = new StringBuilder();

                ds.Tables[0].Rows
                    .Cast<DataRow>()
                    .ToList()
                    .ForEach(routeRow =>
                    {
                        routeString.Append($"IDRotue: {routeRow[nameof(Route.IDRoute)]} {Environment.NewLine}");
                        routeString.Append($"Hours: {routeRow[nameof(Route.TimeHours)]} {Environment.NewLine}");
                        routeString.Append($"Kilometers: {routeRow[nameof(Route.Kilometers)]} {Environment.NewLine}");
                        routeString.Append($"Start: {routeRow[nameof(Route.CityA)]} {Environment.NewLine}");
                        routeString.Append($"Stop: {routeRow[nameof(Route.CityB)]} {Environment.NewLine}");
                        routeString.Append($"Average speed: {routeRow[nameof(Route.AvgSpeed)]} {Environment.NewLine}");
                        routeString.Append($"Fuel used (L): {routeRow[nameof(Route.FuelUsed)]} {Environment.NewLine}");
                    });

                MessageBox.Show(routeString.ToString(), "Route");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void BtnCreateRoute_Click(object sender, EventArgs e)
        {
            try
            {
                repository.CreateRoute(new Route
                {
                    TimeHours = int.Parse(TbTimeHours.Text.Trim()),
                    Kilometers = int.Parse(TbKilometers.Text.Trim()),
                    CityA = new City
                    {
                        IDCity = (CbCitiesA.SelectedItem as City).IDCity,
                        Name = (CbCitiesA.SelectedItem as City).Name
                    },
                    CityB = new City
                    {
                        IDCity = (CbCitiesB.SelectedItem as City).IDCity,
                        Name = (CbCitiesB.SelectedItem as City).Name
                    },
                    AvgSpeed = int.Parse(TbAvgSpeed.Text.Trim()),
                    FuelUsed = int.Parse(TbFuelUsed.Text.Trim()),
                });

                CleanRoutesForm();
                ShowListBoxData(LbRoutes, repository.GetAllRoutes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanRoutesForm()
            => TbPageRoutes.Controls.OfType<TextBox>().ToList().ForEach(c => c.Text = string.Empty);

        private void BtnUpdateRoute_Click(object sender, EventArgs e)
        {
            try
            {
                repository.UpdateRoute(new Route
                {
                    IDRoute = int.Parse(TbIdRoute.Text.Trim()),
                    TimeHours = int.Parse(TbTimeHours.Text.Trim()),
                    Kilometers = int.Parse(TbKilometers.Text.Trim()),
                    CityA = new City
                    {
                        IDCity = (CbCitiesA.SelectedItem as City).IDCity,
                        Name = (CbCitiesA.SelectedItem as City).Name
                    },
                    CityB = new City
                    {
                        IDCity = (CbCitiesB.SelectedItem as City).IDCity,
                        Name = (CbCitiesB.SelectedItem as City).Name
                    },
                    AvgSpeed = int.Parse(TbAvgSpeed.Text.Trim()),
                    FuelUsed = int.Parse(TbFuelUsed.Text.Trim()),
                });

                CleanRoutesForm();
                ShowListBoxData(LbRoutes, repository.GetAllRoutes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteRoute_Click(object sender, EventArgs e)
        {
            try
            {
                repository.DeleteRoute(int.Parse(TbIdRoute.Text.Trim()));
                CleanRoutesForm();
                ShowListBoxData(LbRoutes, repository.GetAllRoutes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 'Setup' tab page

        private void BtnInsertExampleRecords_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Insert records?") == DialogResult.OK)
            {
                try
                {
                    repository.InsertExampleRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnCleanDatabaseRecords_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clean database records?") == DialogResult.OK)
            {
                try
                {
                    repository.CleanDatabaseRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDbToXml_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dump database to XML?") == DialogResult.OK)
            {
                try
                {
                    DumpDatabaseToXml();
                    repository.CleanDatabaseRecordsAfterExport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DumpDatabaseToXml()
        {
            using (XmlWriter writer = CreateWriter())
            {
                writer.WriteStartDocument();
                writer.WriteStartElement($"{nameof(TravelWarrant)}s");

                DataTable dtTravelWarrants = repository.GetAllDatabaseData();
                dtTravelWarrants.Rows.Cast<DataRow>()
                    .ToList()
                    .ForEach(dr =>
                    {
                        // TravelWarrant
                        writer.WriteStartElement(nameof(TravelWarrant));
                        writer.WriteAttributeString(nameof(TravelWarrant.IDTravelWarrant), dr[nameof(TravelWarrant.IDTravelWarrant)].ToString());

                        // TravelWarrantType
                        writer.WriteStartElement(nameof(TravelWarrantType));
                        writer.WriteAttributeString($"ID{nameof(TravelWarrantType)}", dr[$"ID{nameof(TravelWarrantType)}"].ToString());
                        writer.WriteString(((TravelWarrantType)dr["IDTravelWarrantType"]).ToString());
                        writer.WriteEndElement();

                        // Driver
                        writer.WriteStartElement(nameof(Driver));
                        writer.WriteElementString(nameof(Driver.IDDriver), dr[nameof(Driver.IDDriver)].ToString());
                        writer.WriteElementString(nameof(Driver.Firstname), dr[nameof(Driver.Firstname)].ToString());
                        writer.WriteElementString(nameof(Driver.Lastname), dr[nameof(Driver.Lastname)].ToString());
                        writer.WriteElementString(nameof(Driver.Telephone), dr[nameof(Driver.Telephone)].ToString());
                        writer.WriteElementString(nameof(Driver.DrivingLicenceNumber), dr[nameof(Driver.DrivingLicenceNumber)].ToString());
                        writer.WriteEndElement();

                        // Car
                        writer.WriteStartElement(nameof(Car));
                        writer.WriteElementString(nameof(Car.IDCar), dr[nameof(Car.IDCar)].ToString());
                        writer.WriteElementString(nameof(Car.Brand), dr[nameof(Car.Brand)].ToString());
                        writer.WriteElementString(nameof(Car.Model), dr[nameof(Car.Model)].ToString());
                        writer.WriteElementString(nameof(Car.Year), dr[nameof(Car.Year)].ToString());
                        writer.WriteElementString(nameof(Car.InitialMileage), dr[nameof(Car.InitialMileage)].ToString());
                        writer.WriteEndElement();

                        // Fuel
                        writer.WriteStartElement(nameof(Fuel));
                        writer.WriteElementString(nameof(Fuel.IDFuel), dr[nameof(Fuel.IDFuel)].ToString());
                        writer.WriteElementString(nameof(Fuel.Time), dr[nameof(Fuel.Time)].ToString());
                        writer.WriteElementString($"{nameof(Driver)}ID", dr[$"{nameof(Driver)}ID"].ToString());
                        // writer.WriteElementString($"{nameof(City)}ID", dr[$"{nameof(City)}ID"].ToString());

                        // City
                        writer.WriteStartElement(nameof(City));
                        writer.WriteAttributeString($"{nameof(City)}ID", dr[nameof(City.IDCity)].ToString());
                        writer.WriteElementString(nameof(City.Name), dr[nameof(City.Name)].ToString());
                        writer.WriteElementString(nameof(City.Latitude), dr[nameof(City.Latitude)].ToString());
                        writer.WriteElementString(nameof(City.Longitude), dr[nameof(City.Longitude)].ToString());
                        writer.WriteElementString(nameof(City.Country), dr[nameof(City.Country)].ToString());
                        writer.WriteElementString(nameof(City.CountryCode), dr[nameof(City.CountryCode)].ToString());
                        writer.WriteElementString(nameof(City.County), dr[nameof(City.County)].ToString());
                        writer.WriteElementString(nameof(City.Capital), dr[nameof(City.Capital)].ToString());
                        writer.WriteElementString(nameof(City.Population), dr[nameof(City.Population)].ToString());
                        writer.WriteElementString(nameof(City.PopulationProper), dr[nameof(City.PopulationProper)].ToString());
                        writer.WriteEndElement();

                        writer.WriteElementString(nameof(Fuel.Amount), dr[nameof(Fuel.Amount)].ToString());
                        writer.WriteElementString(nameof(Fuel.Price), dr[nameof(Fuel.Price)].ToString());
                        writer.WriteEndElement();

                        // Route
                        writer.WriteStartElement(nameof(Route));
                        writer.WriteElementString(nameof(Route.IDRoute), dr[nameof(Route.IDRoute)].ToString());
                        writer.WriteElementString(nameof(Route.TimeHours), dr[nameof(Route.TimeHours)].ToString());
                        writer.WriteElementString($"{nameof(City)}A", dr[$"{nameof(City)}A"].ToString());
                        writer.WriteElementString($"{nameof(City)}B", dr[$"{nameof(City)}B"].ToString());
                        writer.WriteElementString(nameof(Route.Kilometers), dr[nameof(Route.Kilometers)].ToString());
                        writer.WriteElementString(nameof(Route.AvgSpeed), dr[nameof(Route.AvgSpeed)].ToString());
                        writer.WriteElementString(nameof(Route.FuelUsed), dr[nameof(Route.FuelUsed)].ToString());
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                    });

                writer.WriteEndElement();
            }
        }

        private XmlWriter CreateWriter()
            => XmlWriter.Create(XML_DATABASE_PATH, new XmlWriterSettings { Indent = true });

        private void BtnXmlToDb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Restore database from XML?") == DialogResult.OK)
            {
                RestoreData();
            }
        }

        private void RestoreData()
        {
            try
            {
                RestoreRoutes();
                RestoreDrivers();
                RestoreFuels();
                RestoreCars();
                RestoreTravelWarrants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RestoreRoutes()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList routeNodes = root.SelectNodes($"{nameof(TravelWarrant)}/{nameof(Route)}");

            routeNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(rn =>
                {
                    Route route = new Route
                    {
                        IDRoute = int.Parse(rn.SelectSingleNode(nameof(Route.IDRoute)).InnerText),
                        TimeHours = int.Parse(rn.SelectSingleNode(nameof(Route.TimeHours)).InnerText),
                        CityA = new City { IDCity = int.Parse(rn.SelectSingleNode(nameof(Route.CityA)).InnerText) },
                        CityB = new City { IDCity = int.Parse(rn.SelectSingleNode(nameof(Route.CityB)).InnerText) },
                        Kilometers = int.Parse(rn.SelectSingleNode(nameof(Route.Kilometers)).InnerText),
                        AvgSpeed = int.Parse(rn.SelectSingleNode(nameof(Route.AvgSpeed)).InnerText),
                        FuelUsed = int.Parse(rn.SelectSingleNode(nameof(Route.FuelUsed)).InnerText)
                    };
                    repository.CreateRoute(route);
                });
        }

        private XmlDocument LoadDocument()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XML_DATABASE_PATH);
            return doc;
        }

        private void RestoreFuels()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList fuelNodes = root.SelectNodes($"{nameof(TravelWarrant)}/{nameof(Fuel)}");

            fuelNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(fn =>
                {
                    Fuel fuel = new Fuel
                    {
                        IDFuel = int.Parse(fn.SelectSingleNode(nameof(Fuel.IDFuel)).InnerText),
                        Time = DateTime.Parse(fn.SelectSingleNode(nameof(Fuel.Time)).InnerText),
                        Driver = new Driver { IDDriver = int.Parse(fn.SelectSingleNode($"{nameof(Driver)}ID").InnerText) },
                        FuelCity = new City { IDCity = int.Parse(fn.SelectSingleNode($"{nameof(City)}").Attributes[0].Value) },
                        Amount = int.Parse(fn.SelectSingleNode(nameof(Fuel.Amount)).InnerText),
                        Price = int.Parse(fn.SelectSingleNode(nameof(Fuel.Price)).InnerText)
                    };
                    repository.CreateFuel(fuel);
                });
        }

        private void RestoreCars()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList carNodes = root.SelectNodes($"{nameof(TravelWarrant)}/{nameof(Car)}");

            carNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(cn =>
                {
                    Car car = new Car
                    {
                        IDCar = int.Parse(cn.SelectSingleNode(nameof(Car.IDCar)).InnerText),
                        Brand = cn.SelectSingleNode(nameof(Car.Brand)).InnerText,
                        Model = cn.SelectSingleNode(nameof(Car.Model)).InnerText,
                        Year = int.Parse(cn.SelectSingleNode(nameof(Car.Year)).InnerText),
                        InitialMileage = int.Parse(cn.SelectSingleNode(nameof(Car.InitialMileage)).InnerText)
                    };
                    repository.CreateCar(car);
                });
        }

        private void RestoreDrivers()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList carNodes = root.SelectNodes($"{nameof(TravelWarrant)}/{nameof(Driver)}");

            carNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(cn =>
                {
                    Driver driver = new Driver
                    {
                        IDDriver = int.Parse(cn.SelectSingleNode(nameof(Driver.IDDriver)).InnerText),
                        Firstname = cn.SelectSingleNode(nameof(Driver.Firstname)).InnerText,
                        Lastname = cn.SelectSingleNode(nameof(Driver.Lastname)).InnerText,
                        Telephone = cn.SelectSingleNode(nameof(Driver.Telephone)).InnerText,
                        DrivingLicenceNumber = int.Parse(cn.SelectSingleNode(nameof(Driver.DrivingLicenceNumber)).InnerText)
                    };

                    repository.CreateDriver(driver);
                });
        }

        private void RestoreTravelWarrants()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList travelWarrantNodes = root.SelectNodes($"{nameof(TravelWarrant)}");

            travelWarrantNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(twn =>
                {
                    TravelWarrant travelWarrant = new TravelWarrant
                    {
                        IDTravelWarrant = int.Parse(twn.Attributes[0].Value),
                        TravelWarrantType = (TravelWarrantType)int.Parse(twn.SelectSingleNode(nameof(TravelWarrantType)).Attributes[0].Value),
                        Driver = new Driver { IDDriver = int.Parse(twn.SelectSingleNode($"{nameof(Driver)}/{nameof(Driver.IDDriver)}").InnerText) },
                        Car = new Car { IDCar = int.Parse(twn.SelectSingleNode($"{nameof(Car)}/{nameof(Car.IDCar)}").InnerText) },
                        Fuel = new Fuel { IDFuel = int.Parse(twn.SelectSingleNode($"{nameof(Fuel)}/{nameof(Fuel.IDFuel)}").InnerText) },
                        Route = new Route { IDRoute = int.Parse(twn.SelectSingleNode($"{nameof(Route)}/{nameof(Route.IDRoute)}").InnerText) }
                    };
                    repository.InsertTravelWarrant(travelWarrant);
                });
        }

        #endregion

        #region Helper functions

        private void ShowListBoxData<T>(ListBox listBox, IList<T> collection) => listBox.DataSource = collection;

        private bool FormInvalid() => TbPageDrivers.Controls.OfType<TextBox>().Any(c => c.Enabled && string.IsNullOrWhiteSpace(c.Text));

        private void ShowDriverForm(Driver driver)
        {
            TbIdDriver.Text = driver.IDDriver.ToString();
            TbFirstName.Text = driver.Firstname;
            TbLastName.Text = driver.Lastname;
            TbTelephone.Text = driver.Telephone;
            TbDrivingLicenceNumber.Text = driver.DrivingLicenceNumber.ToString();
        }

        private void LoadTravelWarrantCbs()
        {
            try
            {
                CbDrivers.DataSource = repository.GetAllDrivers(LbInfo);
                CbCars.DataSource = repository.GetAllCars();
                CbStartCities.DataSource = repository.GetAllCities();
                CbStopCities.DataSource = repository.GetAllCities();
                CbTravelWarrantType.DataSource = Enum.GetValues(typeof(TravelWarrantType));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTravelWarrantForm(TravelWarrant travelWarrant)
        {
            TbTravelWarrantID.Text = travelWarrant.IDTravelWarrant.ToString();
            TbTravelTime.Text = travelWarrant.Route.TimeHours.ToString();

            CbDrivers.SelectedIndex = CbDrivers.Items
                .Cast<Driver>()
                .ToList()
                .FindIndex(d => d.IDDriver == travelWarrant.Driver.IDDriver);

            CbCars.SelectedIndex = CbCars.Items
                .Cast<Car>()
                .ToList()
                .FindIndex(c => c.IDCar == travelWarrant.Car.IDCar);

            CbStartCities.SelectedIndex = CbStartCities.Items.
                Cast<City>()
                .ToList()
                .FindIndex(c => c.Name == travelWarrant.Route.CityA.Name);

            CbStopCities.SelectedIndex = CbStopCities.Items
                .Cast<City>()
                .ToList()
                .FindIndex(c => c.Name == travelWarrant.Route.CityB.Name);

            CbTravelWarrantType.SelectedIndex = CbTravelWarrantType.Items
                .Cast<TravelWarrantType>()
                .ToList()
                .FindIndex(twt => twt == travelWarrant.TravelWarrantType);
        }

        #endregion
    }
}
