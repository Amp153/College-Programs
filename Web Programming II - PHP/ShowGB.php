<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Guest Book Posts</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php

	$DBConnect = @mysqli_connect("localhost:3308", "root", "");
	//$DBConnect = @mysqli_connect("localhost", "root", "password"); 2 different mysql


	if ($DBConnect){
		$DBName = "guestbook";
		if(!@mysqli_select_db($DBConnect,$DBName)){
			//guestbook database does not exist
			$QueryResult = @mysqli_query($DBConnect, $SQLString);
			if($QueryResult === False){
				echo "<p>No entries in the guest book!</p>";
			}
			else{
				//guestbook database exists
				echo "<p>You are the first visitor.</p>";
			}
		}
		//database exists
		$TableName = "visitors";
		$SQLString = "SHOW TABLES LIKE '$TableName'";
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		
		
		if(mysqli_num_rows($QueryResult) == 0){
			//table doesn't exist
			echo "<p>There are no entries in the guest book!</p>";
		}
		else {
			//table exists
			//Display the results
			$Row = mysqli_fetch_assoc($QueryResult);
			
			echo "<p>The following visitors have signed our guestbook:</p>";
			echo "<table width = '100%' border = '1'";
			echo "<tr><th>First Name</th><th>Last Name</th></tr>";			
			while(($Row = mysqli_fetch_assoc($QueryResult)) !== NULL){
				echo "<tr><td>{$Row['first_name']}</td>";
				echo "<td>{$Row['last_name']}</td></tr>";
				
			}
			echo "</table>";
			
		}
		mysqli_free_result($QueryResult);
		mysqli_close($DBConnect);
}
else{
		echo "<p>Connection issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
?>

</body>
</html>