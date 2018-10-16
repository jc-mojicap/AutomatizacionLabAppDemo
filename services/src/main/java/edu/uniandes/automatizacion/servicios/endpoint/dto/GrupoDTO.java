package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.List;


public class GrupoDTO {

	private Long idGrupo;
	private String name;
	private String description;
	private String status;
	private List<SubjectDTO> subjects;
	
	public GrupoDTO() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	public Long getIdGrupo() {
		return idGrupo;
	}
	
	public void setIdGrupo(Long idGrupo) {
		this.idGrupo = idGrupo;
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
	public List<SubjectDTO> getSubjects() {
		return subjects;
	}
	public void setSubjects(List<SubjectDTO> subjects) {
		this.subjects = subjects;
	}
	
	
}
