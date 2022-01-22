import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.input.MouseButton;
import javafx.scene.layout.Pane;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;
//Anthony Fuller
//Chapter 15 Program 17
//Geometry: find the bounding rectangle

public class AFChapter15Program17 extends Application{

	public static void main(String[] args) {
		launch(args);
	}
	
	@Override
	public void start(Stage ps) throws Exception {
		Pane pane = new Pane();
		Scene scene = new Scene(pane, 550, 550);
		
		//Every time the user clicks inside the program
		pane.setOnMouseClicked(e -> {
			
			//Get the current X and Y coordinates and sets the radius
			double cx = e.getX();
			double cy = e.getY();
			Circle circle = new Circle(cx, cy, 10);
			
			//Every left click add a circle
			if(e.getButton() == MouseButton.PRIMARY){
				pane.getChildren().add(circle);
				
				//Every right click clear the screen
			} else if(e.getButton() == MouseButton.SECONDARY){
				
				//I don't know how to delete just one circle
				//pane.getChildren().clear();
				
				//Revised after seeing the code //use instanceof to check if circle
				for(int i = 0; i < pane.getChildren().size();i++){
					if(pane.getChildren().get(i).contains(cx,cy))
						pane.getChildren().remove(i);
				}
			}
				
		});
		
		ps.setScene(scene);
		ps.setTitle("Exercise 15_17");
		ps.show();		
	}

}
