package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.List;


public class GroupDTO {

	private Long idGroup;
	private String name;
	private String description;
	private String status;
	private List<SubjectDTO> subjects;
	
	public GroupDTO() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	public Long getIdGroup() {
		return idGroup;
	}
	
	public void setIdGroup(Long idGroup) {
		this.idGroup = idGroup;
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
