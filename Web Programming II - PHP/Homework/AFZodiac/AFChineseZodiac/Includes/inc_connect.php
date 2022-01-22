<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Connect to the database</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
$db_name = "chinese_zodiac";
//assign the connection and selected database to a variable
//Different mysql for different configurations
$DBConnect = @mysqli_connect("localhost:3308", "root", "");
if ($DBConnect === FALSE){
	$DBConnect = @mysqli_connect("localhost", "root", "password");
}
if ($DBConnect === FALSE){
	$DBConnect = @mysqli_connect("localhost", "root", "");
}

	
if ($DBConnect === FALSE){
	echo "<p>Unable to connect to the database server.</p>".
	"<p>Error code ".mysqli_connect_errno()
	. ": " . mysqli_connect_error() . "</p>";
	}
	
else{
	//select the database
	$db = mysqli_select_db($DBConnect, $db_name);
	
	//if it doesn't exist
	if ($db === NULL){
		$SQLString = "CREATE DATABASE chinese_zodiac";
		$QueryResult = @mysqli_query($DBConnect, $SQLString);
		$db = mysqli_select_db($DBConnect, $db_name);
	}
	if ($db === NULL) {
		echo "<p>Unable to query the database server.</p>".
		"<p>Error code ".mysqli_connect_errno()
		. ": " . mysqli_connect_error() . "</p>";
		mysqli_close($DBConnect);
		$DBConnect = FALSE;
	}
}
?>

</body>
</html>