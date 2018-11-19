package edu.uniandes.automatizacion.servicios.endpoint.dto;

public class AnswerDTO {

		private Integer idAnswer;
		private int phase;
		private int block;
		private int test_number;
		private String test_type;
		private String test;
		private String givenAnswer;
		private boolean correct;
		private double reactionTime;
		
		

		public AnswerDTO() {
			super();
			// TODO Auto-generated constructor stub
		}

		public Integer getIdAnswer() {
			return idAnswer;
		}

		public void setIdAnswer(Integer idAnswer) {
			this.idAnswer = idAnswer;
		}

		public int getPhase() {
			return phase;
		}

		public void setPhase(int phase) {
			this.phase = phase;
		}

		public int getBlock() {
			return block;
		}

		public void setBlock(int block) {
			this.block = block;
		}

		public int getTest_number() {
			return test_number;
		}

		public void setTest_number(int test_number) {
			this.test_number = test_number;
		}

		public String getTest_type() {
			return test_type;
		}

		public void setTest_type(String test_type) {
			this.test_type = test_type;
		}

		public String getTest() {
			return test;
		}

		public void setTest(String test) {
			this.test = test;
		}

		public String getGivenAnswer() {
			return givenAnswer;
		}

		public void setGivenAnswer(String givenAnswer) {
			this.givenAnswer = givenAnswer;
		}

		public boolean isCorrect() {
			return correct;
		}

		public void setCorrect(boolean correct) {
			this.correct = correct;
		}

		public double getReactionTime() {
			return reactionTime;
		}

		public void setReactionTime(double reactionTime) {
			this.reactionTime = reactionTime;
		}

		
}
