package edu.uniandes.automatizacion.servicios.dao.model;

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
import javax.persistence.Table;

@Entity
@Table(name="test")
public class Test {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_test", nullable = false)
	private Long idTest;
	
	@Column(name="name")
	private String name;
	
	@Column(name="is_repeatable")
	private Boolean isRepeatable;
	
	@Column(name="tries")
	private Integer tries;
	
	@OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	@JoinColumn(name="initial", referencedColumnName="id_element")
	private Element initial;
	
	@OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	@JoinColumn(name="possibilities", referencedColumnName="id_element")
	private List<Element> possibilities;
}
