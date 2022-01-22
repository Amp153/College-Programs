<p><?php include("Includes/inc_connect.php");
			
if($DBConnect === FALSE){
	echo "<p>Cannot find the database!</p>";
}
else{
	//database exists and is connected
	mysqli_select_db($DBConnect,$db_name);
		
	//check for the table
	$db_table = "randomproverb";
	$SQLString = "SHOW TABLES LIKE '$db_table'";
	$QueryResult = @mysqli_query($DBConnect, $SQLString);
	
	if($QueryResult === NULL){
		echo "<p>Table issue</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	
	if(mysqli_num_rows($QueryResult) == 0){
		//table doesn't exist
		echo "<p>There are no entries in the $db_table table!</p>";
	}
	else {
		//table exists
		//Display the proverb		
		
		//Find the number of rows
		$SQLString = "SELECT * FROM $db_table";
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		$ProverbCount = mysqli_num_rows($QueryResult);
		
		echo "<p>A randomly displayed chinese proverb retrieved from a table.</p>";
		
		//Create a random number
		$RanNum = rand(1, $ProverbCount);

		//Selects only one row
		$SQLString = "SELECT * FROM $db_table WHERE proverb_number =". $RanNum;
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		
		//Displays the proverb
		if ($Row = mysqli_fetch_assoc($QueryResult)){
			$ProverbArray = $Row['proverb'];
			echo "<p>$ProverbArray</p>";
		}
	
		//Update the display_count
		$SQLString = "UPDATE randomproverb SET display_count ".
			" = display_count + 1 WHERE proverb_number = ".
			$RanNum;
		
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
	}
	//Check if query was successfull
	if(!isset($QueryResult)){
		echo "<p>Query was unable to execute</p>".
		"<p>Error code: ".mysqli_connect_errno($DBConnect).
		mysqli_connect_error($DBConnect)."</p>";
	}
	@mysqli_free_result($QueryResult);
	mysqli_close($DBConnect);
}
?></p>

<p>Total visitors to this site: <?php echo $visitors; ?> </p>	
	
<p><?php 

	$DragonArray = array('Images/Dragon1.png',
	'Images/Dragon2.png','Images/Dragon3.png',
	'Images/Dragon4.png','Images/Dragon5.png');
	
	shuffle($DragonArray);
	echo '<img src='.$DragonArray[0].' />';

?></p>
<!-- Copyright and Date -->
<p>&copy; <?php echo date("Y") ?></p>