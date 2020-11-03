package hr.algebra.csv;

import hr.algebra.model.Car;
import hr.algebra.model.City;
import hr.algebra.model.Driver;
import hr.algebra.model.Fuel;
import hr.algebra.model.Route;
import hr.algebra.model.TravelWarrant;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author efurkev
 */
public final class ReadCsv {

    private static final String DRIVERS_CSV = "driver-mock-data.csv";
    private static final String CARS_CSV = "car-mock-data.csv";
    private static final String CITIES_CSV = "city-mock-data.csv";
    private static final String FUELS_CSV = "fuel-mock-data.csv";
    private static final String ROUTES_CSV = "route-mock-data.csv";
    private static final String TRAVEL_WARRANTS_CSV = "travelwarrant-mock-data.csv";
    private static final String SEPARATOR = ",";

    private ReadCsv() {
    }

    public static List<Driver> getDriverData() throws IOException {
        List<Driver> drivers = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(DRIVERS_CSV))) {

            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                drivers.add(new Driver(
                        Integer.parseInt(data[0]),
                        data[1],
                        data[2],
                        data[3],
                        Integer.parseInt(data[4])));
            }
        }

        return drivers;
    }

    public static List<Car> getCarData() throws IOException {
        List<Car> cars = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(CARS_CSV))) {

            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                cars.add(new Car(
                        Integer.parseInt(data[0]),
                        data[1],
                        data[2],
                        Integer.parseInt(data[3]),
                        Integer.parseInt(data[4])));
            }
        }

        return cars;
    }

    public static List<City> getCityData() throws IOException {
        List<City> cities = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(CITIES_CSV))) {

            int idCity = 3;
            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                cities.add(new City(
                        ++idCity,
                        data[0],
                        Double.parseDouble(data[1]),
                        Double.parseDouble(data[2]),
                        data[3],
                        data[4],
                        data[5],
                        data[6],
                        0,
                        0
                ));
            }
        }

        return cities;
    }

    public static List<Fuel> getFuelData() throws IOException {
        List<Fuel> fuels = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(FUELS_CSV))) {

            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                fuels.add(new Fuel(
                        Integer.parseInt(data[0]),
                        data[1],
                        Integer.parseInt(data[2]),
                        Integer.parseInt(data[3]),
                        Integer.parseInt(data[4]),
                        Integer.parseInt(data[5])
                ));
            }
        }

        return fuels;
    }

    public static List<Route> getRouteData() throws IOException {
        List<Route> routes = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(ROUTES_CSV))) {

            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                routes.add(new Route(
                        Integer.parseInt(data[0]),
                        Integer.parseInt(data[1]),
                        Integer.parseInt(data[2]),
                        Integer.parseInt(data[3]),
                        Integer.parseInt(data[4]),
                        Integer.parseInt(data[5]),
                        Integer.parseInt(data[6])
                ));
            }
        }

        return routes;
    }

    public static List<TravelWarrant> getTravelWarrantData() throws IOException {
        List<TravelWarrant> travelWarrants = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(TRAVEL_WARRANTS_CSV))) {

            int header = 0;
            String line;
            while ((line = br.readLine()) != null) {
                if (++header == 1) {
                    continue;
                }

                String[] data = line.split(SEPARATOR);
                travelWarrants.add(new TravelWarrant(
                        Integer.parseInt(data[0]),
                        Integer.parseInt(data[1]),
                        Integer.parseInt(data[2]),
                        Integer.parseInt(data[3]),
                        Integer.parseInt(data[4]),
                        Integer.parseInt(data[5])
                ));
            }
        }

        return travelWarrants;
    }
}
