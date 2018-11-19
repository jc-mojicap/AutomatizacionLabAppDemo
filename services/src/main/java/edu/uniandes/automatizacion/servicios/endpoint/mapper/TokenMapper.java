package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Token;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TokenDTO;

@Mapper
public interface TokenMapper {

	TokenMapper INSTANCE = Mappers.getMapper(TokenMapper.class);

	Token tokenDTOToToken(TokenDTO tokenDTO);
    
	TokenDTO tokenToTokenDTO(Token token);
        
    List<TokenDTO> tokensToTokenDTO(List<Token> tokens);
}
