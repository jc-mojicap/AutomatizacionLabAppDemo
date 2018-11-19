package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.util.Date;

import edu.uniandes.automatizacion.servicios.dao.model.Usuario;

public class TokenDTO {

		private Integer id;
		private String token;
		private String estado;
		private Date vigencia;
		private Usuario usuario;

		public Integer getId() {
			return id;
		}

		public void setId(Integer id) {
			this.id = id;
		}

		public String getToken() {
			return token;
		}

		public void setToken(String token) {
			this.token = token;
		}

		public String getEstado() {
			return estado;
		}

		public void setEstado(String estado) {
			this.estado = estado;
		}

		public Date getVigencia() {
			return vigencia;
		}

		public void setVigencia(Date vigencia) {
			this.vigencia = vigencia;
		}

		public Usuario getUsuario() {
			return usuario;
		}

		public void setUsuario(Usuario usuario) {
			this.usuario = usuario;
		}

		@Override
		public int hashCode() {
			final int prime = 31;
			int result = 1;
			result = prime * result + ((id == null) ? 0 : id.hashCode());
			return result;
		}

		@Override
		public boolean equals(Object obj) {
			if (this == obj)
				return true;
			if (obj == null)
				return false;
			if (getClass() != obj.getClass())
				return false;
			TokenDTO other = (TokenDTO) obj;
			if (id == null) {
				if (other.id != null)
					return false;
			} else if (!id.equals(other.id))
				return false;
			return true;
		}

		@Override
		public String toString() {
			return "Token [" + (id != null ? "id=" + id + ", " : "") + (token != null ? "token=" + token + ", " : "")
					+ (estado != null ? "estado=" + estado + ", " : "")
					+ (vigencia != null ? "vigencia=" + vigencia + ", " : "")
					+ (usuario != null ? "usuario=" + usuario : "") + "]";
		}	
	}
