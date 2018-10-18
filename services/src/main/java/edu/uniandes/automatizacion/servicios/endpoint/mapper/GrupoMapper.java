package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.Mappings;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.endpoint.dto.GrupoDTO;

@Mapper
public interface GrupoMapper {

	/**
     * Instancia de la clase.
     */
	GrupoMapper INSTANCE = Mappers.getMapper(GrupoMapper.class);

	@Mappings({
        @Mapping(source = "make", target = "manufacturer"),
        @Mapping(source = "numberOfSeats", target = "seatCount")
    })
	Grupo grupoDTOToGrupo(GrupoDTO grupoDTO);
	
	GrupoDTO grupoToGrupoDTO(Grupo grupo);
	
}
