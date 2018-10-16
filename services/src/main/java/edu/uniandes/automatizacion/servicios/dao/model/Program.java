package edu.uniandes.automatizacion.servicios.dao.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="program")
public class Program {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_program", nullable = false)
	private long idProgram;
	
	@Column(name="code")
	private String code;
	
	@Column(name="description")
	private String description;
	
	@Column(name="status")
	private String status;

}