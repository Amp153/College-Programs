<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Process Zodiac Feedback</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php include("Includes/inc_connect.php");

if($DBConnect === FALSE){
	
	echo "<p>Cannot find the database! Click your ";
	echo "browser's Back button to return to the Zodiac Feedback form.</p>";

	//validate all of the fields if connection is successful
} else if(empty($_POST['sender']) ||
	empty($_POST['message'])){
	
	echo "<p>You must enter your name and a message! Click your ";
	echo "browser's Back button to return to the Zodiac Feedback form.</p>";
	
} else{
	//database exists and is connected
	
	mysqli_select_db($DBConnect,$db_name);
		
	//check for the table
	$db_table = "zodiacfeedback";
	$SQLString = "SHOW TABLES LIKE '$db_table'";
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	if(mysqli_num_rows($QueryResult) == 0){
		//table doesn't exist
		$SQLString = "CREATE TABLE $db_table(message_date DATE,
		message_time TIME, sender VARCHAR(40),
		message VARCHAR(250), public_message ENUM('Y','N'))";
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
	}
	if($QueryResult === False){
		echo "<p>Table issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	else {
		//table exists
		$Name = stripslashes($_POST['sender']);
		$Message = stripslashes($_POST['message']);
	
		//add the data to the table 
		if(!isset($_POST['public_message'])){
		$SQLString = "INSERT INTO $db_table VALUES(CURDATE(), CURTIME(), '$Name',
		'$Message', 'N')";
		} else {
		$SQLString = "INSERT INTO $db_table VALUES(CURDATE(), CURTIME(), '$Name',
		'$Message', 'Y')";
		}
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
	}
	//Check if it was successfully added
	if($QueryResult === False){
		echo "<p>Query was unable to execute</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	else {
		echo "<h1>Thank you for entering a comment!</h1>";
	}
	mysqli_close($DBConnect);
}
?>

</body>
</html>