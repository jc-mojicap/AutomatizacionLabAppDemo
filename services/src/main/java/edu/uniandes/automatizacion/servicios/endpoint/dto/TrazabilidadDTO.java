package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.Date;



public class TrazabilidadDTO {

	
		private int id;
		private Date fecha;
		private String nivelTraza;
		private String mensaje;

		public int getId() {
			return id;
		}

		public void setId(int id) {
			this.id = id;
		}

		public Date getFecha() {
			return fecha;
		}

		public void setFecha(Date fecha) {
			this.fecha = fecha;
		}

		public String getNivelTraza() {
			return nivelTraza;
		}

		public void setNivelTraza(String nivelTraza) {
			this.nivelTraza = nivelTraza;
		}

		public String getMensaje() {
			return mensaje;
		}

		public void setMensaje(String mensaje) {
			this.mensaje = mensaje;
		}

	}
