<?php include("Includes/inc_connect.php");

//check for the table
	$db_table = "visit_counter";
	$SQLString = "SHOW TABLES LIKE '$db_table'";
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	if($QueryResult === False){
		echo "<p>Table issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}

	if(mysqli_num_rows($QueryResult) == 0){
		//table doesn't exist
		$SQLString = "CREATE TABLE $db_table(id INT NOT NULL AUTO_INCREMENT,
		counter INT(5),
		PRIMARY KEY (id))";
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		
		$SQLString = "INSERT INTO TABLE $db_table (id, counter)
		VALUES (NULL,0)";
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		
		echo "<p>The table doesn't exist! Please try refreshing the page.</p>";
		
	}
	 else{
/* set a cookie if this is the first visit - the expires
argument is 1 day to prevent visits from implementing each
time the user returns to the page that contains the site 
counter */
if (empty($_COOKIE["visits"])){
	// increment the counter in the database
	// nothing but mysqli works so update it
	$SQLString = ("UPDATE visit_counter " .
	" SET counter = counter + 1 " .
	" WHERE id = 1 ");
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	// query the visit_counter table and assign the counter
	// value to the $visitors variable
	$SQLString = ("SELECT counter " .
	" FROM visit_counter WHERE id = 1");
	
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	if (($row = mysqli_fetch_assoc($QueryResult)) !== FALSE)
		$visitors = $row['counter'];
	else
		$visitors = 1;
	// Set the cookie value
	setcookie("visits", $visitors, time()+(60*60*24));
}
else // Otherwise, assign the cookie value to the $visitor
	// variable
	$visitors = $_COOKIE["visits"];
	}
?>