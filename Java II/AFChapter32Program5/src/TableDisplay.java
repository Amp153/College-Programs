import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;

import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.stage.Stage;

public class TableDisplay extends Application{

	private TextField tfTableName = new TextField();
	private TextArea taResults = new TextArea();
	private Button btnContents = new Button("Show Contents");
	private Label lblStatus = new Label();
	private Label lblInstructions = new Label("Table Name: ");
	private Statement state;
	//private PreparedStatement state;
	
	public static void main(String[] args) {
		launch(args);

	}
	
	@Override
	public void start(Stage primaryStage){
		HBox hBox = new HBox(5);
		hBox.getChildren().addAll(lblInstructions, tfTableName, btnContents);
		hBox.setAlignment(Pos.CENTER);
		
		BorderPane pane = new BorderPane();
		pane.setTop(hBox);
		pane.setCenter(new ScrollPane(taResults));
		pane.setBottom(lblStatus);
		
		Scene scene = new Scene(pane, 420, 400);
		primaryStage.setTitle("Table Display");
		primaryStage.setScene(scene);
		primaryStage.show();
		
		initializeDB();
		
		btnContents.setOnAction(e -> showContents());
	}
	
	public void showContents(){
		String tableN = tfTableName.getText();
		
		String query = "select * from " + tableN;
			
		//commented code was to try with prepared statements but that doesn't work on from clause
		//she took far too long trying to make it work
		
		try{
			//state.setString(1, tableN);
			ResultSet rs = state.executeQuery(query);
			//ResultSet rs = state.executeQuery();
			
			ResultSetMetaData rsMD = rs.getMetaData();
			taResults.setText("");
			
			
			int colCount = rsMD.getColumnCount();
			for (int c = 1; c <= colCount; c++)
				taResults.appendText(rsMD.getColumnName(c) + "  ");
			taResults.appendText("\n");
			
			
			//Wanted to use tableView from javafx but teacher forgot how (tableview is old)
			while(rs.next()){
				for (int c = 1; c <= colCount; c++){
					//specifically this part
					taResults.appendText(rs.getObject(c) + "  ");
				}
			taResults.appendText("\n");
			}
			
		
		} catch(SQLException ex){
			
			lblStatus.setText("unable to retrieve the data from the specified table");
			
		}
		
		
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
			//state = conn.prepareStatement("select * from ?");
			lblStatus.setText("Statement made");
			
			//In a different program conn.close() was here
			} catch(ClassNotFoundException ex){
				
				lblStatus.setText("Unable to load the driver" + ex.getMessage());
				
			} catch(SQLException ex){
				
				lblStatus.setText(ex.getMessage());
				
			}
			
			//Not mentioned at all
			//5. close the connection
			//conn.close();
		}
	}
	


