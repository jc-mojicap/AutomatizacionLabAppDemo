package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ElementDTO;

@Mapper
public interface ElementMapper {

	ElementMapper INSTANCE = Mappers.getMapper(ElementMapper.class);

	Element elementDTOToElement(ElementDTO elementDTO);
    
	ElementDTO elementToElementDTO(Element element);
        
    List<ElementDTO> elementsToElementDTO(List<Element> elements);
}
