import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;

import javax.swing.JOptionPane;

import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.stage.Stage;

//Anthony Fuller
//Chapter 17 Program 9
public class AddressBook extends Application{

	private TextField tfName = new TextField();
	private TextField tfStreet = new TextField();
	private TextField tfCity = new TextField();
	private TextField tfState = new TextField();
	private TextField tfZip = new TextField();
	private RandomAccessFile raf;
	
	final int NSIZE = 32;
	final int SSIZE = 32;
	final int CSIZE = 20;
	final int STSIZE = 2;
	final int ZSIZE = 5;
	final int RSIZE = NSIZE + SSIZE + CSIZE + STSIZE + ZSIZE;
	
	//rsize = record size
	
	public static void main(String[] args) {
		launch(args);
	}

	@Override
	public void start(Stage stage) {
		//random access file
		try {
			raf = new RandomAccessFile("address.dat", "rw");
			
			tfCity.setPrefColumnCount(12);
			tfState.setPrefColumnCount(2);
			tfZip.setPrefColumnCount(5);
			
			//buttons
			Button btAdd = new Button("Add");
			btAdd.setOnAction(e -> {
				try{
				writeData((int)raf.length());
				}
				catch(IOException ioex){
					JOptionPane.showMessageDialog(null, "File problem");
				}
			});
			
			Button btUpdate = new Button("Update");
			btUpdate.setOnAction(e -> {
				try{
					if(raf.length() == 0)
						JOptionPane.showMessageDialog(null, "Empty file");
				writeData((int)raf.getFilePointer() - RSIZE);
				}
				catch(IOException ioex){
					JOptionPane.showMessageDialog(null, "File problem");
				}
			});
			
			Button btFirst = new Button("First");
			btFirst.setOnAction(e -> {				
				readData(0);				
			});
			
			Button btLast = new Button("Last");
			btLast.setOnAction(e -> {
				try{
				readData((int)raf.length() - RSIZE);
				}
				catch(IOException ioex){
					JOptionPane.showMessageDialog(null, "File problem");
				}
			});
			
			Button btNext = new Button("Next");
			btNext.setOnAction(e -> {
				try{
					long fp = raf.getFilePointer();
					if(fp < raf.length())
						readData((int)fp);
					else
						JOptionPane.showMessageDialog(null, "End of file");
				}
				catch(IOException ioex){
					JOptionPane.showMessageDialog(null, "File problem");
				}
			});
			
			Button btPrevious = new Button("Previous");
			btPrevious.setOnAction(e -> {
				try{
					long fp = raf.getFilePointer();
					if(fp > 0)
						readData((int)fp - RSIZE);
					else
						JOptionPane.showMessageDialog(null, "Beginning of file");
				}
				catch(IOException ioex){
					JOptionPane.showMessageDialog(null, "File problem");
				}
			});
			
			//set up GUI
			GridPane p1 = new GridPane();
			p1.setAlignment(Pos.CENTER);
			p1.setHgap(5);
			p1.setVgap(5);
			p1.add(new Label("Name"), 0, 0);
			p1.add(new Label("Street"), 0, 1);
			p1.add(tfName, 1, 0);
			p1.add(tfStreet, 1, 1);
			
			HBox p2 = new HBox(5);
			p2.getChildren().addAll(new Label("City"),tfCity,
					new Label("State"),tfState,new Label("Zip"),tfZip);
			
			HBox p3 = new HBox(5);
			p2.getChildren().addAll(btAdd,btFirst,btNext,
					btPrevious,btLast,btUpdate);
			p3.setAlignment(Pos.CENTER);
			
			p1.add(p2, 1, 2);
			
			BorderPane bp = new BorderPane();
			bp.setCenter(p1);
			bp.setBottom(p3);
			
			Scene scene = new Scene(bp, 400, 200);
			stage.setTitle("Address Book");
			stage.setScene(scene);
			stage.show();
		
			//raf.close();
		}
		catch(FileNotFoundException ex){
			JOptionPane.showMessageDialog(null, "Invalid file");
		} catch (IOException e1) {
			
			JOptionPane.showMessageDialog(null, "Oops");
		}
		
		
		
	}
	//It'll throw to the other class with IOException
	void writeData(int pos) throws IOException{
		
		raf.seek(pos);
		
		//Write out the name
		char[] name = new char[NSIZE];
		//copy the string to the array
		for(int x = 0; x < tfName.getText().length(); x++)
			name[x] = tfName.getText().charAt(x);
		String n = new String(name);
		raf.writeBytes(n);
		
		//write out the street
		char[] street = new char[SSIZE];
		//copy the string to the array
		for(int x = 0; x < tfStreet.getText().length(); x++)
			street[x] = tfStreet.getText().charAt(x);
		String s = new String(street);
		raf.writeBytes(s);
		
		//city
		char[] city = new char[CSIZE];
		//copy the string to the array
		for(int x = 0; x < tfCity.getText().length(); x++)
			city[x] = tfCity.getText().charAt(x);
		String c = new String(city);
		raf.writeBytes(c);
		
		//state
		char[] state = new char[STSIZE];
		//copy the string to the array
		for(int x = 0; x < tfState.getText().length(); x++)
			state[x] = tfState.getText().charAt(x);
		String st = new String(state);
		raf.writeBytes(st);
		
		//zip
		char[] zip = new char[ZSIZE];
		//copy the string to the array
		for(int x = 0; x < tfZip.getText().length(); x++)
			zip[x] = tfZip.getText().charAt(x);
		String z = new String(zip);
		raf.writeBytes(z);
		
	}
	
	void readData(int pos){
		
	}

}
