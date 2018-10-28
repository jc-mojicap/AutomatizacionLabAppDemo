package edu.uniandes.automatizacion.servicios.dao.model;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="element")
public class Element implements Serializable{

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_element", nullable = false)
	private Integer idElement;
	
	@Column(name="name")
	private String name;
	
	@Column(name="type")
	@Enumerated(EnumType.STRING)
	private Type type;
	
	@Column(name="path")
	private String path;
	
	@Column(name="is_answer")
	private Boolean isAnswer;
	
	public Integer getIdElement() {
		return idElement;
	}

	public void setIdElement(Integer idElement) {
		this.idElement = idElement;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	public Type getType() {
		return type;
	}

	public void setType(Type type) {
		this.type = type;
	}

	public String getPath() {
		return path;
	}

	public void setPath(String path) {
		this.path = path;
	}

	public Boolean getIsAnswer() {
		return isAnswer;
	}

	public void setIsAnswer(Boolean isAnswer) {
		this.isAnswer = isAnswer;
	}
	
	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((idElement == null) ? 0 : idElement.hashCode());
		result = prime * result + ((isAnswer == null) ? 0 : isAnswer.hashCode());
		result = prime * result + ((name == null) ? 0 : name.hashCode());
		result = prime * result + ((type == null) ? 0 : type.hashCode());
		return result;
	}
	
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Element other = (Element) obj;
		if (idElement == null) {
			if (other.idElement != null)
				return false;
		} else if (!idElement.equals(other.idElement))
			return false;
		if (isAnswer == null) {
			if (other.isAnswer != null)
				return false;
		} else if (!isAnswer.equals(other.isAnswer))
			return false;
		if (name == null) {
			if (other.name != null)
				return false;
		} else if (!name.equals(other.name))
			return false;
		if (type == null) {
			if (other.type != null)
				return false;
		} else if (!type.equals(other.type))
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Element [" + (idElement != null ? "idElement=" + idElement + ", " : "")
				+ (name != null ? "name=" + name + ", " : "") + (type != null ? "type=" + type + ", " : "")
				+ (path != null ? "path=" + path + ", " : "") + (isAnswer != null ? "isAnswer=" + isAnswer : "") + "]";
	}
		
}
