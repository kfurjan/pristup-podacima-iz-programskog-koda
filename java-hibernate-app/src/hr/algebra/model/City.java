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
@Table(name = "City")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "City.findAll", query = "SELECT c FROM City c")
    , @NamedQuery(name = "City.findByIDCity", query = "SELECT c FROM City c WHERE c.iDCity = :iDCity")
    , @NamedQuery(name = "City.findByName", query = "SELECT c FROM City c WHERE c.name = :name")
    , @NamedQuery(name = "City.findByLatitude", query = "SELECT c FROM City c WHERE c.latitude = :latitude")
    , @NamedQuery(name = "City.findByLongitude", query = "SELECT c FROM City c WHERE c.longitude = :longitude")
    , @NamedQuery(name = "City.findByCountry", query = "SELECT c FROM City c WHERE c.country = :country")
    , @NamedQuery(name = "City.findByCountryCode", query = "SELECT c FROM City c WHERE c.countryCode = :countryCode")
    , @NamedQuery(name = "City.findByCounty", query = "SELECT c FROM City c WHERE c.county = :county")
    , @NamedQuery(name = "City.findByCapital", query = "SELECT c FROM City c WHERE c.capital = :capital")
    , @NamedQuery(name = "City.findByPopulation", query = "SELECT c FROM City c WHERE c.population = :population")
    , @NamedQuery(name = "City.findByPopulationProper", query = "SELECT c FROM City c WHERE c.populationProper = :populationProper")})
public class City implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDCity")
    private Integer iDCity;
    @Basic(optional = false)
    @Column(name = "Name")
    private String name;
    @Basic(optional = false)
    @Column(name = "Latitude")
    private double latitude;
    @Basic(optional = false)
    @Column(name = "Longitude")
    private double longitude;
    @Column(name = "Country")
    private String country;
    @Column(name = "CountryCode")
    private String countryCode;
    @Column(name = "County")
    private String county;
    @Column(name = "Capital")
    private String capital;
    @Column(name = "Population")
    private Integer population;
    @Column(name = "PopulationProper")
    private Integer populationProper;
    @OneToMany(mappedBy = "city")
    private Collection<Fuel> fuelCollection;
    @OneToMany(mappedBy = "cityA")
    private Collection<Route> routeCollection;
    @OneToMany(mappedBy = "cityB")
    private Collection<Route> routeCollection1;

    public City() {
    }

    public City(Integer iDCity) {
        this.iDCity = iDCity;
    }

    public City(Integer iDCity, String name, double latitude, double longitude) {
        this.iDCity = iDCity;
        this.name = name;
        this.latitude = latitude;
        this.longitude = longitude;
    }

    public Integer getIDCity() {
        return iDCity;
    }

    public void setIDCity(Integer iDCity) {
        this.iDCity = iDCity;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getLatitude() {
        return latitude;
    }

    public void setLatitude(double latitude) {
        this.latitude = latitude;
    }

    public double getLongitude() {
        return longitude;
    }

    public void setLongitude(double longitude) {
        this.longitude = longitude;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public String getCountryCode() {
        return countryCode;
    }

    public void setCountryCode(String countryCode) {
        this.countryCode = countryCode;
    }

    public String getCounty() {
        return county;
    }

    public void setCounty(String county) {
        this.county = county;
    }

    public String getCapital() {
        return capital;
    }

    public void setCapital(String capital) {
        this.capital = capital;
    }

    public Integer getPopulation() {
        return population;
    }

    public void setPopulation(Integer population) {
        this.population = population;
    }

    public Integer getPopulationProper() {
        return populationProper;
    }

    public void setPopulationProper(Integer populationProper) {
        this.populationProper = populationProper;
    }

    @XmlTransient
    public Collection<Fuel> getFuelCollection() {
        return fuelCollection;
    }

    public void setFuelCollection(Collection<Fuel> fuelCollection) {
        this.fuelCollection = fuelCollection;
    }

    @XmlTransient
    public Collection<Route> getRouteCollection() {
        return routeCollection;
    }

    public void setRouteCollection(Collection<Route> routeCollection) {
        this.routeCollection = routeCollection;
    }

    @XmlTransient
    public Collection<Route> getRouteCollection1() {
        return routeCollection1;
    }

    public void setRouteCollection1(Collection<Route> routeCollection1) {
        this.routeCollection1 = routeCollection1;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDCity != null ? iDCity.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof City)) {
            return false;
        }
        City other = (City) object;
        if ((this.iDCity == null && other.iDCity != null) || (this.iDCity != null && !this.iDCity.equals(other.iDCity))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return name;
    }
    
}
