package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.Mappings;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;

@Mapper
public interface PhaseMapper {

	/**
     * Instancia de la clase.
     */
	PhaseMapper INSTANCE = Mappers.getMapper(PhaseMapper.class);

	@Mappings({
        @Mapping(source = "tests", target = "tests")
    })
	Phase phaseDTOToPhase(PhaseDTO phaseDTO);
	
	@Mappings({
        @Mapping(source = "tests", target = "tests")
    })
	PhaseDTO phaseToPhaseDTO(Phase phase);
	
}
