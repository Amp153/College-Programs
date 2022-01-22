import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.control.ScrollBar;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.paint.Color;
import javafx.scene.text.Text;
import javafx.stage.Stage;

//Anthony Fuller
//Chapter 16 Program 17
public class Sliders extends Application{

	private ScrollBar scbRed = new ScrollBar();
	private ScrollBar scbGreen = new ScrollBar();
	private ScrollBar scbBlue = new ScrollBar();
	private ScrollBar scbOpacity = new ScrollBar();
	private Text text = new Text("Show Color");
	
	public static void main(String[] args) {
		launch(args);
	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		BorderPane pane = new BorderPane();
		GridPane gridPane = new GridPane();
		
		//place labels and scrollbars in the grid pane
		gridPane.add(new Label("Red"), 0, 0);
		gridPane.add(new Label("Green"), 0, 1);
		gridPane.add(new Label("Blue"), 0, 2);
		gridPane.add(new Label("Opacity"), 0, 3);
		
		//Add the scrollbars to the pane
		gridPane.add(scbRed, 1, 0);
		gridPane.add(scbGreen, 1, 1);
		gridPane.add(scbBlue, 1, 2);
		gridPane.add(scbOpacity, 1, 3);
		
		//Space in between each label
		gridPane.setVgap(5);
		gridPane.setHgap(5);
		gridPane.setAlignment(Pos.CENTER);
		
		pane.setBottom(gridPane);
		pane.setCenter(text);
		
		scbRed.setMax(1);
		scbGreen.setMax(1);
		scbBlue.setMax(1);
		scbOpacity.setMax(1);
		
		scbRed.valueProperty().addListener(e -> updateColor());
		scbGreen.valueProperty().addListener(e -> updateColor());
		scbBlue.valueProperty().addListener(e -> updateColor());
		scbOpacity.valueProperty().addListener(e -> updateColor());
		
		Scene scene = new Scene(pane, 250,150);
		primaryStage.setTitle("Colors");
		primaryStage.setScene(scene);
		primaryStage.show();
	}
	private void updateColor(){
		double red = scbRed.getValue();
		double green = scbGreen.getValue();
		double blue = scbBlue.getValue();
		double opacity = scbOpacity.getValue();
		
		//chose color instead of RBG. rbg is 255,255,255,1 
		text.setFill(Color.color(red, green, blue, opacity));
	}

}
