<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chapter 1, Exercise 6</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
$Value = "28.86";
/*$CheckValue = (is_numeric($Value)? $Value: (int)($Value));
echo "The variable is $CheckValue </br>";

$IntValue = (is_int($CheckValue)? $CheckValue: round($CheckValue));
$IntValue = $IntValue % 2;
echo "$Value Even number? ", ($IntValue == 0? "True": "False");*/

if(is_numeric($Value)) {
	//echo "Got a number";
	$V = $Value;
	if(is_float(double)($Value)){
	$V = round($Value);
	}
	$EvenOdd = $V % 2;
	echo "$Value Even number? ", ($EvenOdd == 0? "True": "False");
}
else {
	echo "No number";
}
?>

</body>
</html>