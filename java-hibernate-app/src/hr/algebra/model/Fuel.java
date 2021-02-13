/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Collection;
import java.util.Date;
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
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author efurkev
 */
@Entity
@Table(name = "Fuel")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Fuel.findAll", query = "SELECT f FROM Fuel f")
    , @NamedQuery(name = "Fuel.findByIDFuel", query = "SELECT f FROM Fuel f WHERE f.iDFuel = :iDFuel")
    , @NamedQuery(name = "Fuel.findByTime", query = "SELECT f FROM Fuel f WHERE f.time = :time")
    , @NamedQuery(name = "Fuel.findByAmount", query = "SELECT f FROM Fuel f WHERE f.amount = :amount")
    , @NamedQuery(name = "Fuel.findByPrice", query = "SELECT f FROM Fuel f WHERE f.price = :price")})
public class Fuel implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDFuel")
    private Integer iDFuel;
    @Column(name = "Time")
    @Temporal(TemporalType.TIMESTAMP)
    private Date time;
    @Column(name = "Amount")
    private Integer amount;
    @Column(name = "Price")
    private Integer price;
    @JoinColumn(name = "CityID", referencedColumnName = "IDCity")
    @ManyToOne
    private City city;
    @JoinColumn(name = "DriverID", referencedColumnName = "IDDriver")
    @ManyToOne
    private Driver driver;
    @OneToMany(mappedBy = "fuel")
    private Collection<TravelWarrant> travelWarrantCollection;

    public Fuel() {
    }

    public Fuel(Integer iDFuel) {
        this.iDFuel = iDFuel;
    }

    public Integer getIDFuel() {
        return iDFuel;
    }

    public void setIDFuel(Integer iDFuel) {
        this.iDFuel = iDFuel;
    }

    public Date getTime() {
        return time;
    }

    public void setTime(Date time) {
        this.time = time;
    }

    public Integer getAmount() {
        return amount;
    }

    public void setAmount(Integer amount) {
        this.amount = amount;
    }

    public Integer getPrice() {
        return price;
    }

    public void setPrice(Integer price) {
        this.price = price;
    }

    public City getCity() {
        return city;
    }

    public void setCity(City city) {
        this.city = city;
    }

    public Driver getDriver() {
        return driver;
    }

    public void setDriver(Driver driver) {
        this.driver = driver;
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
        hash += (iDFuel != null ? iDFuel.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Fuel)) {
            return false;
        }
        Fuel other = (Fuel) object;
        if ((this.iDFuel == null && other.iDFuel != null) || (this.iDFuel != null && !this.iDFuel.equals(other.iDFuel))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Fuel[ IDFuel=" + iDFuel + ", time=" + time + ", amount=" + amount + ", price=" + price + ", city=" + city + " ]";
    }
    
}
