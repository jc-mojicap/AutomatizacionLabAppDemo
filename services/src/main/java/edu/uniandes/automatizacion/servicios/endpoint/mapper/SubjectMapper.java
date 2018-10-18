package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;

public interface SubjectMapper {
	
	/**
     * Instancia de la clase.
     */
	SubjectMapper INSTANCE = Mappers.getMapper(SubjectMapper.class);

	Subject subjectDTOToSubject(SubjectDTO subjectDTO);
	
	SubjectDTO subjectToSubjectDTO(Subject subject);

}
