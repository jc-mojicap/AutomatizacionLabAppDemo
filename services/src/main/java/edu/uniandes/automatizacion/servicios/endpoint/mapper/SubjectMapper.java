package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.Mappings;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;

//@Mapper
public interface SubjectMapper {
	
	/**
     * Instancia de la clase.
     */
	/*SubjectMapper INSTANCE = Mappers.getMapper(SubjectMapper.class);

	@Mappings({
        @Mapping(source = "program", target = "program")
    })*/
	Subject subjectDTOToSubject(SubjectDTO subjectDTO);
	
	SubjectDTO subjectToSubjectDTO(Subject subject);

}
