package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;

public interface PhaseMapper {

	/**
     * Instancia de la clase.
     */
	PhaseMapper INSTANCE = Mappers.getMapper(PhaseMapper.class);

	Phase phaseDTOToPhase(PhaseDTO phaseDTO);
	
	PhaseDTO phaseToPhaseDTO(Phase phase);
	
}
