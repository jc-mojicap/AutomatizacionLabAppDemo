package edu.uniandes.automatizacion.servicios.endpoint.catalogo;

import java.net.URISyntaxException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.ExperimentService;

@RestController
public class ExperimentRestEndpoint {
	
	private static final String MODULO = "catalogo";
    
    private static final String ENTIDAD = "experiment";

    @Autowired
    private ExperimentService experimentService;
   
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.GET)
    public Experiment getExperiment() throws URISyntaxException {
    	return experimentService.initializeExperiment();
    }
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.PUT)
    public Test setAnswer(@RequestBody Test test) throws URISyntaxException {
    	return experimentService.sendTestAnswer(test);
    }
    
}
