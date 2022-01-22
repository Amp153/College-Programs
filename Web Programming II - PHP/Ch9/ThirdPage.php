<?php 
//use the existing session auto global
session_start();
$Session = session_id();
//store the entered data from the first page in the session
if (!empty($_POST['company']))
	$_SESSION['company'] = $_POST['company'];
if (!empty($_POST['co_address']))
	$_SESSION['co_address'] = $_POST['co_address'];
if (!empty($_POST['co_city']))
	$_SESSION['co_city'] = $_POST['co_city'];
if (!empty($_POST['co_state']))
	$_SESSION['co_state'] = $_POST['co_state'];
if (!empty($_POST['co_zip']))
	$_SESSION['co_zip'] = $_POST['co_zip'];
if (!empty($_POST['co_telephone']))
	$_SESSION['co_telephone'] = $_POST['co_telephone'];

$Javascript = "";
$Php = "";
$Mysql = "";
$Apache = "";

//check if it exists in the session
if(isset($_SESSION['javascript']))
	$Javascript = $_SESSION['javascript'];
if(isset($_SESSION['php']))
	$Php = $_SESSION['php'];
if(isset($_SESSION['mysql']))
	$Mysql = $_SESSION['mysql'];
if(isset($_SESSION['apache']))
	$Apache = $_SESSION['apache'];
?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Conference Registration - Part C</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Professional Conference</h1>
<h2>Seminar Selection</h2>

<form action = "FourthPage.php?<?php echo $Session ?>" method = "POST">

<p><input type="checkbox" name="javascript"
	<?php if($Javascript) echo "checked='checked'" ?> />Javascript <br /></p>
<p><input type="checkbox" name="php"
	<?php if($Php) echo "checked='checked'" ?> />PHP <br /></p>
<p><input type="checkbox" name="mysql"
	<?php  if($Mysql) echo "checked='checked'" ?> />Mysql <br /></p>
<p><input type="checkbox" name="apache"
	<?php if($Apache) echo "checked='checked'" ?> />Apache <br /></p>

<p><input type="submit" value="Next" />
</form>
<form action = "SecondPage.php?<?php echo $Session ?>" method = "POST">
<input type="submit" value="Previous" /></p>
</form>

</body>
</html>