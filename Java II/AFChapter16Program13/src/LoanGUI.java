import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

//Anthony Fuller
//Chapter 16 Program 13

public class LoanGUI extends Application{
	
	private TextField tfLoanAmount = new TextField();
	private TextField tfNumberOfYears = new TextField();
	private TextArea txtArea = new TextArea();
	private Button btnCalculate = new Button("Show Table");
	
	public static void main(String[] args) {
		launch(args);

	}

	@Override
	public void start(Stage ps) throws Exception {
		
		BorderPane pane = new BorderPane();
		GridPane gridPane = new GridPane();
		
		//Adds everything to the gridPane in a single row
		gridPane.add(new Label("Loan Amount"), 0, 0);
		gridPane.add(tfLoanAmount, 1, 0);
		gridPane.add(new Label("Number of Years"), 2, 0);
		gridPane.add(tfNumberOfYears, 3, 0);
		gridPane.add(btnCalculate, 4, 0);
		
		//Space in between each label and text field
		gridPane.setVgap(5);
		gridPane.setHgap(5);
		gridPane.setAlignment(Pos.CENTER);
		
		//Prevents the user from messing with the table
		txtArea.setEditable(false);
		
		//Enabling the commented code causes a crash when the button is pressed
		
		/*btnCalculate.setOnAction(e -> {

			txtArea.clear();
			int years = Integer.parseInt(tfNumberOfYears.getText());
			double amount = Double.parseDouble(tfLoanAmount.getText());
			txtArea.setText("Interest Rate			Monthly Payment			TotalPayment");

			for(double loanAmount = 5; loanAmount < 8; loanAmount =+ .125){
				
				Loan(loanAmount,years,amount);
				
				txtArea.insertText(0, loanAmount + "    " + getMonthlyPayment() + "    " + getTotalPayment());
			}
		});*/
		
		//Sets the position of everything
		pane.setTop(gridPane);
		pane.setCenter(txtArea);
		
		//adds everything to the scene and stage
		Scene scene = new Scene(pane, 650, 250);		
		ps.setScene(scene);
		ps.setTitle("Exercise 16_13");
		ps.show();	
	}

	
	private double annualInterestRate;
	private int numberOfYears;
	private double loanAmount;
	private java.util.Date loanDate;
	
	
	private String Loan(double annualInterestRate, int numberOfYears,
			   double loanAmount) {
		 this.annualInterestRate = annualInterestRate;
		 this.numberOfYears = numberOfYears;
		 this.loanAmount = loanAmount;
		 loanDate = new java.util.Date();
		return null;
	}
	/** Return annualInterestRate */
	public double getAnnualInterestRate() {
	 return annualInterestRate;
	}

	/** Set a new annualInterestRate */
	public void setAnnualInterestRate(double annualInterestRate) {
	 this.annualInterestRate = annualInterestRate;
	}

	/** Return numberOfYears */
	public int getNumberOfYears() {
	 return numberOfYears;
	}

	/** Set a new numberOfYears */
	public void setNumberOfYears(int numberOfYears) {
	 this.numberOfYears = numberOfYears;
	}

	/** Return loanAmount */
	public double getLoanAmount() {
	 return loanAmount;
	}

	/** Set a newloanAmount */
	public void setLoanAmount(double loanAmount) {
	 this.loanAmount = loanAmount;
	}

	/** Find monthly payment */
	public double getMonthlyPayment() {
	 double monthlyInterestRate = annualInterestRate / 1200;
	 double monthlyPayment = loanAmount * monthlyInterestRate / (1 -
	   (Math.pow(1 / (1 + monthlyInterestRate), numberOfYears * 12)));
	 return monthlyPayment;    
	}

	/** Find total payment */
	public double getTotalPayment() {
	 double totalPayment = getMonthlyPayment() * numberOfYears * 12;
	 return totalPayment;    
	}

	/** Return loan date */
	public java.util.Date getLoanDate() {
	 return loanDate;
	}

}
