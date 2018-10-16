package edu.uniandes.automatizacion.servicios.dao.model;

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
@Table(name="subject")
public class Subject {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_subject", nullable = false)
	private long idSubject;
	
	@Column(name="name")
	private String name;
	
	@Column(name="middle_name")
	private String middleName;
	
	@Column(name="last_name")
	private String lastName;

	@Column(name="age")
	private int age;
	
	@Column(name="email")
	private String email;

	@Column(name="cellphone")
	private String cellphone;

	@Column(name="semester")
	private int semester;

	@OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	@JoinColumn(name="id_program", referencedColumnName="program")
	private Program program;

}