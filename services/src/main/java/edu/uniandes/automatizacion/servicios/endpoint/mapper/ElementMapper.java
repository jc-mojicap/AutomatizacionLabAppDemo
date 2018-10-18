package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ElementDTO;

@Mapper
public interface ElementMapper {

	/**
     * Instancia de la clase.
     */
	ElementMapper INSTANCE = Mappers.getMapper(ElementMapper.class);

    /**
     * Transforma un ElementDTO en un Program.
     * @param ElementDTO Objeto a transformar.
     * @return Objeto transformado.
     */    
	Element elementDTOToElement(ElementDTO elementDTO);
    
    /**
     * Transforma un Element en un ElementDTO.
     * @param element Objeto a tranformar.
     * @return Objeto transformado.
     */    
	ElementDTO elementToElementDTO(Element element);
        
    /**
     * Transforma una lista de Element a una lista de ElementDTO.
     * @param elements Lista a transformar.
     * @return Lista transformada.
     */
    List<ElementDTO> elementsToElementDTO(List<Element> elements);
}
