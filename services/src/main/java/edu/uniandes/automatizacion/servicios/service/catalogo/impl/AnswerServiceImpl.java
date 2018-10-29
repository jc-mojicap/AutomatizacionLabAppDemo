package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.AnswerRepository;
import edu.uniandes.automatizacion.servicios.dao.model.Answer;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.AnswerService;

@Service
public class AnswerServiceImpl implements AnswerService {

	@Autowired
	private AnswerRepository answerRepository;
	
	@Override
	public Answer enviarRespuesta(Answer answer) {
		// TODO Auto-generated method stub
		answerRepository.save(answer);
		return answer;
	}
}
