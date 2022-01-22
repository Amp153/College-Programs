/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package student;

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author Anthony Fuller
 */
@Named(value = "student")
@RequestScoped
public class StudentBean {
    private final String tableName = new String("Student");
    private Statement state;
    private String tfId;
    private String tfLastName;
    private String tfFirstName;
    private String tfMi;
    private String tfAddress;
    private String tfZipCode;
    private String tfBirthDate;
    private String tfTelephone;
    private String major;
    private String lblStatus;
    

    /**
     * Creates a new instance of StudentBean
     */
    public StudentBean() {
        //Starts on initial load to let user know if there is an error
        initializeDB();
    }
    
    public String getId(){
        return tfId;
    }
    public void setId(String id){
        tfId = id;
    }
    public String getLastName(){
        return tfLastName;
    }
    public void setLastName(String lastName){
        tfLastName = lastName;
    }
    public String getFirstName(){
        return tfFirstName;
    }
    public void setFirstName(String firstName){
        tfFirstName = firstName;
    }
    public String getMi(){
        return tfMi;
    }
    public void setMi(String mi){
        tfMi = mi;
    }
    public String getAddress(){
        return tfAddress;
    }
    public void setAddress(String address){
        tfAddress = address;
    }
    public String getZipCode(){
        return tfZipCode;
    }
    public void setZipCode(String city){
        tfZipCode = city;
    }
    public String getBirthDate(){
        return tfBirthDate;
    }
    public void setBirthDate(String birthDate){
        tfBirthDate = birthDate;
    }
    public String getTelephone(){
        return tfTelephone;
    }
    public void setTelephone(String telephone){
        tfTelephone = telephone;
    }
    public String getMajor(){
        return major;
    }
    public void setMajor(String major){
        this.major = major;
    }
    
    public String getResponse(){
        if (tfId == null)
            return ""; // request not made
        else {
            
            getUpdate();
            
            return "<p style=\"color:red\">You entered <br />" +
                    "SSN: " + tfId + "<br />" + 
                    "Last Name: " + tfLastName + "<br />" + 
                    "First Name: " + tfFirstName + "<br />" + 
                    "MI: " + tfMi + "<br />" + 
                    "Address: " + tfAddress + "<br />" + 
                    "ZipCode: " + tfZipCode + "<br />" + 
                    "BirthDate: " + tfBirthDate + "<br />" + 
                    "Telephone: " + tfTelephone + "<br />" + 
                    "Major: " + major + "</p>";
            
        }
    }
    
    //I'm separateing the more basic html and java commands
    //with this comment
    
    public String getStatus(){
        return lblStatus;
    }
    //not working
    public void getUpdate(){

		String query = "UPDATE " + tableName +
				" SET lastName = '" + tfLastName +"', firstName = '"+ tfFirstName +
				"', mi = '"+ tfMi +"', street = '"+ tfAddress +
				"', zipCode = '"+ tfZipCode +"', birthDate = '"+ tfBirthDate +"', phone = '" +
				tfTelephone +"' WHERE ssn = "+ tfId;

		try{

			//update the table at the current ssn
			state.executeUpdate(query);	

                        lblStatus = "<p style=\"color:blue\">Completed successfully <br /></p>";


		} catch(SQLException ex){

                        lblStatus = "<p style=\"color:blue\">Unable to update the data from the specified table"+
                                ex.getMessage()+"<br /></p>";

		}
	}
    
    //doesn't work
    public String getTable(){
        
        String query = "select * from " + tableName;  

		try {

			ResultSet rs = state.executeQuery(query);

			//displays the results
			//if there is data to enter
                        
			if(rs.next()){
                            return 
                                "<tr><th> SSN </th>" + 
                                "<th>Last Name </th>" + 
                                "<th>First Name </th>" + 
                                "<th>MI </th>" + 
                                "<th>Address </th>" + 
                                "<th>ZipCode </th>" + 
                                "<th>BirthDate </th>" + 
                                "<th>Telephone </th>" + 
                                "<th>Major </th></tr>" +
                                "<tr><td>" + rs.getString(1) + "</td>" + 
                                "<td>" + rs.getString(4) + "</td>" + 
                                "<td>" + rs.getString(2) + "</td>" + 
                                "<td>" + rs.getString(3) + "</td>" + 
                                "<td> " + rs.getString(7) + "</td>" + 
                                "<td> " + rs.getString(8) + "</td>" + 
                                "<td>" + rs.getString(6) + "</td>" + 
                                "<td>" + rs.getString(5) + "</td>" + 
                                "<td>" + rs.getString(9) + "</td></tr>";
				

                                //lblStatus = "<p style=\"color:blue\">Completed successfully <br /></p>";
                        }

                    } catch(SQLException ex){

                        lblStatus = "<p style=\"color:blue\">Unable to retrieve the data from the table"+
                                ex.getMessage()+"<br /></p>";

		}
                return "";
    
    }
    
    private void initializeDB(){
		try{

			//1. load the driver
			Class.forName("com.mysql.jdbc.Driver");
                        lblStatus = "<p style=\"color:blue\">Driver loaded <br /></p>";

			//2. connect to a database
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/javabook",
					"scott","tiger");
                        lblStatus = "<p style=\"color:blue\">Connected to database <br /></p>";

			//3. create a birthDatement
			state = conn.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);
                        lblStatus = "<p style=\"color:blue\">Ready <br /></p>";

		} catch(ClassNotFoundException ex){

                        lblStatus = "<p style=\"color:blue\">Unable to load the driver"+
                                ex.getMessage()+"<br /></p>";

		} catch(SQLException ex){

                        lblStatus = "<p style=\"color:blue\">"+
                                ex.getMessage()+"<br /></p>";

		}
	}
    
}
