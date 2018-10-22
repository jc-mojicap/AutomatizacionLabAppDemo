package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

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
	public Test enviarRespuesta(Test test) {
		// TODO recibir respuesta, y retornar el siguiente paso
		int currentTry = test.getCurrentTry();
		currentTry++;
		boolean intentoValido = false;
		if (test.getTries() < currentTry){
			intentoValido = validarRespuesta(test);
			if (!intentoValido){
				testRepository.save(test);
			}
		}
		return null;
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

	private boolean validarRespuesta(Test test){
		//TODO agregar logica para saber si el intento fue válido
		Test phase1Test1 = new Test();
		phase1Test1.setName("phase1Test1");
		Element initial = new Element();
		initial.setName("initial");
		initial.setPathImage("/main/webapp/estimulos/A1.JPG");
		phase1Test1.setInitial(initial);
		
		
		return false;
	}
	

}
