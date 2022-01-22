<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chapter 3</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>

<body>

<?php 
$Record = "jdoe:  :5486:54;John Doe:/home/jdoe:    ";

$PF = array("login name","optional enc password",
"numerical user ID","numerical group ID",
"user name or comment","user home directory",
"optional user command interpreter");

$FI = 0;
$EF = 0;
$CF = strtok($Record,":;");
while($CF != NULL){
	if($FI < count($PF))
		if(trim($CF)==""){
			echo "<p>The {$PF[$FI]} is <em>N/A</em></p>\n";
		}
	else{
		++$EF;
		echo "<p>Extra field # $EF is <em>$CF</em></p>\n";
	}
	$CF = strtok(":;");
	++$FI;
}
	
?>
</body>
</html>