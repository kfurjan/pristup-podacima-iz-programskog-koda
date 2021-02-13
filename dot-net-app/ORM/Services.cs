using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORM
{
    public partial class Services : Form
    {
        private const string HTML_REPORT_PATH = @"../../report.html";
        private const string HTML_TAG = "<html>";
        private const string HTML_ENCLOSING_TAG = "</html>";
        private const string H2_TAG = "<h2>";
        private const string H2_ENCLOSING_TAG = "</h2>";
        private const string H4_TAG = "<h4>";
        private const string H4_ENCLOSING_TAG = "</h4>";

        public Services()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            using (var db = new ModelContainer())
            {
                LbCars.DataSource = db.Car.ToList();
            }
        }

        private void LbCars_SelectedIndexChanged(object sender, EventArgs e) => LoadServices();

        private void LoadServices()
        {
            using (var db = new ModelContainer())
            {
                CbServices.DataSource = db.Service
                    .ToList()
                    .Where(s => s.CarID == (LbCars.SelectedItem as Car)?.IDCar)
                    .ToList();
            }
        }

        private void CbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbServiceDesc.Text = (CbServices.SelectedItem as Service)?.Description;
            DtpServiceDate.Value = (DateTime)((CbServices.SelectedItem as Service)?.Date);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                db.Service.Add(new Service
                {
                    Description = TbServiceDesc.Text.Trim(),
                    Date = DtpServiceDate.Value,
                    CarID = (LbCars.SelectedItem as Car)?.IDCar,
                });
                db.SaveChanges();
                LoadServices();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var service = CbServices.SelectedItem as Service;
                var dbService = db.Service.FirstOrDefault(s => s.IDService == service.IDService);

                dbService.Description = TbServiceDesc.Text.Trim();
                dbService.Date = DtpServiceDate.Value;

                db.SaveChanges();
                LoadServices();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var service = CbServices.SelectedItem as Service;
                var dbService = db.Service.FirstOrDefault(s => s.IDService == service.IDService);

                db.Service.Remove(dbService);

                db.SaveChanges();
                LoadServices();
            }
        }

        private void BtnHtmlReport_Click(object sender, EventArgs e)
        {
            var report = new StringBuilder();
            report.Append($"{HTML_TAG}{Environment.NewLine}");

            Car car = LbCars.SelectedItem as Car;
            report.Append($"{H2_TAG}{nameof(Car.Brand)}: {car.Brand}{H2_ENCLOSING_TAG}{Environment.NewLine}");
            report.Append($"{H2_TAG}{nameof(Car.Model)}: {car.Model}{H2_ENCLOSING_TAG}{Environment.NewLine}");
            report.Append($"{H4_TAG}{nameof(Car.IDCar)}: {car.IDCar}{H4_ENCLOSING_TAG}{Environment.NewLine}");
            report.Append($"{H4_TAG}{nameof(Car.Year)}: {car.Year}{H4_ENCLOSING_TAG}{Environment.NewLine}");
            report.Append($"{H4_TAG}Mileage: {car.InitialMileage}{H4_ENCLOSING_TAG}{Environment.NewLine}");

            using (var db = new ModelContainer())
            {
                db.Service
                    .ToList()
                    .Where(s => s.CarID == car.IDCar)
                    .ToList()
                    .ForEach(s =>
                {
                    report.Append($"{H2_TAG}Service{H2_ENCLOSING_TAG}{Environment.NewLine}");
                    report.Append($"{H4_TAG}{nameof(Service.Description)}: {s.Description}{H4_ENCLOSING_TAG}{Environment.NewLine}");
                    report.Append($"{H4_TAG}{nameof(Service.Date)}: {s.Date}{H4_ENCLOSING_TAG}{Environment.NewLine}");
                });
            }

            report.Append($"{HTML_ENCLOSING_TAG}{Environment.NewLine}");
            File.WriteAllText(HTML_REPORT_PATH, report.ToString());
        }
    }
}
