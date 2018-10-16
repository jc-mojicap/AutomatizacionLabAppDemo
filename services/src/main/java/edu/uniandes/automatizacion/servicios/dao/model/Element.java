package edu.uniandes.automatizacion.servicios.dao.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

@Entity
@Table(name="element")
public class Element {

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
