<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Guest</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
$errorCount = 0;
$BowlerArray = array();
$creates = False;

//validate data
if(empty($_POST['first_name'])){
	//no first name entered
$errorCount++;
echo "<p>You must enter a first name</p>";
} else{
	//have a first name
	$BowlerArray[0] = $_POST['first_name'];
}
if(empty($_POST['last_name'])){
	//no last name entered
$errorCount++;
echo "<p>You must enter a last name</p>";
} else{
	//have a last name
	$BowlerArray[1] = $_POST['last_name'];
}
if(empty($_POST['age'])){
	//no age entered
$errorCount++;
echo "<p>You must enter your age</p>";
} else if(($_POST['age']) <= 18){
	$errorCount++;
	echo "<p>You must be over the age of 18 to enter this tournament</p>";
} else{
	//have an age
	$BowlerArray[2] = $_POST['age'];
}
if(empty($_POST['average'])){
	//no average entered
$errorCount++;
echo "<p>You must enter a average with a valid score</p>";
} else if(($_POST['average']) <= 0){
	$errorCount++;
	echo "<p>You must have an average to enter this tournament</p>";
} else{
	//have an average
	$BowlerArray[3] = $_POST['average'];
}


if($errorCount == 0){
	
	//file processing
	//a = open a file to write to and place at end of file
	
	//b = forces file to open in binary mode
	$BowlerRegis = fopen("Projects\\BowlerRegistration.txt", "ab");
	if($BowlerRegis == false)
		echo "File issue";
	else{
		//echo "Free to proceed";
	
	if(is_writeable("Projects\\BowlerRegistration.txt")){
		if(fwrite($BowlerRegis, $BowlerArray[0]. ", ".$BowlerArray[1].
		", ".$BowlerArray[2]. ", ".$BowlerArray[3]. "\r\n")
			=== False)
			echo "<p>Cannot add your information to the Bowler Registration. </p>";
			else
				echo "<p>Thank you for registering.</p>";
	}
	else
		echo "<p>Cannot write to the file. </p>";
		fclose($BowlerRegis);
	}
}
else
	echo "<p>Cannot create a new registration file based on incomplete data</p>";
	
	
	
	



?>
<p>return to the <a href="BowlerReg.html">Bowler Registration </a></p>
</body>
</html>