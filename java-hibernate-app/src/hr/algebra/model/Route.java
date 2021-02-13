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
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
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
@Table(name = "Route")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Route.findAll", query = "SELECT r FROM Route r")
    , @NamedQuery(name = "Route.findByIDRoute", query = "SELECT r FROM Route r WHERE r.iDRoute = :iDRoute")
    , @NamedQuery(name = "Route.findByTimeHours", query = "SELECT r FROM Route r WHERE r.timeHours = :timeHours")
    , @NamedQuery(name = "Route.findByKilometers", query = "SELECT r FROM Route r WHERE r.kilometers = :kilometers")
    , @NamedQuery(name = "Route.findByAvgSpeed", query = "SELECT r FROM Route r WHERE r.avgSpeed = :avgSpeed")
    , @NamedQuery(name = "Route.findByFuelUsed", query = "SELECT r FROM Route r WHERE r.fuelUsed = :fuelUsed")})
public class Route implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDRoute")
    private Integer iDRoute;
    @Column(name = "TimeHours")
    private Integer timeHours;
    @Column(name = "Kilometers")
    private Integer kilometers;
    @Column(name = "AvgSpeed")
    private Integer avgSpeed;
    @Column(name = "FuelUsed")
    private Integer fuelUsed;
    @OneToMany(mappedBy = "route")
    private Collection<TravelWarrant> travelWarrantCollection;
    @JoinColumn(name = "CityA", referencedColumnName = "IDCity")
    @ManyToOne
    private City cityA;
    @JoinColumn(name = "CityB", referencedColumnName = "IDCity")
    @ManyToOne
    private City cityB;

    public Route() {
    }

    public Route(Integer iDRoute) {
        this.iDRoute = iDRoute;
    }

    public Integer getIDRoute() {
        return iDRoute;
    }

    public void setIDRoute(Integer iDRoute) {
        this.iDRoute = iDRoute;
    }

    public Integer getTimeHours() {
        return timeHours;
    }

    public void setTimeHours(Integer timeHours) {
        this.timeHours = timeHours;
    }

    public Integer getKilometers() {
        return kilometers;
    }

    public void setKilometers(Integer kilometers) {
        this.kilometers = kilometers;
    }

    public Integer getAvgSpeed() {
        return avgSpeed;
    }

    public void setAvgSpeed(Integer avgSpeed) {
        this.avgSpeed = avgSpeed;
    }

    public Integer getFuelUsed() {
        return fuelUsed;
    }

    public void setFuelUsed(Integer fuelUsed) {
        this.fuelUsed = fuelUsed;
    }

    @XmlTransient
    public Collection<TravelWarrant> getTravelWarrantCollection() {
        return travelWarrantCollection;
    }

    public void setTravelWarrantCollection(Collection<TravelWarrant> travelWarrantCollection) {
        this.travelWarrantCollection = travelWarrantCollection;
    }

    public City getCityA() {
        return cityA;
    }

    public void setCityA(City cityA) {
        this.cityA = cityA;
    }

    public City getCityB() {
        return cityB;
    }

    public void setCityB(City cityB) {
        this.cityB = cityB;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDRoute != null ? iDRoute.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Route)) {
            return false;
        }
        Route other = (Route) object;
        if ((this.iDRoute == null && other.iDRoute != null) || (this.iDRoute != null && !this.iDRoute.equals(other.iDRoute))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Route[ IDRoute=" + iDRoute + ", houres=" + timeHours
                + ", kilometers" + kilometers + ", average spped=" + avgSpeed
                + ", fuelUsed=" + fuelUsed + ", from=" + cityA + ", to=" + cityB + " ]";
    }

}
