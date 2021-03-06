package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.CrudRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Garantia;

public interface GarantiaRepository extends JpaRepository<Garantia, Long>, CrudRepository<Garantia, Long> {
	
	Garantia findByIdGarantia(Long id);
}
