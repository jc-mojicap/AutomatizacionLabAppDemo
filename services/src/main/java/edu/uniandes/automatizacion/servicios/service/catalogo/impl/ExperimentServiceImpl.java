package edu.uniandes.automatizacion.servicios.service.catalogo.impl;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Random;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import edu.uniandes.automatizacion.servicios.dao.catalogo.iface.ExperimentRepository;
import edu.uniandes.automatizacion.servicios.dao.model.Answer;
import edu.uniandes.automatizacion.servicios.dao.model.Element;
import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.dao.model.Grupo;
import edu.uniandes.automatizacion.servicios.dao.model.Phase;
import edu.uniandes.automatizacion.servicios.dao.model.Test;
import edu.uniandes.automatizacion.servicios.service.catalogo.iface.ExperimentService;


@Service
public class ExperimentServiceImpl implements ExperimentService {

	@Autowired
	private ExperimentRepository experimentRepository;

	@Override
	public Experiment initializeExperiment() {
		// TODO Auto-generated method stub
		Experiment experimento = new Experiment();
		try {
			experimento.setName("Experimento de muestra");
			experimento.setDescription("Experimento de muestra para clase automatización");
			experimento.setStatus("A");
			
			
			
			Grupo grupo = new Grupo();
			grupo.setDescription("Grupo 1 de sujetos de prueba");
			grupo.setName("Grupo 1");
			grupo.setStatus("A");
			
			Grupo grupo2 = new Grupo();
			grupo2.setDescription("Grupo 2 de sujetos de prueba");
			grupo2.setName("Grupo 2");
			grupo2.setStatus("A");
			
			List<Grupo> experimentGroups = new ArrayList<Grupo>();
			experimentGroups.add(grupo);
			experimentGroups.add(grupo2);
			
			experimento.setGrupos(experimentGroups);
			
			
			List<Phase> experimentPhases = new ArrayList<Phase>();
			
			for(int i =1; i<=9; i++) {
				Phase phase = new Phase();
				phase.setInstructions("Instrucciones fase "+i);
				phase.setInstructionsSoundPath("FASE"+i+".WAV");
				phase.setIsRepeatable(true);
				phase.setName("Fase "+i);
				phase.setPosition(i);
				phase.setTries(2);
				experimentPhases.add(phase);
			}
			
			
			Iterator<Phase> phaseIterator = experimentPhases.iterator();
			
			while(phaseIterator.hasNext()) {
				Phase phase= phaseIterator.next();
				List<Test> phaseTests = new ArrayList<Test>();
				for(int i =1; i<=this.returnRandomTestQuantity(); i++) {
					Test test = new Test();
					test.setName("T"+i+"P"+phase.getPosition());
					test.setIsRepeatable(true);
					test.setTries(2);
					
					// crear un elemento inicial 
					Element initial = new Element();
					initial.setIsAnswer(false);
					String literal =this.returnRandomElementLiteral();
					if(literal.equalsIgnoreCase("A")||
							literal.equalsIgnoreCase("B")||
							literal.equalsIgnoreCase("C")
						) {
						literal=literal+this.returnRandomNumberABC();
					} else if( literal.equalsIgnoreCase("X")) {
						literal=literal+this.returnRandomNumberX();
					} else if(literal.equalsIgnoreCase("P")) {
						literal=literal+this.returnRandomNumberP();
					} else if (literal.equalsIgnoreCase("N")) {
						literal=literal+this.returnRandomNumberN();
					}		
					initial.setName(literal);
					initial.setType("IMAGE");
					initial.setPathImage(literal+".JPG");
					initial.setIsInitial(true);
					
					List<Element> testElements = new ArrayList<Element>();
					
					testElements.add(initial);
					
					Element initialAnswer = new Element();
					initialAnswer.setIsAnswer(true);
					initialAnswer.setName(literal);
					initialAnswer.setPathImage(literal+".JPG");
					initialAnswer.setType("IMAGE");
					initialAnswer.setIsInitial(false);
					testElements.add(initialAnswer);
					
					for (int j=1; j<=2; j++) {
						Element option = new Element();
						option.setIsAnswer(false);
						initialAnswer.setIsInitial(false);
						String literalOption =this.returnRandomElementLiteral();
						if(literalOption.equalsIgnoreCase("A")||
								literalOption.equalsIgnoreCase("B")||
								literalOption.equalsIgnoreCase("C")
							) {
							literalOption=literalOption+this.returnRandomNumberABC();
						} else if( literalOption.equalsIgnoreCase("X")) {
							literalOption=literalOption+this.returnRandomNumberX();
						} else if(literalOption.equalsIgnoreCase("P")) {
							literalOption=literalOption+this.returnRandomNumberP();
						} else if (literalOption.equalsIgnoreCase("N")) {
							literalOption=literalOption+this.returnRandomNumberN();
						}
						
						option.setName(literalOption);
						option.setType("IMAGE");
						option.setPathImage(literalOption+".JPG");
						testElements.add(option);
					}
					
					test.setPossibilities(testElements);
					Answer answer = new Answer();
					test.setSelectedAnswer(answer);
					phaseTests.add(test);
				} // fin test 
				
				phase.setTests(phaseTests);
			}
			
			experimento.setPhases(experimentPhases);
			experimentRepository.save(experimento);
			
			
		} catch(Exception e) {
			e.printStackTrace();
		}
		return experimento;
	}
	

	public Integer returnRandomTestQuantity() {
		Integer quantity = 1;
		Random rand = new Random();
		quantity  = rand.nextInt(20) + 1;
		return quantity;
	}

	public String returnRandomElementLiteral() {
		String literal ="";
	    final String alphabet = "ABCNKPX";
	    final int n = alphabet.length();

	    Random r = new Random();

	    for (int i = 0; i < 50; i++) {
	        literal = String.valueOf(alphabet.charAt(r.nextInt(n)));
	    }
		return literal;
		
	}
	
	public Integer returnRandomNumberABC() {
		Integer elementNumber = 1;
		Random rand = new Random();
		elementNumber  = rand.nextInt(2) + 1;
		return elementNumber;
		
	}
	
	public Integer returnRandomNumberN() {
		Integer elementNumber = 1;
		Random rand = new Random();
		elementNumber  = rand.nextInt(8) + 1;
		return elementNumber;
		
	}
	
	public Integer returnRandomNumberX() {
		Integer elementNumber = 1;
		Random rand = new Random();
		elementNumber  = rand.nextInt(12) + 1;
		return elementNumber;
	}
	
	public Integer returnRandomNumberP() {
		Integer elementNumber = 1;
		Random rand = new Random();
		elementNumber  = rand.nextInt(6) + 1;
		return elementNumber;
	}
	
}
