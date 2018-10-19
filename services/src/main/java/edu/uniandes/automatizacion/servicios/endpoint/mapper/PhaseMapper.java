package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ElementDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;

@Mapper
public interface PhaseMapper {

	PhaseMapper INSTANCE = Mappers.getMapper(PhaseMapper.class);

	Phase phaseDTOToPhase(PhaseDTO phaseDTO);
	
	PhaseDTO phaseToPhaseDTO(Phase phase);
	
	Test TestDTOToTest(TestDTO testDTO);
    
	TestDTO testToTestDTO(Test test);
	
	Element elementDTOToElement(ElementDTO elementDTO);
    
    ElementDTO elementToElementDTO(Element element);
    
	
}
