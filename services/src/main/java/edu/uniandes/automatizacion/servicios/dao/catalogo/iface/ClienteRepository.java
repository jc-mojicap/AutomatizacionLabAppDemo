package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Cliente;

public interface ClienteRepository extends JpaRepository<Cliente, Long> {

}
