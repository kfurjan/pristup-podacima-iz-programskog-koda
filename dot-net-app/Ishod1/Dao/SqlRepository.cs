using Ishod1.Model;
using Ishod1.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Transactions;

namespace Ishod1.Dao
{
    class SqlRepository : IRepository
    {
        private const string ID_DRIVER = "@idDriver";
        private const string FIRST_NAME = "@firstName";
        private const string LAST_NAME = "@lastName";
        private const string TELEPHONE = "@telephone";
        private const string DRIVING_LICENCE_NUMBER = "@drivingLicenceNumber";
        private const string ID_TRAVEL_WARRANT = "@idTravelWarrant";
        private const string ID_CAR = "@idCar";
        private const string ID_TRAVEL_WARRANT_TYPE = "@idTravelWarrantType";
        private const string ID_ROUTE = "@idRoute";
        private const string ID_CITY_A = "@idCityA";
        private const string ID_CITY_B = "@idCityB";
        private const string TIME_HOURS = "@timeHours";
        private static readonly string Cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public int CleanDatabaseRecords() => NoParamsStoredProcedure(MethodBase.GetCurrentMethod().Name);

        public int InsertExampleRecords() => NoParamsStoredProcedure(MethodBase.GetCurrentMethod().Name);

        private static int NoParamsStoredProcedure(string procedureName)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = procedureName;
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public IList<Driver> GetAllDrivers()
        {
            IList<Driver> drivers = new List<Driver>();

            using (SqlConnection con = new SqlConnection(Cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            drivers.Add(new Driver
                            (
                                (int)dr[nameof(Driver.IDDriver)],
                                dr[nameof(Driver.Firstname)].ToString(),
                                dr[nameof(Driver.Lastname)].ToString(),
                                dr[nameof(Driver.Telephone)].ToString(),
                                (int)dr[nameof(Driver.DrivingLicenceNumber)]
                            ));
                        }
                    }
                }
            }

