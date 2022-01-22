<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Paycheck</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<?php
$errorCount = 0;
function displayRequired($fieldName){
	echo "The field \"$fieldName\" is required. <br /> \n";
}
function numericRequired($fieldName){
	echo "The field \"$fieldName\" needs to be a number. <br /> \n";
}
function greaterThanZeroRequired($fieldName){
	echo "The field \"$fieldName\" needs to be greater than zero. <br /> \n";
}
function validateInput($data, $fieldName){
	global $errorCount;
	
	//checks if fields are greater than zero
	if($data <= 0){
		greaterThanZeroRequired($fieldName);
		++$errorCount;
		$retval = "";
	}
	
	//checks if fields are numbers
	if(!(is_numeric($data))){
		numericRequired($fieldName);
		++$errorCount;
		$retval = "";
	}
	
	//checks if fields are entered
	if (empty($data)){
		displayRequired($fieldName);
		++$errorCount;
		$retval = "";
	}
	else{
		$retval = trim($data);
		$retval = stripslashes($retval);
	}
	return $retval;
}
$hoursWorked = validateInput($_POST['hWorked'], "Hours worked");
$hourlyWage = validateInput($_POST['hWage'], "Hourly wage");
$overTime = 0;
$grossPay = 0;

//Calculate total payment includeing overtime
if($hoursWorked > 40){
	$overTime = ($hoursWorked - 40) * ($hourlyWage * 0.5);
	$grossPay = ($hoursWorked * $hourlyWage) + $overTime;
}
else
	$grossPay = $hoursWorked * $hourlyWage;

//What the user sees
if ($errorCount != 0)
	echo "Please use the \"Back\" button to re-enter the data.<br />";
else
	
echo "The amount of hours worked is ".$hoursWorked."\n The hourly wage is ".$hourlyWage.
	"\n The gross pay is ".$grossPay.".";
?>

</body>
</html>