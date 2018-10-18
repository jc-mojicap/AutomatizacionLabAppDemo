package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;

public interface GrupoRepository extends JpaRepository<Grupo, Integer> {

	List<Grupo> findByIdGrupo(Integer idGrupo);
	List<Grupo> findByIdExperiment(Integer idExperiment);
	
	
}
