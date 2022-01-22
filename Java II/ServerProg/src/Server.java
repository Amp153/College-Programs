import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.RandomAccessFile;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Date;

import javafx.application.Application;
import javafx.application.Platform;
import javafx.scene.Scene;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.TextArea;
import javafx.stage.Stage;

public class Server extends Application{

	private static int count;
	private RandomAccessFile raf;
	private TextArea ta = new TextArea();
	private ServerSocket ss;

	public static void main(String[] args) {
		launch();

	}

	@Override
	public void start(Stage stage) throws Exception {
		Scene scene = new Scene(new ScrollPane(ta), 200, 200);
		stage.setScene(scene);
		stage.setTitle("SERVER");
		stage.show();

		//file prep
		try {
			
			if(new File("count.txt").exists()){
				raf = new RandomAccessFile("count.txt","rw");
				count = raf.readInt();
			}
			else {
				raf = new RandomAccessFile("count.txt","rw");
				count = 0;
			}

			//set up thread
			new Thread(() -> connectToClient()).start();
		}
		catch (IOException e){
			System.out.println("File issue");
		}
	}

	public void connectToClient(){
		try {
			ss = new ServerSocket(8000);
			Platform.runLater(() ->
			ta.appendText("Server started at " + new Date() + '\n'));

			//loop to wait for a client to come on board
			while (true){
				Socket sc = ss.accept();
				Platform.runLater(() ->
				ta.appendText("New client on board " +
						sc.getInetAddress() + '\n'));
				//set up a thread for the client communication
				ClientThread ct = new ClientThread(sc);
				ct.start();

			}
		}
		catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
	}

	//close up the sockets and the file when exiting
	public void stop(){
		try{
			ss.close();
			raf.close();
		}
		catch(IOException iex){
			iex.printStackTrace();
		}
	}



	class ClientThread extends Thread{
		private Socket s;

		public ClientThread(Socket sockeye){
			s = sockeye;
		}

		public void run(){
			try {
				PrintWriter output = new PrintWriter(s.getOutputStream(), true);
				count++;
				output.println(count);
				raf.seek(0);
				raf.writeInt(count);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}