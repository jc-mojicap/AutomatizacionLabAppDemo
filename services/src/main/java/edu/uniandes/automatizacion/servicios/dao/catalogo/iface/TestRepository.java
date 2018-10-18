package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Test;

public interface TestRepository extends JpaRepository<Test, Integer>{
	
	Test findByName(String name);

}
