/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author efurkev
 */
@Entity
@Table(name = "TravelWarrant")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "TravelWarrant.findAll", query = "SELECT t FROM TravelWarrant t")
    , @NamedQuery(name = "TravelWarrant.findByIDTravelWarrant", query = "SELECT t FROM TravelWarrant t WHERE t.iDTravelWarrant = :iDTravelWarrant")})
public class TravelWarrant implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDTravelWarrant")
    private Integer iDTravelWarrant;
    @JoinColumn(name = "CarID", referencedColumnName = "IDCar")
    @ManyToOne
    private Car car;    
    @JoinColumn(name = "DriverID", referencedColumnName = "IDDriver")
    @ManyToOne
    private Driver driver;
    @JoinColumn(name = "FuelID", referencedColumnName = "IDFuel")
    @ManyToOne
    private Fuel fuel;
    @JoinColumn(name = "RouteID", referencedColumnName = "IDRoute")
    @ManyToOne
    private Route route;
    @JoinColumn(name = "TravelWarrantTypeID", referencedColumnName = "IDTravelWarrantType")
    @ManyToOne
    private TravelWarrantType travelWarrantType;

    public TravelWarrant() {
    }

    public TravelWarrant(Integer iDTravelWarrant) {
        this.iDTravelWarrant = iDTravelWarrant;
    }

    public Integer getIDTravelWarrant() {
        return iDTravelWarrant;
    }

    public void setIDTravelWarrant(Integer iDTravelWarrant) {
        this.iDTravelWarrant = iDTravelWarrant;
    }

    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
    }

    public Driver getDriver() {
        return driver;
    }

    public void setDriver(Driver driver) {
        this.driver = driver;
    }

    public Fuel getFuel() {
        return fuel;
    }

    public void setFuel(Fuel fuel) {
        this.fuel = fuel;
    }

    public Route getRoute() {
        return route;
    }

    public void setRoute(Route route) {
        this.route = route;
    }

    public TravelWarrantType getTravelWarrantType() {
        return travelWarrantType;
    }

    public void setTravelWarrantType(TravelWarrantType travelWarrantType) {
        this.travelWarrantType = travelWarrantType;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDTravelWarrant != null ? iDTravelWarrant.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof TravelWarrant)) {
            return false;
        }
        TravelWarrant other = (TravelWarrant) object;
        if ((this.iDTravelWarrant == null && other.iDTravelWarrant != null) || (this.iDTravelWarrant != null && !this.iDTravelWarrant.equals(other.iDTravelWarrant))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "TravelWarrant[ IDTravelWarrant=" + iDTravelWarrant + 
                ", type=" + travelWarrantType +  ", " + car.toString() 
                + ", " + driver.toString() + ", " + fuel.toString() + 
                ", " + route.toString() + " ]";
    }
    
}
