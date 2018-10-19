package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Program;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ProgramDTO;


@Mapper
public interface ProgramMapper {

	ProgramMapper INSTANCE = Mappers.getMapper(ProgramMapper.class);

    Program programDTOToProgram(ProgramDTO programDTO);
    
    ProgramDTO programToProgramDTO(Program program);
        
    List<ProgramDTO> programsToProgramaDTO(List<Program> programs);
    
}
