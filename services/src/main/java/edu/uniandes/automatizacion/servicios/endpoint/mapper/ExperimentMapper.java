package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.dao.model.Program;
import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ElementDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ExperimentDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.PhaseDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ProgramDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.SubjectDTO;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;

@Mapper
public interface ExperimentMapper {

	ExperimentMapper INSTANCE = Mappers.getMapper(ExperimentMapper.class);

	Experiment experimentDTOToExperiment(ExperimentDTO experimentDTO);
	
	ExperimentDTO experimentToExperimentDTO(Experiment experiment);
	
	List<Grupo> gruposDTOToGrupos(List<GrupoDTO> gruposDTO);
	
	List<Phase> phasesDTOToPhases(List<PhaseDTO> phasesDTO);
	
	Grupo grupoDTOToGrupo(GrupoDTO grupoDTO);
	
	GrupoDTO grupoToGrupoDTO(Grupo grupo);
	
	Phase phaseDTOToPhase(PhaseDTO phaseDTO);
	
	PhaseDTO phaseToPhaseDTO(Phase phase);
	
	Subject subjectDTOToSubject(SubjectDTO subjectDTO);
	
	SubjectDTO subjectToSubjectDTO(Subject subject);
	
	Test TestDTOToTest(TestDTO testDTO);
    
	TestDTO testToTestDTO(Test test);
	
	Program programDTOToProgram(ProgramDTO programDTO);
    
	ProgramDTO programToProgramDTO(Program program);
	
	Element elementDTOToElement(ElementDTO elementDTO);
    
	ElementDTO elementToElementDTO(Element element);
    
}
