package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Element;

public interface ElementRepository extends JpaRepository<Element, Integer>{

	Element findByName(String name);
	
	Element findByType(String name);
}
