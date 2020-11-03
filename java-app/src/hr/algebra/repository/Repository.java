package hr.algebra.repository;

import hr.algebra.model.Car;
import hr.algebra.model.City;
import hr.algebra.model.Driver;
import hr.algebra.model.Fuel;
import hr.algebra.model.Route;
import hr.algebra.model.TravelWarrant;
import java.util.List;

/**
 *
 * @author efurkev
 */
public interface Repository {

    void importDriverData(List<Driver> drivers, int batchSize);

    void importCarData(List<Car> cars, int batchSize);

    void importCityData(List<City> cities, int batchSize);

    void importFuelData(List<Fuel> fuels, int batchSize);

    void importRouteData(List<Route> routes, int batchSize);

    void importTravelWarrantData(List<TravelWarrant> travelWarrants, int batchSize);
}
