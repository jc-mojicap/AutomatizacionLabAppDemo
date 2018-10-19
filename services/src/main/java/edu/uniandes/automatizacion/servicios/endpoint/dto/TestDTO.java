package edu.uniandes.automatizacion.servicios.endpoint.dto;

import java.io.Serializable;
import java.util.List;

public class TestDTO implements Serializable{

	private static final long serialVersionUID = 1L;

	private Long idTest;
	private String name;
	private Boolean isRepeatable;
	private Integer tries;
	private ElementDTO initial;
	private List<ElementDTO> possibilities;
	
	public TestDTO() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Long getIdTest() {
		return idTest;
	}

	public void setIdTest(Long idTest) {
		this.idTest = idTest;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Boolean getIsRepeatable() {
		return isRepeatable;
	}

	public void setIsRepeatable(Boolean isRepeatable) {
		this.isRepeatable = isRepeatable;
	}

	public Integer getTries() {
		return tries;
	}

	public void setTries(Integer tries) {
		this.tries = tries;
	}

	public ElementDTO getInitial() {
		return initial;
	}

	public void setInitial(ElementDTO initial) {
		this.initial = initial;
	}

	public List<ElementDTO> getPossibilities() {
		return possibilities;
	}

	public void setPossibilities(List<ElementDTO> possibilities) {
		this.possibilities = possibilities;
	}
	
}
