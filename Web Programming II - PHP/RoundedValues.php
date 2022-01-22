<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chapter 1 Exercise 1-5</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
//Change this variable to test the script
$Value = 125.6845;

//Error handleing
$CheckValue = (is_numeric($Value)? $Value: $Value = "Not a Number");
echo "The variable is $CheckValue </br>";

//Does all of the rounding
$ValueRoundUp = (is_int($CheckValue)? $CheckValue: ceil($CheckValue));
$ValueRoundDown = (is_int($CheckValue)? $CheckValue: floor($CheckValue));
$ValueRounded = (is_int($CheckValue)? $CheckValue: round($CheckValue));

//Changes strings from 0 to Not Available
$ValueRoundUp = (($CheckValue = "Not a Number")&&($ValueRoundUp == 0)? $ValueRoundUp = "N/A": $ValueRoundUp);
$ValueRoundDown = (($CheckValue = "Not a Number")&&($ValueRoundDown == 0)? $ValueRoundDown = "N/A": $ValueRoundDown);
$ValueRounded = (($CheckValue = "Not a Number")&&($ValueRounded == 0)? $ValueRounded = "N/A": $ValueRounded);

//Checks for 0 and corrects variables
$ValueRoundUp = (($Value == "0")? (int)$Value: $ValueRoundUp);
$ValueRoundDown = (($Value == "0")? (int)$Value: $ValueRoundDown);
$ValueRounded = (($Value == "0")? (int)$Value: $ValueRounded);

//Displays the original and the modified values
echo "$Value rounded up is $ValueRoundUp </br>";
echo "$Value rounded down is $ValueRoundDown </br>";
echo "$Value rounded to the nearest whole number is $ValueRounded";

?>

</body>
</html>