package edu.uniandes.automatizacion.servicios.dao.model;

import java.io.Serializable;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name="test")
public class Test implements Serializable{

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_test", nullable = false)
	private Integer idTest;
	
	@Column(name="name")
	private String name;
	
	@Column(name="is_repeatable")
	private Boolean isRepeatable;
	
	@Column(name="tries")
	private Integer tries;
	
	@OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	@JoinColumn(name="id_element", referencedColumnName="id_element")
	private Element initial;
	
	@OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	@JoinColumn(name="id_element", referencedColumnName="id_element")
	private List<Element> possibilities;

	public Integer getIdTest() {
		return idTest;
	}

	public void setIdTest(Integer idTest) {
		this.idTest = idTest;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Boolean getIsRepeatable() {
		return isRepeatable;
	}

	public void setIsRepeatable(Boolean isRepeatable) {
		this.isRepeatable = isRepeatable;
	}

	public Integer getTries() {
		return tries;
	}

	public void setTries(Integer tries) {
		this.tries = tries;
	}

	public Element getInitial() {
		return initial;
	}

	public void setInitial(Element initial) {
		this.initial = initial;
	}

	public List<Element> getPossibilities() {
		return possibilities;
	}

	public void setPossibilities(List<Element> possibilities) {
		this.possibilities = possibilities;
	}

}
