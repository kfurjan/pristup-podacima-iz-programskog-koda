using Ishod1.Model;
using System.Collections.Generic;

namespace Ishod1.Repository
{
    interface IRepository
    {
        public int InsertExampleRecords();
        public int CleanDatabaseRecords();
        public IList<Driver> GetAllDrivers(System.Windows.Forms.Label label);
        public int CreateDriver(Driver driver);
        public int UpdateDriver(Driver driver);
        public int DeleteDriver(int idDriver);
        public IList<TravelWarrant> GetAllTravelWarrants();
        public IList<Car> GetAllCars();
        public IList<City> GetAllCities();
        public int CreateTravelWarrant(TravelWarrant travelWarrant);
        public int UpdateTravelWarrant(TravelWarrant travelWarrant);
        public int DeleteTravelWarrant(int travelWarrant);
    }
}
