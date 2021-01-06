using Ishod1.Model;
using System.Collections.Generic;
using System.Data;

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
        public DataSet SelectRouteData(int idRoute);
        public IList<Route> GetAllRoutes();
        public int CreateRoute(Route route);
        public int UpdateRoute(Route route);
        public int DeleteRoute(int idRoute);
        public DataTable GetAllDatabaseData();
        public int CleanDatabaseRecordsAfterExport();
        public int CreateFuel(Fuel fuel);
        public int CreateCar(Car car);
        public int InsertTravelWarrant(TravelWarrant travelWarrant);
    }
}
