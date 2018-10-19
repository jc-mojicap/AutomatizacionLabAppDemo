package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Program;
import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ProgramDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;

@Mapper
public interface SubjectMapper {
	
	SubjectMapper INSTANCE = Mappers.getMapper(SubjectMapper.class);

	Subject subjectDTOToSubject(SubjectDTO subjectDTO);
	
	SubjectDTO subjectToSubjectDTO(Subject subject);
	
	Program programDTOToProgram(ProgramDTO programDTO);
    
	ProgramDTO programToProgramDTO(Program program);

}
