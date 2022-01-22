<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>View Zodiac Feedback</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php include("Includes/inc_connect.php");

if($DBConnect === FALSE){
	
	echo "<p>Cannot find the database! Click your ";
	echo "browser's Back button to return to the Zodiac Feedback form.</p>";

}
 else{
	//database exists and is connected
	mysqli_select_db($DBConnect,$db_name);
		
	//check for the table
	$db_table = "zodiacfeedback";
	$SQLString = "SHOW TABLES LIKE '$db_table'";
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	if(mysqli_num_rows($QueryResult) == 0){
		//table doesn't exist
		echo "<p>There are no entries in the zodiacfeedback table!</p>";
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
	}
	if($QueryResult === False){
		echo "<p>Table issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	else {
		//table exists
		//Display the results
			
			$SQLString = "SELECT * FROM $db_table WHERE public_message = 'Y'";
			$QueryResult = @mysqli_query($DBConnect, $SQLString);
			
			echo "<p>The following visitors have left a public comment in the zodiacfeedback table:</p>";
			echo "<table width = '100%' border = '1'";
			echo "<tr><th>Message Date</th><th>Message Time</th><th>Sender</th><th>Message</th></tr>";			
			
			while($Row = mysqli_fetch_assoc($QueryResult)){
				echo "<tr><td>{$Row['message_date']}</td>";
				echo "<td>{$Row['message_time']}</td>";
				echo "<td>{$Row['sender']}</td>";
				echo "<td>{$Row['message']}</td></tr>";
				
			}
			echo "</table>";
			
		}
			
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	//Check if query was successfull
	if($QueryResult === False){
		echo "<p>Query was unable to execute</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	mysqli_free_result($QueryResult);
	mysqli_close($DBConnect);
}
?>

</body>
</html>