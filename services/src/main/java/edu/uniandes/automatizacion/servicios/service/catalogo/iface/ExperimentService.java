package edu.uniandes.automatizacion.servicios.service.catalogo.iface;

import edu.uniandes.automatizacion.servicios.dao.model.Experiment;
import edu.uniandes.automatizacion.servicios.dao.model.Test;

public interface ExperimentService {

	Experiment initializeExperiment();
	
	Test sendTestAnswer(Test test);

}
