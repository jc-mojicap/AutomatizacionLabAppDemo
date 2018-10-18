package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.Mappings;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ExperimentDTO;

@Mapper
public interface ExperimentMapper {


	/**
     * Instancia de la clase.
     */
	ExperimentMapper INSTANCE = Mappers.getMapper(ExperimentMapper.class);

	@Mappings({
        @Mapping(source = "grupos", target = "grupos")
    })
	Experiment experimentDTOToExperiment(ExperimentDTO experimentDTO);
	
	ExperimentDTO experimentToExperimentDTO(Experiment experiment);
}
