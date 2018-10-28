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
import javax.persistence.Table;

@Entity
@Table(name="experiment")
public class Experiment implements Serializable{

	private static final long serialVersionUID = 1L;
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_experiment", nullable = false)
	private Integer idExperiment;
	
	@Column(name="name")
	private String name;
	
	@Column(name="description")
	private String description;
	
	@Column(name="correctAnswerAudio")
	private String correctAnswerAudio;
	
	@Column(name="incorrectAnswerAudio")
	private String incorrectAnswerAudio;
	
	@Column(name="instructions")
	private String instructions;
	
	@Column(name="status")
	private String status;
	
	@JoinColumn(name="id_experiment", referencedColumnName="id_experiment", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Grupo> grupos;
	
	@JoinColumn(name="id_experiment", referencedColumnName="id_experiment", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Phase> phases;

	public Experiment() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	public Integer getIdExperiment() {
		return idExperiment;
	}

	public void setIdExperiment(Integer idExperiment) {
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

	public List<Grupo> getGrupos() {
		return grupos;
	}

	public void setGrupos(List<Grupo> grupos) {
		this.grupos = grupos;
	}

	public List<Phase> getPhases() {
		return phases;
	}

	public void setPhases(List<Phase> phases) {
		this.phases = phases;
	}

	public String getCorrectAnswerAudio() {
		return correctAnswerAudio;
	}

	public void setCorrectAnswerAudio(String correctAnswerAudio) {
		this.correctAnswerAudio = correctAnswerAudio;
	}

	public String getIncorrectAnswerAudio() {
		return incorrectAnswerAudio;
	}

	public void setIncorrectAnswerAudio(String incorrectAnswerAudio) {
		this.incorrectAnswerAudio = incorrectAnswerAudio;
	}

	public String getInstructions() {
		return instructions;
	}

	public void setInstructions(String instructions) {
		this.instructions = instructions;
	}

}
