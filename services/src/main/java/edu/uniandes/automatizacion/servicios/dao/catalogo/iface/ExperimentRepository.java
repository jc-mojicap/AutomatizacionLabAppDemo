package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;

public interface ExperimentRepository extends JpaRepository<Experiment, Integer> {

	List<Experiment> findByIdExperiment(Integer idExperiment);
	
}
