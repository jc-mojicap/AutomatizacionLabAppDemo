package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ExperimentDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;

@Mapper
public interface ExperimentMapper {


	/**
     * Instancia de la clase.
     */
	ExperimentMapper INSTANCE = Mappers.getMapper(ExperimentMapper.class);

	Experiment experimentDTOToExperiment(ExperimentDTO experimentDTO);
	
	ExperimentDTO experimentToExperimentDTO(Experiment experiment);
	
	List<Grupo> gruposDTOToGrupos(List<GrupoDTO> gruposDTO);
	
	List<Phase> phasesDTOToPhases(List<PhaseDTO> phasesDTO);
}
