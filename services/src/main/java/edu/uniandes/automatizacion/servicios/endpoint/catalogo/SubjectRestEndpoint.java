package edu.uniandes.automatizacion.servicios.endpoint.catalogo;

import java.net.URISyntaxException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.SubjectService;

@RestController
public class SubjectRestEndpoint {
	
	private static final String MODULO = "catalogo";
    
    private static final String ENTIDAD = "subject";

    @Autowired
    private SubjectService subjectService;
   
    
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.POST)
    public Subject setAnswer(@RequestBody Subject subject) throws URISyntaxException {
    	return subjectService.saveSubject(subject);
    }
    
}