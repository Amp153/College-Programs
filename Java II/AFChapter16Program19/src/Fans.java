import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Slider;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;
import javafx.util.Duration;

//Anthony Fuller
//Chapter 16 Program 19
public class Fans extends Application{

	public static void main(String[] args) {
		launch(args);
	}

	@Override
	public void start(Stage ps) throws Exception {
		HBox hbox = new HBox(3);
		
		FanControl fan1 = new FanControl();
		FanControl fan2 = new FanControl();
		FanControl fan3 = new FanControl();
		
		fan1.setStyle("-fx-border-color:black");
		fan2.setStyle("-fx-border-color:black");
		fan3.setStyle("-fx-border-color:black");
		
		hbox.getChildren().addAll(fan1,fan2,fan3);
		
		BorderPane pane = new BorderPane();
		pane.setCenter(hbox);
		
		Button btStartAll = new Button("Start All");
		btStartAll.setOnAction(e -> {
			fan1.start();
			fan2.start();
			fan3.start();
		});
		Button btStopAll = new Button("Stop All");
		btStopAll.setOnAction(e -> {
			fan1.stop();
			fan2.stop();
			fan3.stop();
		});
		HBox hbox2 = new HBox(10);
		hbox2.setAlignment(Pos.CENTER);
		hbox2.getChildren().addAll(btStartAll,btStopAll);
		
		pane.setBottom(hbox2);
	
		
		Scene scene = new Scene(pane,650,250);
		ps.setScene(scene);
		ps.setTitle("Fan Magic");
		ps.show();
	}

}

//contains the animation
class FanControl extends BorderPane{
	//adding the fans
	private FanPane fan = new FanPane();
	//adding animation
	private Timeline ani = new Timeline(new KeyFrame(Duration.millis(100),
			e -> fan.move()));
	
	//adds everything to the pane
	public FanControl(){
		HBox hbox = new HBox(5);
		Button btPause = new Button("Pause");
		btPause.setOnAction(e -> ani.pause());
	
		Button btResume = new Button("Resume");
		btResume.setOnAction(e -> ani.play());
		
		Button btReverse = new Button("Reverse");
		btReverse.setOnAction(e -> fan.reverse());
		
		hbox.setAlignment(Pos.CENTER);
		hbox.getChildren().addAll(btPause,btResume,btReverse);
		
		this.setCenter(fan);
		this.setTop(hbox);
		
		Slider slSpeed = new Slider();
		slSpeed.setValue(10);
		slSpeed.setMax(20);
		ani.rateProperty().bind(slSpeed.valueProperty());
		//repeats the animation
		ani.setCycleCount(Timeline.INDEFINITE);
	
		this.setBottom(slSpeed);
	}
	
	public void start(){
		ani.play();
	}
	
	public void stop(){
		ani.pause();
	}
}

//contains the fan
class FanPane extends Pane{
	
	private double w = 200;
	private double h = 200;
	private double radius = 90;
	private double sa = 30;
	private Arc arcs[] = new Arc[4];
	private Circle c = new Circle(w/2,h/2,radius);
	//How much the arcs move //When sliders got implemented this is overwriten
	private double increment = 5;
	
	//Creates the fan
	FanPane(){
		c.setStroke(Color.BLACK);
		c.setFill(Color.WHITE);
		//no pane because this is the pane
		getChildren().add(c);
		
		for(int x = 0; x < 4; x++){
			arcs[x] = new Arc(w/2,h/2,radius * .9,
					radius * .9, sa + x * 90,35);
			arcs[x].setFill(Color.PURPLE);
			arcs[x].setType(ArcType.ROUND);
			getChildren().add(arcs[x]);
		}
		
	}
	
	public void reverse(){
		increment = - increment;
	}
	
	public void move(){
		//System.out.println("Debuging code");
		setStartAngle(sa + increment);
	}
	
	public void setStartAngle(double angle){
		sa = angle;
		for (int x = 0; x < 4; x++)
			arcs[x].setStartAngle(sa + x * 90);
		
		
	}
}