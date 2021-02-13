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
@Table(name = "Car")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Car.findAll", query = "SELECT c FROM Car c")
    , @NamedQuery(name = "Car.findByIDCar", query = "SELECT c FROM Car c WHERE c.iDCar = :iDCar")
    , @NamedQuery(name = "Car.findByBrand", query = "SELECT c FROM Car c WHERE c.brand = :brand")
    , @NamedQuery(name = "Car.findByModel", query = "SELECT c FROM Car c WHERE c.model = :model")
    , @NamedQuery(name = "Car.findByYear", query = "SELECT c FROM Car c WHERE c.year = :year")
    , @NamedQuery(name = "Car.findByInitialMileage", query = "SELECT c FROM Car c WHERE c.initialMileage = :initialMileage")})
public class Car implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDCar")
    private Integer iDCar;
    @Basic(optional = false)
    @Column(name = "Brand")
    private String brand;
    @Basic(optional = false)
    @Column(name = "Model")
    private String model;
    @Column(name = "Year")
    private Integer year;
    @Column(name = "InitialMileage")
    private Integer initialMileage;
    @OneToMany(mappedBy = "carID")
    private Collection<Service> serviceCollection;
    @OneToMany(mappedBy = "car")
    private Collection<TravelWarrant> travelWarrantCollection;

    public Car() {
    }

    public Car(Integer iDCar) {
        this.iDCar = iDCar;
    }

    public Car(Integer iDCar, String brand, String model) {
        this.iDCar = iDCar;
        this.brand = brand;
        this.model = model;
    }

    public Integer getIDCar() {
        return iDCar;
    }

    public void setIDCar(Integer iDCar) {
        this.iDCar = iDCar;
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

    public Integer getYear() {
        return year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }

    public Integer getInitialMileage() {
        return initialMileage;
    }

    public void setInitialMileage(Integer initialMileage) {
        this.initialMileage = initialMileage;
    }

    @XmlTransient
    public Collection<Service> getServiceCollection() {
        return serviceCollection;
    }

    public void setServiceCollection(Collection<Service> serviceCollection) {
        this.serviceCollection = serviceCollection;
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
        hash += (iDCar != null ? iDCar.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Car)) {
            return false;
        }
        Car other = (Car) object;
        if ((this.iDCar == null && other.iDCar != null) || (this.iDCar != null && !this.iDCar.equals(other.iDCar))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Car[ IDCar=" + iDCar + ", brand=" + brand + ", model=" + model + ", year=" + year + ", mileage=" + initialMileage + " ]";
    }
    
}