            return drivers;
        }

        public int CreateDriver(Driver driver)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(FIRST_NAME, driver.Firstname);
                        cmd.Parameters.AddWithValue(LAST_NAME, driver.Lastname);
                        cmd.Parameters.AddWithValue(TELEPHONE, driver.Telephone);
                        cmd.Parameters.AddWithValue(DRIVING_LICENCE_NUMBER, driver.DrivingLicenceNumber);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public int UpdateDriver(Driver driver)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_DRIVER, driver.IDDriver);
                        cmd.Parameters.AddWithValue(FIRST_NAME, driver.Firstname);
                        cmd.Parameters.AddWithValue(LAST_NAME, driver.Lastname);
                        cmd.Parameters.AddWithValue(TELEPHONE, driver.Telephone);
                        cmd.Parameters.AddWithValue(DRIVING_LICENCE_NUMBER, driver.DrivingLicenceNumber);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public int DeleteDriver(int idDriver)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_DRIVER, idDriver);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public IList<TravelWarrant> GetAllTravelWarrants()
        {
            IList<TravelWarrant> travelWarrants = new List<TravelWarrant>();

            using (SqlConnection con = new SqlConnection(Cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Driver driver = new Driver
                            (
                                (int)dr[nameof(Driver.IDDriver)],
                                dr[nameof(Driver.Firstname)].ToString(),
                                dr[nameof(Driver.Lastname)].ToString(),
                                dr[nameof(Driver.Telephone)].ToString(),
                                (int)dr[nameof(Driver.DrivingLicenceNumber)]
                            );

                            Car car = new Car
                            (
                                (int)dr[nameof(Car.IDCar)],
                                dr[nameof(Car.Brand)].ToString(),
                                dr[nameof(Car.Model)].ToString(),
                                (int)dr[nameof(Car.Year)],
                                (int)dr[nameof(Car.InitialMileage)]
                            );

                            Fuel fuel = new Fuel
                            (
                                (int)dr[nameof(Fuel.IDFuel)],
                                DateTime.Parse(dr[nameof(Fuel.Time)].ToString()),
                                driver,
                                new City { Name = dr[nameof(Fuel.FuelCity)].ToString() },
                                (int)dr[nameof(Fuel.Amount)],
                                (int)dr[nameof(Fuel.Price)]
                            );

                            Route route = new Route
                            (
                                (int)dr[nameof(Route.IDRoute)],
                                (int)dr[nameof(Route.TimeHours)],
                                new City { Name = dr[nameof(Route.StartCity)].ToString() },
                                new City { Name = dr[nameof(Route.StopCity)].ToString() },
                                (int)dr[nameof(Route.Kilometers)],
                                (int)dr[nameof(Route.AvgSpeed)],
                                (int)dr[nameof(Route.FuelUsed)]
                            );

                            travelWarrants.Add(new TravelWarrant
                            (
                                (int)dr[nameof(TravelWarrant.IDTravelWarrant)],
                                driver,
                                car,
                                (TravelWarrantType)dr["IDTravelWarrantType"],
                                fuel,
                                route
                            ));
                        }
                    }
                }
            }

            return travelWarrants;
        }

        public IList<Car> GetAllCars()
        {
            IList<Car> cars = new List<Car>();

            using (SqlConnection con = new SqlConnection(Cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cars.Add(new Car
                            (
                                (int)dr[nameof(Car.IDCar)],
                                dr[nameof(Car.Brand)].ToString(),
                                dr[nameof(Car.Model)].ToString(),
                                (int)dr[nameof(Car.Year)],
                                (int)dr[nameof(Car.InitialMileage)]
                            ));
                        }
                    }
                }
            }

            return cars;
        }

        public IList<City> GetAllCities()
        {
            IList<City> cities = new List<City>();

            using (SqlConnection con = new SqlConnection(Cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cities.Add(new City
                            (
                                (int)dr[nameof(City.IDCity)],
                                dr[nameof(City.Name)].ToString(),
                                (double)dr[nameof(City.Latitude)],
                                (double)dr[nameof(City.Longitude)],
                                dr[nameof(City.Country)].ToString(),
                                dr[nameof(City.CountryCode)].ToString(),
                                dr[nameof(City.County)].ToString(),
                                dr[nameof(City.Capital)].ToString(),
                                (int)dr[nameof(City.Population)],
                                (int)dr[nameof(City.PopulationProper)]
                            ));
                        }
                    }
                }
            }

            return cities;
        }

        public int DeleteTravelWarrant(int idTravelWarrant)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_TRAVEL_WARRANT, idTravelWarrant);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public int CreateTravelWarrant(TravelWarrant travelWarrant)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_DRIVER, travelWarrant.Driver.IDDriver);
                        cmd.Parameters.AddWithValue(ID_CAR, travelWarrant.Car.IDCar);
                        cmd.Parameters.AddWithValue(ID_TRAVEL_WARRANT_TYPE, (int)travelWarrant.TravelWarrantType + 1);
                        cmd.Parameters.AddWithValue(ID_CITY_A, travelWarrant.Route.StartCity.IDCity);
                        cmd.Parameters.AddWithValue(ID_CITY_B, travelWarrant.Route.StopCity.IDCity);
                        cmd.Parameters.AddWithValue(TIME_HOURS, travelWarrant.Route.TimeHours);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        public int UpdateTravelWarrant(TravelWarrant travelWarrant)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(Cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_TRAVEL_WARRANT, travelWarrant.IDTravelWarrant);
                        cmd.Parameters.AddWithValue(ID_DRIVER, travelWarrant.Driver.IDDriver);
                        cmd.Parameters.AddWithValue(ID_CAR, travelWarrant.Car.IDCar);
                        cmd.Parameters.AddWithValue(ID_TRAVEL_WARRANT_TYPE, (int)travelWarrant.TravelWarrantType + 1);
                        cmd.Parameters.AddWithValue(ID_ROUTE, travelWarrant.Route.IDRoute);
                        cmd.Parameters.AddWithValue(ID_CITY_A, travelWarrant.Route.StartCity.IDCity);
                        cmd.Parameters.AddWithValue(ID_CITY_B, travelWarrant.Route.StopCity.IDCity);
                        cmd.Parameters.AddWithValue(TIME_HOURS, travelWarrant.Route.TimeHours);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }
    }
}
