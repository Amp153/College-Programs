import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

//Anthony Fuller
//Chapter 32 Exercise 1

public class UpdateStaffTable extends Application{
	
	private String tableName = new String("Staff");
	private Label lblStatus = new Label();
	private Statement state;
	private TextField tfId = new TextField();
	private TextField tfLastName = new TextField();
	private TextField tfFirstName = new TextField();
	private TextField tfMi = new TextField();
	private TextField tfAddress = new TextField();
	private TextField tfCity = new TextField();
	private TextField tfState = new TextField();
	private TextField tfTelephone = new TextField();
	private Button btnView = new Button("View");
	private Button btnInsert = new Button("Insert");
	private Button btnUpdate = new Button("Update");
	private Button btnClear = new Button("Clear");

	public static void main(String[] args) {
		launch();
	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		//set up the panes
		BorderPane pane = new BorderPane();
		GridPane gridPane = new GridPane();
		GridPane gridPaneBtn = new GridPane();
		
		//set the labels and buttons
		gridPane.add(new Label("ID "), 0, 0);
		gridPane.add(tfId, 1, 0);
		gridPane.add(new Label("Last Name "),0,1);
		gridPane.add(tfLastName, 1, 1);
		gridPane.add(new Label("First Name "),2,1);
		gridPane.add(tfFirstName, 3, 1);
		gridPane.add(new Label("MI "),4,1);
		gridPane.add(tfMi, 5, 1);
		gridPane.add(new Label("Address "),0,2);
		gridPane.add(tfAddress, 1, 2);
		gridPane.add(new Label("City "),0,3);
		gridPane.add(tfCity, 1, 3);
		gridPane.add(new Label("State "),2,3);
		gridPane.add(tfState, 3, 3);
		gridPane.add(new Label("Telephone "),0,4);
		gridPane.add(tfTelephone, 1, 4);
		gridPaneBtn.add(btnView, 0, 0);
		gridPaneBtn.add(btnInsert, 1, 0);
		gridPaneBtn.add(btnUpdate, 2, 0);
		gridPaneBtn.add(btnClear, 3, 0);
		
		//Space in between each label and text field
		gridPane.setVgap(5);
		gridPane.setHgap(5);
		gridPane.setAlignment(Pos.CENTER);
		gridPaneBtn.setVgap(5);
		gridPaneBtn.setHgap(5);
		gridPaneBtn.setAlignment(Pos.CENTER);
		
		//Sets the position of everything
		gridPane.setAlignment(Pos.CENTER);
		pane.setCenter(gridPane);		
		pane.setBottom(gridPaneBtn);
		BorderPane.setAlignment(gridPaneBtn, Pos.BOTTOM_CENTER);
		pane.setTop(lblStatus);
		
		Scene scene = new Scene(pane, 650, 230);
		primaryStage.setTitle("ExtraExercise32_01");
		primaryStage.setScene(scene);
		primaryStage.show();
		
		initializeDB();
		
		btnView.setOnAction(e -> view());
		btnInsert.setOnAction(e -> insert());
		btnUpdate.setOnAction(e -> update());
		btnClear.setOnAction(e -> clear());
		
	}
	
	public void view(){
		
		
		String query = "select * from " + tableName +" where id is "+ tfId;
					
		try{
			
			ResultSet rs = state.executeQuery(query);
			
			//sets the results into the text fields
			tfLastName.setText(rs.getObject(2) + "");
			tfFirstName.setText(rs.getObject(3) + "");
			tfMi.setText(rs.getObject(4) + "");
			tfAddress.setText(rs.getObject(5) + "");
			tfCity.setText(rs.getObject(6) + "");
			tfState.setText(rs.getObject(7) + "");
			tfTelephone.setText(rs.getObject(8) + "");
			
			rs.close();
		
		} catch(SQLException ex){
			
			lblStatus.setText("unable to retrieve the data from the specified table");
			
		}
		
		
	}
	
	public void insert(){
			
		String query = "INSERT INTO " + tableName +
				"(id, lastName, firstName, mi, address, city, state, telephone) VALUES("+
				tfLastName.getText()+", "+tfFirstName.getText()+", "+tfMi.getText()+", "+
				tfAddress.getText()+", "+tfCity+", "+tfState.getText()+", "+
				tfTelephone.getText()+")";
		
		try{
			//insert the current values
			ResultSet rs = state.executeQuery(query);
			rs.next();
			
			rs.close();
		
		} catch(SQLException ex){
			
			lblStatus.setText("unable to retrieve the data from the specified table");
			
		}
		
		
	}
	
	public void update(){
		
		String query = "UPDATE " + tableName +
				"SET lastName = "+ tfLastName.getText() +" firstName = "+ tfFirstName.getText() +
				", mi = "+ tfMi.getText() +", address = "+ tfAddress.getText() +
				", city = "+ tfCity +", state = "+ tfState.getText() +", telephone = " +
				tfTelephone.getText() +" WHERE id = "+ tfId;
					
		try{
			//update the table at the current id
			ResultSet rs = state.executeQuery(query);
			rs.next();
			
			rs.close();
		
		} catch(SQLException ex){
			
			lblStatus.setText("unable to retrieve the data from the specified table");
			
		}
		
		
	}
	
	public void clear(){
		
		//clears all of the text fields
		 tfId.setText(""); 
		 tfLastName.setText("");
		 tfFirstName.setText("");
		 tfMi.setText("");
		 tfAddress.setText("");
		 tfCity.setText("");
		 tfState.setText("");
		 tfTelephone.setText("");
		 
	}
	
	private void initializeDB(){
		try{
			
			//1. load the driver
			Class.forName("com.mysql.jdbc.Driver");
			lblStatus.setText("Driver loaded");

			//2. connect to a database
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/javabook",
					"scott","tiger");
			lblStatus.setText("Connection made");
			
			//3. create a statement
			state = conn.createStatement();
			lblStatus.setText("Statement made");
			
			} catch(ClassNotFoundException ex){
				
				lblStatus.setText("Unable to load the driver" + ex.getMessage());
				
			} catch(SQLException ex){
				
				lblStatus.setText(ex.getMessage());
				
			}
			
		}
}
