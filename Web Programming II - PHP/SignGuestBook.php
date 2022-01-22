<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Sign Guest Book</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php

if(empty($_POST['first_name']) ||
	empty($_POST['last_name'])){
	echo "<p>You must enter your first and last name! Click your ";
	echo "browser's Back button to return to the Guest Book form.</p>";
	}
else {
	$DBConnect = @mysqli_connect("localhost:3308", "root", "");
	//$DBConnect = @mysqli_connect("localhost", "root", "password"); 2 different mysql
	if ($DBConnect){
		echo "<p>Connection made</p>"; 
		$DBName = "guestbook";
		if(!@mysqli_select_db($DBConnect,$DBName)){
			//guestbook database does not exist
			$SQLString = "CREATE DATABASE $DBName";
			$QueryResult = @mysqli_query($DBConnect, $SQLString);
			if($QueryResult === False){
				echo "<p>Query issue</p>".
				"<p>Error code: ".mysqli_connect_errno($DBConnect).
				mysqli_connect_error($DBConnect)."</p>";
			}
			else{
				//able to create the database
				echo "<p>You are the first visitor.</p>";
			}
		}
		mysqli_select_db($DBConnect,$DBName);
		
		//database exists now
		//how about the table?
		$TableName = "visitors";
		$SQLString = "SHOW TABLES LIKE '$TableName'";
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		if(mysqli_num_rows($QueryResult) == 0){
			//table doesn't exist
			$SQLString = "CREATE TABLE $TableName(countID SMALLINT NOT 
			NULL AUTO_INCREMENT PRIMARY KEY, last_name VARCHAR(40),
			first_name VARCHAR(40))";
			$QueryResult = @mysqli_query($DBConnect, $SQLString);
		}
		if($QueryResult === False){
			echo "<p>Table issue</p>".
			"<p>Error code: ".mysqli_connect_errno($DBConnect).
			mysqli_connect_error($DBConnect)."</p>";
		}
		else {
			//table exists
			$LastName = stripslashes($_POST['last_name']);
			//$LastName = str_replace("'","''",$LastName); //In case the user has a ' in their name
			$FirstName = stripslashes($_POST['first_name']);
		
			//add the data to the visitors table
			$SQLString = "INSERT INTO $TableName VALUES(NULL, '$LastName',
			'$FirstName')";
		
			$QueryResult = @mysqli_query($DBConnect, $SQLString);
		}
		//Check if it was successfully added
		if($QueryResult === False){
			echo "<p>Query was unable to execute</p>".
			"<p>Error code: ".mysqli_connect_errno($DBConnect).
			mysqli_connect_error($DBConnect)."</p>";
		}
		else {
			echo "<h1>Thank you for signing our guest book!</h1>";
		}
		mysqli_close($DBConnect);
	}
	else{
		echo "<p>Connection issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
}
?>

</body>
</html>