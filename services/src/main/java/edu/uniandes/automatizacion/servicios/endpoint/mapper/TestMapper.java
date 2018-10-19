package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ElementDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;

@Mapper
public interface TestMapper {

	TestMapper INSTANCE = Mappers.getMapper(TestMapper.class);

    Test TestDTOToTest(TestDTO testDTO);
    
    TestDTO testToTestDTO(Test test);
        
    Element elementDTOToElement(ElementDTO elementDTO);
	
	ElementDTO elementToElementDTO(Element element);
}
