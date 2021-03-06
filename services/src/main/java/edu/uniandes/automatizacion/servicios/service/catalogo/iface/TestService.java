package edu.uniandes.automatizacion.servicios.service.catalogo.iface;

import java.util.List;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Test;

public interface TestService {

	Test cargarTest();
	
	List<Test> listarTests();
	
	Test crearTest(Test test);
	
	Test enviarRespuesta(Test test);
	
	Element obtenerSiguientePregunta();
	
	
}
