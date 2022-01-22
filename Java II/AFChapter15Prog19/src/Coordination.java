import java.util.Random;

import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.text.Text;
import javafx.stage.Stage;
//Anthony Fuller
//Chapter 15 Program 19
//eye-hand coordination
public class Coordination extends Application {

	int cx,cy;
	Circle circle;
	Random ran = new Random();
	int count;
	long startTime;
	Pane pane;
	Text txt = new Text(20,20, "");
	
	public static void main(String[] args) {
		launch(args);

	}

	@Override
	public void start(Stage ps) throws Exception{
		
		startTime= System.currentTimeMillis();
		Pane pane = new Pane();
		//makes the coordinates at random
		
		cx = ran.nextInt(500);
		cy = ran.nextInt(500);
		
		//makes the circle appear
		circle = new Circle(cx, cy, 10);
		
		pane.getChildren().addAll(circle, txt);
		
		//Imports and set gui size
		Scene scene = new Scene(pane, 550, 550);
		
		//Anonymous
		//circle.setOnMouseClicked(new CircleClick());
		/*circle.setOnMouseClicked(new EventHandler<MouseEvent>(){

			@Override
			public void handle(MouseEvent event) {
				// TODO Auto-generated method stub
				cx = ran.nextInt(500);
				cy = ran.nextInt(500);
				
				circle.setFill(new Color(Math.random(), Math.random(),
						Math.random(), 1));
				
				circle.setCenterX(cx);		
				circle.setCenterY(cy);
				count++;
				
				if(count == 5){
					
					long duration = System.currentTimeMillis() - startTime;
					pane.getChildren().add(new Text(20,20, "Time spent" + duration));
				}
			}
			
		});*/
		circle.setOnMouseClicked(e -> {
			
				cx = ran.nextInt(500);
				cy = ran.nextInt(500);
				
				circle.setFill(new Color(Math.random(), Math.random(),
						Math.random(), 1));
				
				circle.setCenterX(cx);		
				circle.setCenterY(cy);
				count++;
				
				//Text txt = null;
				if(count == 5){
					
					long duration = System.currentTimeMillis() - startTime;
					txt.setText("Time spent" + duration);
					
					startTime= System.currentTimeMillis();
					count = 0;
				}else if (count == 1){
					
					txt.setText("");
					//pane.getChildren().add(txt);
				}			
		});
		
		ps.setScene(scene);
		ps.setTitle("Eye Hand Coordination");
		ps.show();
		
	}
	//Name is anything
	/*class CircleClick implements EventHandler<MouseEvent>{
		
		//@Override
		public void handle(MouseEvent event){
		//System.out.println("Mouse Clicked"); Debug
		
		cx = ran.nextInt(500);
		cy = ran.nextInt(500);
		
		circle.setFill(new Color(Math.random(), Math.random(),
				Math.random(), 1));
		
		circle.setCenterX(cx);		
		circle.setCenterY(cy);
		count++;
		
		if(count == 20){
			
			long duration = System.currentTimeMillis() - startTime;
			pane.getChildren().add(new Text(20,20, "Time spent" + duration));
		}}
	}*/
}
