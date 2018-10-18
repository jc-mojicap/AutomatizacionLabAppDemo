package edu.uniandes.automatizacion.servicios.dao.catalogo.iface;

import org.springframework.data.jpa.repository.JpaRepository;

import edu.uniandes.automatizacion.servicios.dao.model.Answer;

public interface AnswerRepository extends JpaRepository<Answer, Integer>{

	Answer findByName(String name);
	
	Answer findByIdAnswer(Integer idAnswer);
}
