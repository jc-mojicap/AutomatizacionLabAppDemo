package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.List;

public class ExperimentDTO {

	private Long idExperiment;
	private String name;
	private String description;
	private String status;
	private List<GrupoDTO> grupos;
	private List<PhaseDTO> phases;
	
	public ExperimentDTO() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Long getIdExperiment() {
		return idExperiment;
	}

	public void setIdExperiment(Long idExperiment) {
		this.idExperiment = idExperiment;
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

	public List<GrupoDTO> getGrupos() {
		return grupos;
	}

	public void setGrupos(List<GrupoDTO> grupos) {
		this.grupos = grupos;
	}

	public List<PhaseDTO> getPhases() {
		return phases;
	}

	public void setPhases(List<PhaseDTO> phases) {
		this.phases = phases;
	}

}
