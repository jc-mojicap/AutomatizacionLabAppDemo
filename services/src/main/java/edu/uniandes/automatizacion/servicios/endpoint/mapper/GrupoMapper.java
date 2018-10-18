package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;

public interface GrupoMapper {

	GrupoMapper INSTANCE = Mappers.getMapper(GrupoMapper.class);

	Grupo grupoDTOToGrupo(GrupoDTO grupoDTO);
	
	GrupoDTO grupoToGrupoDTO(Grupo grupo);
	
}
