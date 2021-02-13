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
@Table(name = "TravelWarrantType")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "TravelWarrantType.findAll", query = "SELECT t FROM TravelWarrantType t")
    , @NamedQuery(name = "TravelWarrantType.findByIDTravelWarrantType", query = "SELECT t FROM TravelWarrantType t WHERE t.iDTravelWarrantType = :iDTravelWarrantType")
    , @NamedQuery(name = "TravelWarrantType.findByWarrantType", query = "SELECT t FROM TravelWarrantType t WHERE t.warrantType = :warrantType")})
public class TravelWarrantType implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDTravelWarrantType")
    private Integer iDTravelWarrantType;
    @Basic(optional = false)
    @Column(name = "WarrantType")
    private String warrantType;
    @OneToMany(mappedBy = "travelWarrantType")
    private Collection<TravelWarrant> travelWarrantCollection;

    public TravelWarrantType() {
    }

    public TravelWarrantType(Integer iDTravelWarrantType) {
        this.iDTravelWarrantType = iDTravelWarrantType;
    }

    public TravelWarrantType(Integer iDTravelWarrantType, String warrantType) {
        this.iDTravelWarrantType = iDTravelWarrantType;
        this.warrantType = warrantType;
    }

    public Integer getIDTravelWarrantType() {
        return iDTravelWarrantType;
    }

    public void setIDTravelWarrantType(Integer iDTravelWarrantType) {
        this.iDTravelWarrantType = iDTravelWarrantType;
    }

    public String getWarrantType() {
        return warrantType;
    }

    public void setWarrantType(String warrantType) {
        this.warrantType = warrantType;
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
        hash += (iDTravelWarrantType != null ? iDTravelWarrantType.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof TravelWarrantType)) {
            return false;
        }
        TravelWarrantType other = (TravelWarrantType) object;
        if ((this.iDTravelWarrantType == null && other.iDTravelWarrantType != null) || (this.iDTravelWarrantType != null && !this.iDTravelWarrantType.equals(other.iDTravelWarrantType))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return warrantType;
    }
    
}
