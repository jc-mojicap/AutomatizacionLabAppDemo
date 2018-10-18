package edu.uniandes.automatizacion.servicios.service.catalogo.iface;

import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Test;

public interface TestService {

	Test cargarTest();
	
	void enviarRespuesta(Element respuesta);
	
	
}
