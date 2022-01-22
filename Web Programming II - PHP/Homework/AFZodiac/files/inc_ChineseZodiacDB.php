<?php
$db_name = "chinese_zodiac";
$ErrorMsgs = array();

//assign the connection and selected database to a variable
//Different mysql for different configurations
// school computer
	//$DBConnect = @new mysqli("localhost:3308", "root", "", $db_name);
// java
	//$DBConnect = @new mysqli("localhost", "root", "password", $db_name);
// home computer
	$DBConnect = @new mysqli("localhost", "root", "", $db_name);

	if($DBConnect->connect_error)
		$ErrorMsgs[] = "The database server is not available. " .
		"Connect Error is " . $DBConnect->connect_errno . " " .
		$DBConnect->connect_error. ".";
?>

</body>
</html>