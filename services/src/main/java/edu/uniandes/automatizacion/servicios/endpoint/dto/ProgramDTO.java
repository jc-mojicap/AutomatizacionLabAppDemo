package edu.uniandes.automatizacion.servicios.endpoint.dto;

public class ProgramDTO {

	private Long idProgram;
	private String code;
	private String description;
	private String status;
	
	public ProgramDTO() {
		super();
		// TODO Auto-generated constructor stub
	}
	public Long getIdProgram() {
		return idProgram;
	}
	public void setIdProgram(Long idProgram) {
		this.idProgram = idProgram;
	}
	public String getCode() {
		return code;
	}
	public void setCode(String code) {
		this.code = code;
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
}
