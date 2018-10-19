package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.dao.model.Program;
import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ProgramDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;

@Mapper
public interface GrupoMapper {

	GrupoMapper INSTANCE = Mappers.getMapper(GrupoMapper.class);
	
	Grupo grupoDTOToGrupo(GrupoDTO grupoDTO);
	
	GrupoDTO grupoToGrupoDTO(Grupo grupo);
	
	List<Subject> subjectsDTOToSubjects(List<SubjectDTO> subjectsDTO);
	
	Subject subjectDTOToSubject(SubjectDTO subjectDTO);
	
	SubjectDTO subjectToSubjectDTO(Subject subject);
	
	Program programDTOToProgram(ProgramDTO programDTO);
    
	ProgramDTO programToProgramDTO(Program program);
	
}
