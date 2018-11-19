package edu.uniandes.automatizacion.servicios.endpoint.mapper;

import java.util.List;

import org.mapstruct.Mapper;
import org.mapstruct.factory.Mappers;

import edu.uniandes.automatizacion.servicios.dao.model.Trazabilidad;
import edu.uniandes.automatizacion.servicios.endpoint.dto.TrazabilidadDTO;

@Mapper
public interface TrazabilidadMapper {

	TrazabilidadMapper INSTANCE = Mappers.getMapper(TrazabilidadMapper.class);

	Trazabilidad trazabilidadDTOToTrazabilidad(TrazabilidadDTO trazabilidadDTO);
    
	TrazabilidadDTO trazabilidadToTrazabilidadDTO(Trazabilidad trazabilidad);
        
    List<TrazabilidadDTO> trazabilidadesToTrazabilidadDTO(List<Trazabilidad> trazabilidades);
}
