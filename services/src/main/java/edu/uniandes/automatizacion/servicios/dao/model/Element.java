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

	public Long getIdElement() {
		return idElement;
	}

	public void setIdElement(Long idElement) {
		this.idElement = idElement;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	public String getPathImage() {
		return pathImage;
	}

	public void setPathImage(String pathImage) {
		this.pathImage = pathImage;
	}

	public String getPathSound() {
		return pathSound;
	}

	public void setPathSound(String pathSound) {
		this.pathSound = pathSound;
	}

	public Boolean getIsAnswer() {
		return isAnswer;
	}

	public void setIsAnswer(Boolean isAnswer) {
		this.isAnswer = isAnswer;
	}
	
}
