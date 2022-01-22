<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Create Report</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
$errorCount = 0;
$BugReport = array();
$creates = False;

//validate data
if(empty($_POST['ProductName'])){
	//no product name entered
$errorCount++;
echo "<p>You must enter a product name</p>";
}
else{
	//have a product name
	$BugReport[0] = $_POST['ProductName']."\r\n";
}
if(empty($_POST['ProductVersion'])){
	//no product ver entered
$errorCount++;
echo "<p>You must enter a product version</p>";
}
else{
	//have a product name
	$BugReport[1] = $_POST['ProductVersion']."\r\n";
}
if(empty($_POST['HardwareType'])){
	$BugReport[2] = "\r\n";
}
else{
	$BugReport[2] = $_POST['HardwareType']."\r\n";
}
if(empty($_POST['OS'])){
	$BugReport[3] = "\r\n";
}
else{
	$BugReport[3] = $_POST['OS']."\r\n";
}
if(empty($_POST['Freq'])){
	$BugReport[4] = "\r\n";
}
else{
	$BugReport[4] = $_POST['Freq']."\r\n";
}
if(empty($_POST['Solution'])){
	$BugReport[5] = "\r\n";
}
else{
	$BugReport[5] = $_POST['Solution']."\r\n";
}

if($errorCount == 0){
	$BugFile = "projects\\Bug.".microtime(TRUE).".txt";
	file_put_contents($BugFile, $BugReport);
}
else
	echo "<p>Cannot create a report file base on incomplete data</p>";
	
?>
<p>return to the <a href="BugList.php">Bug List </a></p>

</body>
</html>