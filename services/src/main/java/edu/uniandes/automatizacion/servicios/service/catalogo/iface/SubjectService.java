package edu.uniandes.automatizacion.servicios.service.catalogo.iface;

import java.util.List;

import edu.uniandes.automatizacion.servicios.dao.model.Subject;

public interface SubjectService {

    Subject saveSubject(Subject subject, Integer idGrupo);
    
    List<Subject> getSubjects();

}