package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.List;

public class ExperimentDTO {

	private String name;
	private String description;
	private String status;
	private List<GroupDTO> groups;
	
	public ExperimentDTO() {
		super();
		// TODO Auto-generated constructor stub
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

	public List<GroupDTO> getGroups() {
		return groups;
	}

	public void setGroups(List<GroupDTO> groups) {
		this.groups = groups;
	}
	
	
}
