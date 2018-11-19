package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Answer;
import edu.uniandes.automatizacion.servicios.endpoint.dto.AnswerDTO;

@Mapper
public interface AnswerMapper {

	AnswerMapper INSTANCE = Mappers.getMapper(AnswerMapper.class);

	Answer answerDTOToAnswer(AnswerDTO answerDTO);
    
	AnswerDTO answerToAnswerDTO(Answer element);
        
    List<AnswerDTO> answersToAnswerDTO(List<Answer> answers);
}
