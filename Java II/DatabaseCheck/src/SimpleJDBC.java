import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
//import com.sun.rowset.*;

public class SimpleJDBC {
// % equals *
// _ equals ?
	public static void main(String[] args) throws ClassNotFoundException,
	SQLException {
		//RowSet approach
		//Class.forName("com.mysql.jdbc.Driver");
		//RowSet rs = new JdbcRowSetImpl();
		//rs.setUrl("jdbc:mysql://localhost/javabook");
		//rs.setUsername("scott");
		//rs.setPassword("tiger");
		//rs.setCommand("SELECT * FROM Student");
		//rs.execute();
		
		//1. load the driver
		Class.forName("com.mysql.jdbc.Driver");
		System.out.println("Driver loaded");

		//2. connect to a database
		Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/javabook",
				"scott","tiger");
		System.out.println("Connection made");
		
		//3. create a statement
		Statement state = conn.createStatement();
		System.out.println("Statement made");
		
		//4. work with the data ResultSet
		String query = "SELECT distinct firstname, mi, lastname from Student where lastname = 'Smith'";
		ResultSet rs = state.executeQuery(query);
		
		while(rs.next()){
			System.out.println(rs.getString(1));
		}
		
		//5. close the connection
		conn.close();
	}

}
