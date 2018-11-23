package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.SubjectRepository;
import edu.uniandes.automatizacion.servicios.dao.model.Subject;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.SubjectService;


@Service
public class SubjectServiceImpl implements SubjectService {

	@Autowired
	private SubjectRepository subjectRepository;

	@Override
	public Subject saveSubject(Subject subject) {
		// TODO Auto-generated method stub
		subjectRepository.save(subject);
		return subject;
	}

	
	
}
