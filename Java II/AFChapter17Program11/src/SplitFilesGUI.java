import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

//Anthony Fuller
//Chapter 17 Program 11
//Split files GUI

public class SplitFilesGUI extends Application{
	
	private TextField tfFileName = new TextField();
	private TextField tfNumberOfFiles = new TextField();
	private Button btnStart = new Button("Start");

	public static void main(String[] args) {
		launch(args);
	}
	public void start(Stage ps) throws Exception{
				
		BorderPane pane = new BorderPane();
		GridPane gridPane = new GridPane();
		
		//Adds everything to the gridPane
		gridPane.add(new Label(
				"If you split a file named temp.txt into 3 smaller files,"),
					0, 0);
		gridPane.add(new Label(
				"the three smaller files are temp.txt.1,temp.txt.2,temp.txt.3"),
				0, 1);
		gridPane.add(new Label("Enter a file: "), 0, 3);
		gridPane.add(tfFileName, 3, 3);
		gridPane.add(new Label("Specify the number of smaller files: "), 0, 5);
		gridPane.add(tfNumberOfFiles, 3, 5);
		
		//Space in between each label and text field
		gridPane.setVgap(5);
		gridPane.setHgap(5);
		gridPane.setAlignment(Pos.CENTER);
		
		/*The code is from the video notes on 17.10.
		 * It has been modified to work with a gui */
		btnStart.setOnAction(e -> {
			
			try {
				//Create input stream from source file
				BufferedInputStream input = new BufferedInputStream(
						new FileInputStream(new File(tfFileName.getText())));
				
				//Number of pieces needed
				int numberOfPieces = Integer.parseInt(tfNumberOfFiles.getText());
				
				//Use the information the program obtained
				long fileSize = input.available();
				//Determines how big each piece is going to be
				int splitFileSize = (int) Math.ceil(
						1.0 * fileSize / numberOfPieces);
				
				//Do a loop to create the files
				for (int i = 1; i <= numberOfPieces; i++){
					BufferedOutputStream output = new BufferedOutputStream(
							new FileOutputStream(new File(tfFileName.getText() + "." + i)));
					
					int value;
					int count = 0;
					
					/*Inner loop that writes bytes to the file
					 *  until we reach the split file size*/
					while(count++ < splitFileSize && (value = input.read()) != -1){
						output.write(value);
					}
					
					//Close the file
					output.close();
				}
				
				//Lets user know the file was split successfully
				new Alert(Alert.AlertType.INFORMATION,
						"File size: " + fileSize + " bytes\n" + 
						"The file has been split successfully.").showAndWait();
				
				//Close the input
				input.close();
				
				//Forced catch blocks
			} catch (NumberFormatException ex) {
				new Alert(Alert.AlertType.ERROR,
						"Enter the number of files you want").showAndWait();
			} catch (FileNotFoundException ex) {
				new Alert(Alert.AlertType.ERROR,
						"The file was not found").showAndWait();
			} catch (IOException ex) {
				new Alert(Alert.AlertType.ERROR,
						"There was an error writing the files").showAndWait();
			}
			
		});
		
		//Sets the position of everything
		pane.setTop(gridPane);		
		pane.setBottom(btnStart);
		BorderPane.setAlignment(btnStart, Pos.BOTTOM_CENTER);
		
		//adds everything to the scene and stage
		Scene scene = new Scene(pane, 550, 150);		
		ps.setScene(scene);
		ps.setTitle("Exercise 17_11");
		ps.show();	
				
	}
}
