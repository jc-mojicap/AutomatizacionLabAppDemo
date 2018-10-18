package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Subject;

public interface SubjectRepository extends JpaRepository<Subject, Integer> {

	List<Subject> findByIdSubject(Integer idSubject);
	//List<Subject> findByIdGrupo (Integer idGrupo);
}
