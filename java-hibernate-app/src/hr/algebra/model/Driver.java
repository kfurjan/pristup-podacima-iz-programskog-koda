/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author efurkev
 */
@Entity
@Table(name = "Driver")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Driver.findAll", query = "SELECT d FROM Driver d")
    , @NamedQuery(name = "Driver.findByIDDriver", query = "SELECT d FROM Driver d WHERE d.iDDriver = :iDDriver")
    , @NamedQuery(name = "Driver.findByFirstname", query = "SELECT d FROM Driver d WHERE d.firstname = :firstname")
    , @NamedQuery(name = "Driver.findByLastname", query = "SELECT d FROM Driver d WHERE d.lastname = :lastname")
    , @NamedQuery(name = "Driver.findByTelephone", query = "SELECT d FROM Driver d WHERE d.telephone = :telephone")
    , @NamedQuery(name = "Driver.findByDrivingLicenceNumber", query = "SELECT d FROM Driver d WHERE d.drivingLicenceNumber = :drivingLicenceNumber")})
public class Driver implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDDriver")
    private Integer iDDriver;
    @Basic(optional = false)
    @Column(name = "Firstname")
    private String firstname;
    @Basic(optional = false)
    @Column(name = "Lastname")
    private String lastname;
    @Basic(optional = false)
    @Column(name = "Telephone")
    private String telephone;
    @Basic(optional = false)
    @Column(name = "DrivingLicenceNumber")
    private int drivingLicenceNumber;
    @OneToMany(mappedBy = "driver")
    private Collection<Fuel> fuelCollection;
    @OneToMany(mappedBy = "driver")
    private Collection<TravelWarrant> travelWarrantCollection;

    public Driver() {
    }

    public Driver(Integer iDDriver) {
        this.iDDriver = iDDriver;
    }

    public Driver(Integer iDDriver, String firstname, String lastname, String telephone, int drivingLicenceNumber) {
        this.iDDriver = iDDriver;
        this.firstname = firstname;
        this.lastname = lastname;
        this.telephone = telephone;
        this.drivingLicenceNumber = drivingLicenceNumber;
    }

    public Integer getIDDriver() {
        return iDDriver;
    }

    public void setIDDriver(Integer iDDriver) {
        this.iDDriver = iDDriver;
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

    @XmlTransient
    public Collection<Fuel> getFuelCollection() {
        return fuelCollection;
    }

    public void setFuelCollection(Collection<Fuel> fuelCollection) {
        this.fuelCollection = fuelCollection;
    }

    @XmlTransient
    public Collection<TravelWarrant> getTravelWarrantCollection() {
        return travelWarrantCollection;
    }

    public void setTravelWarrantCollection(Collection<TravelWarrant> travelWarrantCollection) {
        this.travelWarrantCollection = travelWarrantCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDDriver != null ? iDDriver.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Driver)) {
            return false;
        }
        Driver other = (Driver) object;
        if ((this.iDDriver == null && other.iDDriver != null) || (this.iDDriver != null && !this.iDDriver.equals(other.iDDriver))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Driver[ IDDriver=" + iDDriver + ", firstName=" + firstname 
                + ", lastName=" + lastname + ", telephone=" + telephone + 
                ", licenseNumber=" + drivingLicenceNumber + " ]";
    }

}
