package edu.uniandes.automatizacion.servicios.service.log.iface;

import java.util.List;

import edu.uniandes.automatizacion.servicios.dao.model.Trazabilidad;

public interface TrazabilidadService {

	List<Trazabilidad> findByNivelTraza(String nivelTraza);
	
	Trazabilidad guardarTraza(Trazabilidad trazabilidad);
	
}
