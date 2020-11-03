package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class TravelWarrant {

    public int idTravelWarrant;
    public int driverId;
    public int carId;
    public int travelWarrantTypeId;
    public int fuelId;
    public int routeId;

    public TravelWarrant(int driverId, int carId, int travelWarrantTypeId, int fuelId, int routeId) {
        this.driverId = driverId;
        this.carId = carId;
        this.travelWarrantTypeId = travelWarrantTypeId;
        this.fuelId = fuelId;
        this.routeId = routeId;
    }

    public TravelWarrant(int idTravelWarrant, int driverId, int carId, int travelWarrantTypeId, int fuelId, int routeId) {
        this(driverId, carId, travelWarrantTypeId, fuelId, routeId);
        this.idTravelWarrant = idTravelWarrant;
    }

    public int getIdTravelWarrant() {
        return idTravelWarrant;
    }

    public void setIdTravelWarrant(int idTravelWarrant) {
        this.idTravelWarrant = idTravelWarrant;
    }

    public int getDriverId() {
        return driverId;
    }

    public void setDriverId(int driverId) {
        this.driverId = driverId;
    }

    public int getCarId() {
        return carId;
    }

    public void setCarId(int carId) {
        this.carId = carId;
    }

    public int getTravelWarrantTypeId() {
        return travelWarrantTypeId;
    }

    public void setTravelWarrantTypeId(int travelWarrantTypeId) {
        this.travelWarrantTypeId = travelWarrantTypeId;
    }

    public int getFuelId() {
        return fuelId;
    }

    public void setFuelId(int fuelId) {
        this.fuelId = fuelId;
    }

    public int getRouteId() {
        return routeId;
    }

    public void setRouteId(int routeId) {
        this.routeId = routeId;
    }

    @Override
    public String toString() {
        return "TravelWarrant{" + "idTravelWarrant=" + idTravelWarrant + ", driverId=" + driverId + ", carId=" + carId + ", travelWarrantTypeId=" + travelWarrantTypeId + ", fuelId=" + fuelId + ", routeId=" + routeId + '}';
    }
}
