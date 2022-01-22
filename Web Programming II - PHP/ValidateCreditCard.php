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
<h1>Validate Credit Card</h1>

<?php 

$CC = array("","8910-1234-5678-6543","000-9123-4567-0123");

foreach($CC as $CN){
	if(empty($CN))
		echo "<p>This credit card number is invalid: empty string</p>";
	else{
		$CCN = $CN;
		$CCN = str_replace("-","",$CCN);
		$CCN = str_replace(" ","",$CCN);
		if(strlen($CCN) != 16){
			echo "<p>This credit card number is invalid:" 
		."must have 16 digits</p>";
		}
		else if(!is_numeric($CCN)){
			echo "<p>This credit card number is invalid:" 
		."contains non-numeric characters</p>";
		}
		else
			echo "<p>This credit card number $CCN is valid</p>";
	}
}
	
?>
</body>
</html>