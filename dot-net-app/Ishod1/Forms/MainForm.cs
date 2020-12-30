using Ishod1.Dao;
using Ishod1.Factory;
using Ishod1.Model;
using Ishod1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ishod1.Forms
{
    public partial class MainForm : Form
    {
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
                    LoadAllComboBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
        #endregion

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
                route.StartCity = CbStartCities.SelectedItem as City;
                route.StopCity = CbStopCities.SelectedItem as City;
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
                        StartCity = CbStartCities.SelectedItem as City,
                        StopCity = CbStopCities.SelectedItem as City,
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

        private void LoadAllComboBoxes()
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
                .FindIndex(c => c.Name == travelWarrant.Route.StartCity.Name);

            CbStopCities.SelectedIndex = CbStopCities.Items
                .Cast<City>()
                .ToList()
                .FindIndex(c => c.Name == travelWarrant.Route.StopCity.Name);

            CbTravelWarrantType.SelectedIndex = CbTravelWarrantType.Items
                .Cast<TravelWarrantType>()
                .ToList()
                .FindIndex(twt => twt == travelWarrant.TravelWarrantType);
        }

        #endregion
    }
}
