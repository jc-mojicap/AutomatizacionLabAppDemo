package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;

public interface ExperimentRepository extends JpaRepository<Experiment, Integer> {

	Experiment findByIdExperiment(Integer idExperiment);
	
}
