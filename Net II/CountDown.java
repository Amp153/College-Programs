import java.io.File;

import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.TextField;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;
import javafx.stage.Stage;
import javafx.util.Duration;

//Anthony Fuller
//Chapter 16 Program 21

public class CountDown extends Application{

	private TextField txt = new TextField();
	
	//I don't know why this doesn't work
	
	MediaPlayer mp = new MediaPlayer(new Media(new File("audio/Item_StereoPan01.wav").toURI().toString()));
	
	public static void main(String[] args) {
		launch();

	}

	Timeline ani;
	
	@Override
	public void start(Stage ps) throws Exception {
		// TODO Auto-generated method stub
		
		
		BorderPane pane = new BorderPane();
		GridPane gridPane = new GridPane();
		
		gridPane.add(txt, 0, 0);
		pane.setCenter(txt);
		
		ani = new Timeline(new KeyFrame(Duration.millis(1000), e ->  {
			int seconds = Integer.parseInt(txt.getText());
			txt.setText(seconds - 1 + "");
			if (seconds - 1 == 0) {
				ani.stop();
				mp.play();
				
			}
			
		}));
		ani.setCycleCount(Timeline.INDEFINITE);
		
		//The code is supposed to count down when you hit enter
		txt.setOnKeyPressed(e -> {
			if(e.getCode() == KeyCode.ENTER){
				if (txt.getText() != null ){
					ani.play();
					mp.stop();
					/*
				if (Integer.parseInt(txt.getText()) > 0){
					for(int val = Integer.parseInt(txt.getText());val > 0 ;val--){
					for(int timer = 1000; timer < 1; timer--)
						txt.setText(Integer.toString(val));
						*/
					
				}
			}
			});
			//}}}
			
			//I was going to use this to test where to put the file but I
			//didn't get that far.
		//	if(e.getCode() == KeyCode.ESCAPE){
				//mp.play();
		//	}
			
		//});
		
		
		
		Scene scene = new Scene(pane, 550, 550);
		ps.setScene(scene);
		ps.setTitle("Count-Down Timer");
		ps.show();
		
	}

}
