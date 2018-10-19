package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.model.Answer;
import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.TestService;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.TestRepository;

@Service
public class TestServiceImpl implements TestService {

	@Autowired
	private TestRepository testRepository;
	
	@Override
	public Test cargarTest() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Test crearTest(Test test) {
		return testRepository.save(test);
	}

	@Override
	public void enviarRespuesta(Answer respuesta) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public Element obtenerSiguientePregunta() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Test> listarTests() {
		return testRepository.findAll();
	}

	

}
