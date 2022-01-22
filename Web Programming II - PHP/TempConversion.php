<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chapter 2, Exercise 2-6</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>

<body>
<table border='1'>
<tr>
<th>Fahrenheit</th>
<th>Celsius</th>
<th>Fahrenheit</th>
<th>Celsius</th>
</tr>
<?php
function tempCalc($fah){
	return round(($fah - 32) * (5 / 9),1);
}

for($degF = 0; $degF <= 100; $degF++){
	//$degC = round(($degF - 32) * (5 / 9),1);
	$degC = tempCalc($degF);
	echo("<tr><td>");
	echo("$degF");
	echo("</td><td>");
	//echo("$degC");
	echo tempCalc($degF);
	echo("</td><td>");	
	++$degF;
	//$degC = round(($degF - 32) * (5 / 9),1);
	$degC = tempCalc($degF);
	echo("$degF");
	echo("</td><td>");
	echo("$degC");
	echo("</td></tr>");
	//echo ("<p>$degF degrees F = $degC degrees C</p>");
}
?>
</table>
</body>
</html>