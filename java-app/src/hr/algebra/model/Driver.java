package hr.algebra.model;

/**
 *
 * @author efurkev
 */
public class Driver {

    public int idDriver;
    public String firstname;
    public String lastname;
    public String telephone;
    public int drivingLicenceNumber;

    public Driver(String firstname, String lastname, String telephone, int drivingLicenceNumber) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.telephone = telephone;
        this.drivingLicenceNumber = drivingLicenceNumber;
    }

    public Driver(int idDriver, String firstname, String lastname, String telephone, int drivingLicenceNumber) {
        this(firstname, lastname, telephone, drivingLicenceNumber);
        this.idDriver = idDriver;
    }

    public int getIdDriver() {
        return idDriver;
    }

    public void setIdDriver(int idDriver) {
        this.idDriver = idDriver;
    }

    public String getFirstname() {
        return firstname;
    }

    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public String getTelephone() {
        return telephone;
    }

    public void setTelephone(String telephone) {
        this.telephone = telephone;
    }

    public int getDrivingLicenceNumber() {
        return drivingLicenceNumber;
    }

    public void setDrivingLicenceNumber(int drivingLicenceNumber) {
        this.drivingLicenceNumber = drivingLicenceNumber;
    }

    @Override
    public String toString() {
        return "Driver{" + "idDriver=" + idDriver + ", firstname=" + firstname + ", lastname=" + lastname + '}';
    }
}
