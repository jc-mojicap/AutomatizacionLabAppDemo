package edu.uniandes.automatizacion.servicios.service.log.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.TrazabilidadRepository;
import edu.uniandes.automatizacion.servicios.dao.model.Trazabilidad;
import edu.uniandes.automatizacion.servicios.service.log.iface.TrazabilidadService;

@Service
public class TrazabilidadServiceImpl implements TrazabilidadService{

	@Autowired
	private TrazabilidadRepository trazabilidadRepository;
	
	@Override
	public List<Trazabilidad> findByNivelTraza(String nivelTraza) {
		return trazabilidadRepository.findByNivelTraza(nivelTraza);
	}

	@Override
	public Trazabilidad guardarTraza(Trazabilidad trazabilidad) {
		return trazabilidadRepository.saveAndFlush(trazabilidad);
	}

}
