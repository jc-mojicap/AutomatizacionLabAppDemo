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
import javax.persistence.Table;

import edu.uniandes.automatizacion.servicios.endpoint.dto.GroupDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;

@Entity
@Table(name="experiment")
public class Experiment {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_experiment", nullable = false)
	private String idExperiment;
	
	@Column(name="name")
	private String name;
	
	@Column(name="description")
	private String description;
	
	@Column(name="status")
	private String status;
	
	@JoinColumn(name = "idGroup", referencedColumnName = "idGroup", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<GroupDTO> groups;
	
	@JoinColumn(name = "idPhase", referencedColumnName = "idPhase", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<PhaseDTO> phases;
	
}
