/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author efurkev
 */
@Entity
@Table(name = "Service")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Service.findAll", query = "SELECT s FROM Service s")
    , @NamedQuery(name = "Service.findByIDService", query = "SELECT s FROM Service s WHERE s.iDService = :iDService")
    , @NamedQuery(name = "Service.findByDescription", query = "SELECT s FROM Service s WHERE s.description = :description")
    , @NamedQuery(name = "Service.findByDate", query = "SELECT s FROM Service s WHERE s.date = :date")})
public class Service implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDService")
    private Integer iDService;
    @Basic(optional = false)
    @Column(name = "Description")
    private String description;
    @Basic(optional = false)
    @Column(name = "Date")
    @Temporal(TemporalType.TIMESTAMP)
    private Date date;
    @JoinColumn(name = "CarID", referencedColumnName = "IDCar")
    @ManyToOne
    private Car carID;

    public Service() {
    }

    public Service(Integer iDService) {
        this.iDService = iDService;
    }

    public Service(Integer iDService, String description, Date date) {
        this.iDService = iDService;
        this.description = description;
        this.date = date;
    }

    public Integer getIDService() {
        return iDService;
    }

    public void setIDService(Integer iDService) {
        this.iDService = iDService;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public Car getCarID() {
        return carID;
    }

    public void setCarID(Car carID) {
        this.carID = carID;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDService != null ? iDService.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Service)) {
            return false;
        }
        Service other = (Service) object;
        if ((this.iDService == null && other.iDService != null) || (this.iDService != null && !this.iDService.equals(other.iDService))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Service[ iDService=" + iDService + " ]";
    }
    
}
