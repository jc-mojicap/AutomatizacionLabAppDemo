package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Phase;

public interface PhaseRepository extends JpaRepository<Phase, Integer> {

	List<Phase> findByIdPhase(Integer idPhase);
	//List<Phase> findByIdExperiment(Integer idExperiment);
	
}
