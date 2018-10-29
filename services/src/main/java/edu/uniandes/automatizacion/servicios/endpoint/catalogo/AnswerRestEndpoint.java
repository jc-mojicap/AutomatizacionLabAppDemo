package edu.uniandes.automatizacion.servicios.endpoint.catalogo;

import java.net.URISyntaxException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import edu.uniandes.automatizacion.servicios.dao.model.Answer;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.AnswerService;

@RestController
public class AnswerRestEndpoint {
	
	private static final String MODULO = "catalogo";
    
    private static final String ENTIDAD = "answer";

    @Autowired
    private AnswerService answerService;
   
    
    @RequestMapping(value = "/" + MODULO + "/" + ENTIDAD, method = RequestMethod.POST)
    public Answer postAnswer( @RequestBody Answer answer) throws URISyntaxException {
    	return answerService.enviarRespuesta(answer);
    }

    
}
