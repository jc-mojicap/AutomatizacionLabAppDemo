package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Program;
import edu.uniandes.automatizacion.servicios.endpoint.dto.ProgramDTO;


@Mapper
public interface ProgramMapper {

	/**
     * Instancia de la clase.
     */
	ProgramMapper INSTANCE = Mappers.getMapper(ProgramMapper.class);

    /**
     * Transforma un ProgramDTO en un Program.
     * @param programDTO Objeto a transformar.
     * @return Objeto transformado.
     */    
	Program programDTOToProgram(ProgramDTO programDTO);
    
    /**
     * Transforma un Program en un ProgramDTO.
     * @param test Objeto a tranformar.
     * @return Objeto transformado.
     */    
	ProgramDTO programToProgramDTO(Program program);
        
    /**
     * Transforma una lista de Program a una lista de ProgramDTO.
     * @param tests Lista a transformar.
     * @return Lista transformada.
     */
    List<ProgramDTO> programsToProgramaDTO(List<Program> programs);
}
