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

import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;

@Entity
@Table(name="group")
public class Group {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id_group", nullable = false)
	private Long idGroup;
	
	@Column(name="name")
	private String name;
	
	@Column(name="description")
	private String description;
	
	@Column(name="status")
	private String status;
	
	@JoinColumn(name="id_group", referencedColumnName="id_group", nullable = false)
    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<SubjectDTO> subjects;
}
