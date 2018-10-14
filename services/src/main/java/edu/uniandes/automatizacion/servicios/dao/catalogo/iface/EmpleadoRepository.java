package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Empleado;

public interface EmpleadoRepository extends JpaRepository<Empleado, Long> {

}
