package edu.uniandes.automatizacion.servicios.dao.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="element")
public class Element {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_element", nullable = false)
	private Long idElement;
	
	@Column(name="name")
	private String name;
	
	@Column(name="type")
	private String type;
	
	@Column(name="path_image")
	private String pathImage;
	
	@Column(name="path_sound")
	private String pathSound;
	
	@Column(name="is_answer")
	private Boolean isAnswer;
}
