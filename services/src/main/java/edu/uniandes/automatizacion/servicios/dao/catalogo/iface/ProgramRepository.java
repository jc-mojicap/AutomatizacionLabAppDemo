package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Program;

public interface ProgramRepository extends JpaRepository<Program, Integer>{

	Program findByCode(String code);
	
}
