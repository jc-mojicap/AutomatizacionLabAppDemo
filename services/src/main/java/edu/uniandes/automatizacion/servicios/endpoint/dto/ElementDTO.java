package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.io.Serializable;

public class ElementDTO implements Serializable{

	private static final long serialVersionUID = 1L;

	private String name;
	private String type;
	private String pathImage;
	private String pathSound;
	private Boolean isAnswer;
	
	public ElementDTO() {
		super();
		// TODO Auto-generated constructor stub
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
