package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class Fuel {

    public int idFuel;
    public String time;
    public int driverId;
    public int cityId;
    public int amount;
    public int price;

    public Fuel(String time, int driverId, int cityId, int amount, int price) {
        this.time = time;
        this.driverId = driverId;
        this.cityId = cityId;
        this.amount = amount;
        this.price = price;
    }

    public Fuel(int idFuel, String time, int driverId, int cityId, int amount, int price) {
        this(time, driverId, cityId, amount, price);
        this.idFuel = idFuel;
    }

    public int getIdFuel() {
        return idFuel;
    }

    public void setIdFuel(int idFuel) {
        this.idFuel = idFuel;
    }

    public String getTime() {
        return time;
    }

    public void setTime(String time) {
        this.time = time;
    }

    public int getDriver() {
        return driverId;
    }

    public void setDriver(int driverId) {
        this.driverId = driverId;
    }

    public int getFuelCity() {
        return cityId;
    }

    public void setFuelCity(int cityId) {
        this.cityId = cityId;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return "Fuel{" + "idFuel=" + idFuel + ", time=" + time + ", driverId=" + driverId + ", cityId=" + cityId + ", amount=" + amount + ", price=" + price + '}';
    }
}
