import javafx.application.Application;
import javafx.application.Platform;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;

//Anthony Fuller
//Chapter 30 Program 5
//Display a running fan

public class FanWithThreading extends Application {
	
	private FanPane fan;

	public static void main(String[] args) {
		
		launch();

	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		HBox hbox = new HBox();
		fan = new FanPane();
		
		hbox.getChildren().add(fan);
		
		BorderPane pane = new BorderPane();
		pane.setCenter(hbox);
		hbox.setAlignment(Pos.CENTER);
		
		//Adding the pause button
		Button btnPause = new Button("Pause");
		btnPause.setOnAction(e -> {
			fan.pause();
		});
		
		//Adding the resume button
		Button btnResume = new Button("Resume");
		btnResume.setOnAction(e -> {
			fan.play();
		});
		
		//Adding the reverse button
		Button btnReverse = new Button("Reverse");
		btnReverse.setOnAction(e -> {
			fan.reverse();
		});
		
		HBox hboxBtn = new HBox(10);
		hboxBtn.setAlignment(Pos.CENTER);
		hboxBtn.getChildren().addAll(btnPause,btnResume,btnReverse);
		
		//Adding the buttons to the bottom of the pane
		pane.setBottom(hboxBtn);
		
		//Adding everything to the pane
		Scene scene = new Scene(pane, 250, 250);
		primaryStage.setScene(scene);
		primaryStage.setTitle("Fan With Threading");
		primaryStage.show();
	}
	
	//Prevents threads from slowing computer down
	public void stop(){
		fan.pause();
	}

}
class FanPane extends Pane {
	  private double w = 200;
	  private double h = 200;
	  private double radius = Math.min(w, h) * 0.45;
	  private Arc arc[] = new Arc[4];   
	  private double startAngle = 30;
	  private Circle circle = new Circle(w / 2, h / 2, radius);
	    
	  private int sleepTime = 50;

	  private volatile boolean active = false;
	  
	  private Thread thread = new Thread(() -> {
	      //Implementing runnable
		  new FanTask();
	  });
	  
	  public void pause() {
	   //Stops the thread
	   active = false;
	  }
	  
	  public void play() {
	    //Starts the thread if the thread isn't active
		  if(active == false){
			  active = true;
			  thread = new Thread(new FanTask());
			  thread.start();
			  }
	  }
	  
	  public FanPane() {
	    circle.setStroke(Color.BLACK);
	    circle.setFill(Color.WHITE);
	    getChildren().add(circle);
	         
	    for (int i = 0; i < 4; i++) {
	      arc[i] = new Arc(w / 2, h / 2, radius * 0.9, radius * 0.9, startAngle + i * 90, 35);
	      arc[i].setFill(Color.RED); // Set fill color
	      arc[i].setType(ArcType.ROUND);
	      getChildren().addAll(arc[i]); 
	    } 

	    //Start the initial thread
	    thread.start();
	  }
	  
	  private double increment = 5;
	  
	  public void reverse() {
	    increment = -increment;
	  }
	  
	  public void move() {
	    setStartAngle(startAngle + increment);
	  }
	    
	  public void setStartAngle(double angle) {
	    startAngle = angle;
	    setValues();
	  }
	  
	  public void setValues() {
	    radius = Math.min(w, h) * 0.45;
	    circle.setRadius(radius);
	    circle.setCenterX(w / 2);
	    circle.setCenterY(h / 2);
	         
	    for (int i = 0; i < 4; i++) {
	      arc[i].setRadiusX(radius * 0.9);
	      arc[i].setRadiusY(radius * 0.9);
	      arc[i].setCenterX(w / 2);
	      arc[i].setCenterY(h / 2);
	      arc[i].setStartAngle(startAngle + i * 90);
	    }     
	  }
	  
	  public void setW(double w) {
	    this.w = w;
	    setValues();
	  }
	  
	  public void setH(double h) {
	    this.h = h;
	    setValues();
	  }
	  //Implementing runnable because of the threads
	  class FanTask implements Runnable{

		  @Override
		  public void run() {
			  while(active){
				  Platform.runLater(new GUI_Task());
				  try {
					Thread.sleep(sleepTime);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			  }
		
		  }
	
	  }

	  class GUI_Task implements Runnable{

		  @Override
		  public void run() {
			  move();
		
		  }
	
	  }
	}

