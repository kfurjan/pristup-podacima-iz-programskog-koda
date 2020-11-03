package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class City {

    public int idCity;
    public String name;
    public double latitude;
    public double longitude;
    public String country;
    public String countryCode;
    public String county;
    public String capital;
    public int population;
    public int populationProper;

    public City(String name, double latitude, double longitude, String country, String countryCode, String county, String capital, int population, int populationProper) {
        this.name = name;
        this.latitude = latitude;
        this.longitude = longitude;
        this.country = country;
        this.countryCode = countryCode;
        this.county = county;
        this.capital = capital;
        this.population = population;
        this.populationProper = populationProper;
    }

    public City(int idCity, String name, double latitude, double longitude, String country, String countryCode, String county, String capital, int population, int populationProper) {
        this(name, latitude, longitude, country, countryCode, county, capital, population, populationProper);
        this.idCity = idCity;
    }

    public int getIdCity() {
        return idCity;
    }

    public void setIdCity(int idCity) {
        this.idCity = idCity;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getLatitude() {
        return latitude;
    }

    public void setLatitude(double latitude) {
        this.latitude = latitude;
    }

    public double getLongitude() {
        return longitude;
    }

    public void setLongitude(double longitude) {
        this.longitude = longitude;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public String getCountryCode() {
        return countryCode;
    }

    public void setCountryCode(String countryCode) {
        this.countryCode = countryCode;
    }

    public String getCounty() {
        return county;
    }

    public void setCounty(String county) {
        this.county = county;
    }

    public String getCapital() {
        return capital;
    }

    public void setCapital(String capital) {
        this.capital = capital;
    }

    public int getPopulation() {
        return population;
    }

    public void setPopulation(int population) {
        this.population = population;
    }

    public int getPopulationProper() {
        return populationProper;
    }

    public void setPopulationProper(int populationProper) {
        this.populationProper = populationProper;
    }

    @Override
    public String toString() {
        return "City{" + "idCity=" + idCity + ", name=" + name + '}';
    }
}
