package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;

public interface GrupoRepository extends JpaRepository<Grupo, Integer> {

	List<Grupo> findByIdGrupo(Integer idGrupo);
	
	@Query("select g from Grupo g join Experiment e where e.id = ?1")
	List<Grupo> findByIdExperiment(Integer idExperiment);
	
	
}
