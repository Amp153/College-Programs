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
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.stage.Stage;

public class TableViewer extends Application {

	private TextField tfTableName = new TextField();
	private TableView tv = new TableView();
	private Button btShow = new Button("Show Contents");
	private Label lblStatus = new Label();
	private Statement state;

	public static void main(String[] args) {
		launch();

	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		//set up the gui
		HBox hbox = new HBox(5);
		hbox.getChildren().addAll(new Label("Table Name"), tfTableName, btShow);
		hbox.setAlignment(Pos.CENTER);

		BorderPane pane = new BorderPane();
		pane.setCenter(tv);
		pane.setTop(hbox);
		pane.setBottom(lblStatus);

		Scene scene = new Scene(pane, 420,180);
		primaryStage.setTitle("Table Viewer");
		primaryStage.setScene(scene);
		primaryStage.show();

		initializeDB();

		btShow.setOnAction(e -> showContents());

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
			lblStatus.setText("Ready");
		} catch(ClassNotFoundException ex){

			lblStatus.setText("Unable to load the driver" + ex.getMessage());

		} catch(SQLException ex){

			lblStatus.setText(ex.getMessage());

		}
	}

	private void showContents(){
		
		if (tfTableName.getText().isEmpty()){
			lblStatus.setText("Must enter a table name");
		}
		else {
			try {
				String query = "SELECT * FROM "+ tfTableName.getText();
				ResultSet rs = state.executeQuery(query);
				populateTableView(rs);

			} catch (SQLException e) {

				lblStatus.setText("Table doesn't exist");
			}
		}
	}

	public void populateTableView(ResultSet rs){
		String row = "";
		try {
			for(int f = 0; f < rs.getMetaData().getColumnCount(); f++){
				row += (rs.getMetaData().getColumnTypeName(f) + "\t");
			}
			
		} catch (SQLException e) {

			lblStatus.setText("Problem reading the table");
		}
	}


}
