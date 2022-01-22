<?php 
//use the existing session auto global
session_start();
$Session = session_id();
//store the entered data from the first page in the session
if (!empty($_POST['javascript']))
	$_SESSION['javascript'] = TRUE;
else
	$_SESSION['javascript'] = FALSE;
//I didn't bother fixing the rest
if (!empty($_POST['php']))
	$_SESSION['php'] = $_POST['php'];
if (!empty($_POST['mysql']))
	$_SESSION['mysql'] = $_POST['mysql'];
if (!empty($_POST['apache']))
	$_SESSION['apache'] = $_POST['apache'];


?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Conference Registration - Part D</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Professional Conference</h1>
<h2>Seminar Confirmation</h2>

<form action = "FifthPage.php?<?php echo $Session ?>" method = "POST">

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
<form action = "ThirdPage.php?<?php echo $Session ?>" method = "POST">
<input type="submit" value="Previous" /></p>
</form>

</body>
</html>