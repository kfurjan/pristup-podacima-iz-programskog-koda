package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class Car {

    public int idCar;
    public String brand;
    public String model;
    public int year;
    public int initialMileage;

    public Car(String brand, String model, int year, int initialMileage) {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.initialMileage = initialMileage;
    }

    public Car(int idCar, String brand, String model, int year, int initialMileage) {
        this(brand, model, year, initialMileage);
        this.idCar = idCar;
    }

    public int getIdCar() {
        return idCar;
    }

    public void setIdCar(int idCar) {
        this.idCar = idCar;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public int getInitialMileage() {
        return initialMileage;
    }

    public void setInitialMileage(int initialMileage) {
        this.initialMileage = initialMileage;
    }

    @Override
    public String toString() {
        return "Car{" + "idCar=" + idCar + ", brand=" + brand + ", model=" + model + '}';
    }
}
