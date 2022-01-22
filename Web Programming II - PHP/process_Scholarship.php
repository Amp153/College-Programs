<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Scholarship</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<?php
$errorCount = 0;
function displayRequired($fieldName){
	echo "The field \"$fieldName\" is required. <br />\n";
}
function validateInput($data, $fieldName){
	global $errorCount;
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
$firstName = validateInput($_POST['fName'], "First Name");
$lastName = validateInput($_POST['lName'], "Last Name");

if ($errorCount > 0)
	echo "Please use the \"Back\" button to re-enter the data.<br />";
else

//Helps prevent nevarious users
//$firstName = stripslashes($_POST['fName']);

//Very basic
//$lastName = $_POST['lName'];

echo "Thank you for filling out the scholarship form, ".$firstName." ".$lastName.".";
?>

</body>
</html>