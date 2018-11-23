package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.GrupoRepository;
import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.SubjectRepository;
import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.SubjectService;


@Service
public class SubjectServiceImpl implements SubjectService {

	@Autowired
    private SubjectRepository subjectRepository;
    
    @Autowired
    private GrupoRepository grupoRepository;

    @Override
    public Subject saveSubject(Subject subject, Integer idGrupo) {
        //subjectRepository.save(subject);
        if (idGrupo == null){
            idGrupo = 1;
        }
        Grupo grupo = grupoRepository.findOne(idGrupo);
        grupo.getSubjects().add(subject);
        grupoRepository.save(grupo);
        return subject;
    }

    @Override
    public List<Subject> getSubjects() {
        return subjectRepository.findAll();
    }	
	
}
