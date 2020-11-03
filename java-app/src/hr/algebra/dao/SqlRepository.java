package hr.algebra.dao;

import hr.algebra.model.Car;
import hr.algebra.model.City;
import hr.algebra.model.Driver;
import hr.algebra.model.Fuel;
import hr.algebra.model.Route;
import hr.algebra.model.TravelWarrant;
import hr.algebra.repository.Repository;
import hr.algebra.singleton.DataSourceSingleton;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sql.DataSource;

/**
 *
 * @author efurkev
 */
public class SqlRepository implements Repository {

    private static final String INSERT_DRIVER = "{ CALL InsertDriver (?,?,?,?,?) }";
    private static final String INSERT_CAR = "{ CALL InsertCar (?,?,?,?,?) }";
    private static final String INSERT_CITY = "{ CALL InsertCity (?,?,?,?,?,?,?,?,?,?) }";
    private static final String INSERT_FUEL = "{ CALL InsertFuel (?,?,?,?,?,?) }";
    private static final String INSERT_ROUTE = "{ CALL InsertRoute (?,?,?,?,?,?,?) }";
    private static final String INSERT_TRAVEL_WARRANT = "{ CALL InsertTravelWarrant (?,?,?,?,?,?) }";

    @Override
    public void importDriverData(List<Driver> drivers, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_DRIVER)) {

            int counter = 0;
            for (Driver driver : drivers) {
                stmt.setInt(1, driver.getIdDriver());
                stmt.setString(2, driver.getFirstname());
                stmt.setString(3, driver.getLastname());
                stmt.setString(4, driver.getTelephone());
                stmt.setInt(5, driver.getDrivingLicenceNumber());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void importCarData(List<Car> cars, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_CAR)) {

            int counter = 0;
            for (Car car : cars) {
                stmt.setInt(1, car.getIdCar());
                stmt.setString(2, car.getBrand());
                stmt.setString(3, car.getModel());
                stmt.setInt(4, car.getYear());
                stmt.setInt(5, car.getInitialMileage());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void importCityData(List<City> cities, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_CITY)) {

            int counter = 0;
            for (City city : cities) {
                stmt.setInt(1, city.getIdCity());
                stmt.setString(2, city.getName());
                stmt.setDouble(3, city.getLatitude());
                stmt.setDouble(4, city.getLongitude());
                stmt.setString(5, city.getCountry());
                stmt.setString(6, city.getCountryCode());
                stmt.setString(7, city.getCounty());
                stmt.setString(8, city.getCapital());
                stmt.setInt(9, city.getPopulation());
                stmt.setInt(10, city.getPopulationProper());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void importFuelData(List<Fuel> fuels, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_FUEL)) {

            int counter = 0;
            for (Fuel fuel : fuels) {
                stmt.setInt(1, fuel.getIdFuel());
                stmt.setString(2, fuel.getTime());
                stmt.setInt(3, fuel.getDriver());
                stmt.setInt(4, fuel.getFuelCity());
                stmt.setInt(5, fuel.getAmount());
                stmt.setInt(6, fuel.getPrice());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void importRouteData(List<Route> routes, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_ROUTE)) {

            int counter = 0;
            for (Route route : routes) {
                stmt.setInt(1, route.getIdRoute());
                stmt.setInt(2, route.getTimeHours());
                stmt.setInt(3, route.getStartCity());
                stmt.setInt(4, route.getStopCity());
                stmt.setInt(5, route.getKilometers());
                stmt.setInt(6, route.getAvgSpeed());
                stmt.setInt(7, route.getFuelUsed());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void importTravelWarrantData(List<TravelWarrant> travelWarrants, int batchSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                CallableStatement stmt = con.prepareCall(INSERT_TRAVEL_WARRANT)) {

            int counter = 0;
            for (TravelWarrant travelWarrant : travelWarrants) {
                stmt.setInt(1, travelWarrant.getIdTravelWarrant());
                stmt.setInt(2, travelWarrant.getDriverId());
                stmt.setInt(3, travelWarrant.getCarId());
                stmt.setInt(4, travelWarrant.getTravelWarrantTypeId());
                stmt.setInt(5, travelWarrant.getFuelId());
                stmt.setInt(6, travelWarrant.getRouteId());
                stmt.addBatch();
                if (++counter == batchSize) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }
        } catch (SQLException ex) {
            Logger.getLogger(SqlRepository.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
