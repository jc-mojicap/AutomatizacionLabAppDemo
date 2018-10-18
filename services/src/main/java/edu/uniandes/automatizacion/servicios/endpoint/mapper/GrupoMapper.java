package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;

@Mapper
public interface GrupoMapper {

	/**
     * Instancia de la clase.
     */
	GrupoMapper INSTANCE = Mappers.getMapper(GrupoMapper.class);

	Grupo grupoDTOToGrupo(GrupoDTO grupoDTO);
	
	GrupoDTO grupoToGrupoDTO(Grupo grupo);
	
}
