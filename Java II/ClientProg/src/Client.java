import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.Socket;

public class Client {
	private static Socket cs;

	public static void main(String[] args) {
		
		try {
			//cs = new Socket("localhost", 8000);
			cs = new Socket( "10.0.5.136", 8040); //computer on same network on 8040
			//DataInputStream fromServer =
			//		new DataInputStream(cs.getInputStream());
			BufferedReader fromServer =
							new BufferedReader(new InputStreamReader(cs.getInputStream()));
			String count = fromServer.readLine();
			System.out.println("I'm visitor " + count);
		} catch (IOException e) {
			
			e.printStackTrace();
		}
		
	}

}
