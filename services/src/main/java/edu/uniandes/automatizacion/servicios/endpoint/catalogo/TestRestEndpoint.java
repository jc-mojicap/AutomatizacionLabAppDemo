package edu.uniandes.automatizacion.servicios.endpoint.catalogo;

import java.net.URISyntaxException;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TestDTO;
import edu.uniandes.automatizacion.servicios.endpoint.mapper.TestMapper;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.TestService;

@RestController
public class TestRestEndpoint {
	
	private static final String MODULO = "catalogo";
    
    private static final String ENTIDAD = "test";

    @Autowired
    private TestService testService;
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.POST)
    public TestDTO crearTest(@RequestBody final TestDTO dto) throws URISyntaxException {
    	Test test = TestMapper.INSTANCE.TestDTOToTest(dto);
    	TestDTO testDTO = TestMapper.INSTANCE.testToTestDTO(testService.crearTest(test));
    	return testDTO;    	
    }
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.GET)
    public List<Test> listarTests() throws URISyntaxException {
    	return testService.listarTests();
    }
    
    
}
