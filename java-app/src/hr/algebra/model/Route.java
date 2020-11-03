package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class Route {

    public int idRoute;
    public int timeHours;
    public int startCityId;
    public int stopCityId;
    public int kilometers;
    public int avgSpeed;
    public int fuelUsed;

    public Route(int timeHours, int startCityId, int stopCityId, int kilometers, int avgSpeed, int fuelUsed) {
        this.timeHours = timeHours;
        this.startCityId = startCityId;
        this.stopCityId = stopCityId;
        this.kilometers = kilometers;
        this.avgSpeed = avgSpeed;
        this.fuelUsed = fuelUsed;
    }

    public Route(int idRoute, int timeHours, int startCityId, int stopCityId, int kilometers, int avgSpeed, int fuelUsed) {
        this(timeHours, startCityId, stopCityId, kilometers, avgSpeed, fuelUsed);
        this.idRoute = idRoute;
    }

    public int getIdRoute() {
        return idRoute;
    }

    public void setIdRoute(int idRoute) {
        this.idRoute = idRoute;
    }

    public int getTimeHours() {
        return timeHours;
    }

    public void setTimeHours(int timeHours) {
        this.timeHours = timeHours;
    }

    public int getStartCity() {
        return startCityId;
    }

    public void setStartCity(int startCityId) {
        this.startCityId = startCityId;
    }

    public int getStopCity() {
        return stopCityId;
    }

    public void setStopCity(int stopCityId) {
        this.stopCityId = stopCityId;
    }

    public int getKilometers() {
        return kilometers;
    }

    public void setKilometers(int kilometers) {
        this.kilometers = kilometers;
    }

    public int getAvgSpeed() {
        return avgSpeed;
    }

    public void setAvgSpeed(int avgSpeed) {
        this.avgSpeed = avgSpeed;
    }

    public int getFuelUsed() {
        return fuelUsed;
    }

    public void setFuelUsed(int fuelUsed) {
        this.fuelUsed = fuelUsed;
    }

    @Override
    public String toString() {
        return "Route{" + "idRoute=" + idRoute + ", timeHours=" + timeHours + ", startCityId=" + startCityId + ", stopCityId=" + stopCityId + ", kilometers=" + kilometers + ", avgSpeed=" + avgSpeed + ", fuelUsed=" + fuelUsed + '}';
    }
}
