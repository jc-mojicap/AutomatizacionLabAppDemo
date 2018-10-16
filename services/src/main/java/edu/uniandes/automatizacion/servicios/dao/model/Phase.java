package edu.uniandes.automatizacion.servicios.dao.model;

import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name="phase")
public class Phase {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_phase", nullable = false)
	private Long idPhase;
	
	@Column(name="name")
	private String name;
	
	@Column(name="instructions")
	private String instructions;
	
	@Column(name="instructions_sound_path")
	private String instructionsSoundPath;
	
	@Column(name="position")
	private Integer position;
	
	@Column(name="is_repeatable")
	private Boolean isRepeatable;
	
	@Column(name="tries")
	private Integer tries;
	
	@JoinColumn(name = "next_phase", referencedColumnName = "id_phase", nullable = false)
    @OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private Phase nextPhase;
	
	@JoinColumn(name = "previous_phase", referencedColumnName = "id_phase", nullable = false)
    @OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private Phase previousPhase;
	
	@JoinColumn(name = "next_success", referencedColumnName = "id_phase", nullable = false)
    @OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private Phase nextSuccess;
	
	@JoinColumn(name = "id_phase", referencedColumnName = "id_phase", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Test> tests;

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

	public Phase getNextPhase() {
		return nextPhase;
	}

	public void setNextPhase(Phase nextPhase) {
		this.nextPhase = nextPhase;
	}

	public Phase getPreviousPhase() {
		return previousPhase;
	}

	public void setPreviousPhase(Phase previousPhase) {
		this.previousPhase = previousPhase;
	}

	public Phase getNextSuccess() {
		return nextSuccess;
	}

	public void setNextSuccess(Phase nextSuccess) {
		this.nextSuccess = nextSuccess;
	}

	public List<Test> getTests() {
		return tests;
	}

	public void setTests(List<Test> tests) {
		this.tests = tests;
	}
}
