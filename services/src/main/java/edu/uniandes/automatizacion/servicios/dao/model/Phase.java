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

import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;

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
	
	
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<TestDTO> tests;
	
}
