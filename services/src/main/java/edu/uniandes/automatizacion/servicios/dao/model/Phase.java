package edu.uniandes.automatizacion.servicios.dao.model;

import java.io.Serializable;
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
public class Phase implements Serializable{

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_phase", nullable = false)
	private Integer idPhase;
	
	@Column(name="name")
	private String name;
	
	@Column(name="instructions")
	private String instructions;
	
	@Column(name="is_repeatable")
	private Boolean isRepeatable;
	
	@Column(name="tries")
	private Integer tries;
	
	@Column(name="position")
	private Integer hits;
	
	@Column(name="audio_instrution")
	private String audioInstrution;
	
	@JoinColumn(name = "next_phase", nullable = true)
    @OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private Phase nextPhase;
	
	@JoinColumn(name = "previous_phase", nullable = true)
    @OneToOne(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private Phase previousPhase;
	
	@JoinColumn(name = "id_phase", referencedColumnName = "id_phase", nullable = true)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Test> tests;

	public Integer getIdPhase() {
		return idPhase;
	}

	public void setIdPhase(Integer idPhase) {
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

	public Integer getHits() {
		return hits;
	}

	public void setHits(Integer hits) {
		this.hits = hits;
	}

	public String getAudioInstrution() {
		return audioInstrution;
	}

	public void setAudioInstrution(String audioInstrution) {
		this.audioInstrution = audioInstrution;
	}
	
	public List<Test> getTests() {
		return tests;
	}

	public void setTests(List<Test> tests) {
		this.tests = tests;
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
	
}
