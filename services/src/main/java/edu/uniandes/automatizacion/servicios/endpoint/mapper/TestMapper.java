package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.Mappings;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;

//@Mapper
public interface TestMapper {

	/**
     * Instancia de la clase.
     */
	TestMapper INSTANCE = Mappers.getMapper(TestMapper.class);

    /**
     * Transforma un TestDTO en un Test.
     * @param testDTO Objeto a transformar.
     * @return Objeto transformado.
     */    
	/*@Mappings({
        @Mapping(source = "possibilities", target = "possibilities")
    })*/
	Test TestDTOToTest(TestDTO testDTO);
    
    /**
     * Transforma un Test en un TestDTO.
     * @param test Objeto a tranformar.
     * @return Objeto transformado.
     */    
	TestDTO testToTestDTO(Test test);
        
    /**
     * Transforma una lista de Test a una lista de TestDTO.
     * @param tests Lista a transformar.
     * @return Lista transformada.
     */
    List<TestDTO> testsToTestsDTO(List<Test> tests);
    
}
