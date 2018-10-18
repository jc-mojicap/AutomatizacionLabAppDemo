package edu.uniandes.automatizacion.servicios.service.log.iface;

import java.util.List;

import edu.uniandes.automatizacion.servicios.dao.model.Auditoria;

public interface AuditoriaService {

	List<Auditoria> findByTablaModificada(String tablaModificada);
	
	Auditoria guardarAuditoria(Auditoria auditoria);
	
}
