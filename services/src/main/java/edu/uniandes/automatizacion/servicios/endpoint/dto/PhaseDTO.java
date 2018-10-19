package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.io.Serializable;
import java.util.List;

public class PhaseDTO implements Serializable{

	private static final long serialVersionUID = 1L;

	private Long idPhase;
	private String name;
	private String instructions;
	private String instructionsSoundPath;
	private Integer position;
	private Boolean isRepeatable;
	private Integer tries;
	private PhaseDTO nextPhase;
	private PhaseDTO previousPhase;
	private PhaseDTO nextSuccess;
	private List<TestDTO> tests;
	
	public PhaseDTO() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Long getIdPhase() {
		return idPhase;
	}

	public void setIdPhase(Long idPhase) {
		this.idPhase = idPhase;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getInstructions() {
		return instructions;
	}

	public void setInstructions(String instructions) {
		this.instructions = instructions;
	}

	public String getInstructionsSoundPath() {
		return instructionsSoundPath;
	}

	public void setInstructionsSoundPath(String instructionsSoundPath) {
		this.instructionsSoundPath = instructionsSoundPath;
	}

	public Integer getPosition() {
		return position;
	}

	public void setPosition(Integer position) {
		this.position = position;
	}

	public Boolean getIsRepeatable() {
		return isRepeatable;
	}

	public void setIsRepeatable(Boolean isRepeatable) {
		this.isRepeatable = isRepeatable;
	}

	public Integer getTries() {
		return tries;
	}

	public void setTries(Integer tries) {
		this.tries = tries;
	}

	public PhaseDTO getNextPhase() {
		return nextPhase;
	}

	public void setNextPhase(PhaseDTO nextPhase) {
		this.nextPhase = nextPhase;
	}

	public PhaseDTO getPreviousPhase() {
		return previousPhase;
	}

	public void setPreviousPhase(PhaseDTO previousPhase) {
		this.previousPhase = previousPhase;
	}

	public PhaseDTO getNextSuccess() {
		return nextSuccess;
	}

	public void setNextSuccess(PhaseDTO nextSuccess) {
		this.nextSuccess = nextSuccess;
	}

	public List<TestDTO> getTests() {
		return tests;
	}

	public void setTests(List<TestDTO> tests) {
		this.tests = tests;
	}

}
