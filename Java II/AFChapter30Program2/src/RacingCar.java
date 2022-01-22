import javafx.application.Application;
import javafx.application.Platform;
import javafx.scene.Scene;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Polygon;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class RacingCar extends Application {

	private CarPane car;
	
	public static void main(String[] args) {
		launch();

	}

	@Override
	public void start(Stage primaryStage) throws Exception {
		car = new CarPane();
		Scene scene = new Scene(car,400,200);
		primaryStage.setScene(scene);
		primaryStage.show();
		
		
		//pause/resume based on mouse clicks
		car.requestFocus();
		car.setOnMousePressed(e -> car.suspend());
		car.setOnMouseReleased(e -> car.resume());
		car.setOnKeyPressed(e -> {
			if(e.getCode() == KeyCode.UP)
				car.faster();
			if(e.getCode() == KeyCode.DOWN)
				car.slower();
		});
	}
	
	public void stop(){
		car.suspend();
	}
}

class CarPane extends Pane {
	  private double w = 400;
	  private double h = 200;
	  private double baseX = 0;
	  private double baseY = h;
	  private Circle c1 = new Circle(baseX + 10 + 5, baseY - 10 + 5, 5);
	  private Circle c2 = new Circle(baseX + 30 + 5, baseY - 10 + 5, 5);
	    
	  private Rectangle carBody = new Rectangle(baseX, baseY - 20, 50, 10);
	  private Polygon carTop = new Polygon(baseX + 10, baseY - 20, 
	            baseX + 20, baseY - 30, baseX + 30, baseY - 30, 
	            baseX + 40, baseY - 20);   
	 private volatile int sleepTime = 50;
	 private Thread thread;
	 private volatile boolean active = true;
	 
	  public CarPane() {
	    carBody.setFill(Color.GREEN);
	    carTop.setFill(Color.RED);
	    this.getChildren().addAll(c1, c2, carBody, carTop);
	    
	    thread = new Thread(new CarTask());
	    
	    thread.start();

	  }


	  
	  public void suspend() {
	    active = false;
		
	  }
	  
	  public void resume() {
	    active = true;
	    thread = new Thread(new CarTask());
	    thread.start();
	  }
	  
	  public void faster() {
		  if (sleepTime >= 10)
	    sleepTime -= 2;
	  }
	  
	  public void slower() {
		  if (sleepTime <= 70)
	    sleepTime += 5;
	  }
	  
	  public void move() {
	    if (baseX > w)
	      baseX = -20;
	    else
	      baseX += 1;
	    
	    setValues();
	  }
	  
	  public void setValues() {
	    c1.setCenterX(baseX + 10 + 5);
	    c1.setCenterY(baseY - 10 + 5);
	    c2.setCenterX(baseX + 30 + 5);
	    c2.setCenterY(baseY - 10 + 5);

	    carBody.setX(baseX);
	    carBody.setY(baseY - 20);
	    
	    carTop.getPoints().clear();
	    carTop.getPoints().addAll(baseX + 10, baseY - 20, 
	            baseX + 20, baseY - 30, baseX + 30, baseY - 30, 
	            baseX + 40, baseY - 20);   
	  }
	  
	  public void setW(double w) {
	    this.w = w;
	    setValues();
	  }
	  
	  public void setH(double h) {
	    this.h = h;
	    baseY = h;
	    setValues();
	  }
	

	  class CarTask implements Runnable{

		  @Override
		  public void run() {
			  while(active){
				  Platform.runLater(new GUI_Task());
				  //System.out.println(thread);
				  try {
					Thread.sleep(sleepTime);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
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