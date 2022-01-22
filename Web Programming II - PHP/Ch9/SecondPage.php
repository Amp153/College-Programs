<?php 
//use the existing session auto global
session_start();
$Session = session_id();
//store the entered data from the first page in the session
if (!empty($_POST['firstname']))
	$_SESSION['firstname'] = $_POST['firstname'];
if (!empty($_POST['lastname']))
	$_SESSION['lastname'] = $_POST['lastname'];
if (!empty($_POST['address']))
	$_SESSION['address'] = $_POST['address'];
if (!empty($_POST['city']))
	$_SESSION['city'] = $_POST['city'];
if (!empty($_POST['state']))
	$_SESSION['state'] = $_POST['state'];
if (!empty($_POST['zip']))
	$_SESSION['zip'] = $_POST['zip'];
if (!empty($_POST['email']))
	$_SESSION['email'] = $_POST['email'];
if (!empty($_POST['telephone']))
	$_SESSION['telephone'] = $_POST['telephone'];

$Company = "";
$Address = "";
$City = "";
$State = "";
$Zip = "";
$Telephone = "";

//check if it exists in the session
if(isset($_SESSION['company']))
	$Company = $_SESSION['company'];
if(isset($_SESSION['co_address']))
	$Address = $_SESSION['co_address'];
if(isset($_SESSION['co_city']))
	$City = $_SESSION['co_city'];
if(isset($_SESSION['co_state']))
	$State = $_SESSION['co_state'];
if(isset($_SESSION['co_zip']))
	$Zip = $_SESSION['co_zip'];
if(isset($_SESSION['co_telephone']))
	$Telephone = $_SESSION['co_telephone'];
?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Conference Registration - Part 2</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Professional Conference</h1>
<h2>Company Information</h2>

<form action = "ThirdPage.php?<?php echo $Session ?>" method = "POST">
<p>Company Name <input type="text" name="company"
	value= "<?php echo $Company; ?>" /> &nbsp; </p>
<p>Address <input type="text" name="co_address"
	value= "<?php echo $Address; ?>" /> &nbsp; </p>
<p>City <input type="text" name="co_city"
	value= "<?php echo $City; ?>" /> &nbsp; </p>
<p>State <input type="text" name="co_state"
	value= "<?php echo $State; ?>" /> &nbsp; </p>
<p>Zip <input type="text" name="co_zip"
	value= "<?php echo $Zip; ?>" /> &nbsp; </p>
<p>Telephone <input type="text" name="co_telephone"
	value= "<?php echo $Telephone; ?>" /> &nbsp; </p>
<p><input type="submit" value="Next" />
</form>
<form action = "FirstPage.php?<?php echo $Session ?>" method = "POST">
<!--<p><input type="hidden" name="PHPSESSID" 
	value="<?php echo session_id(); ?>" /></p> -->
<input type="submit" value="Previous" /></p>
</form>

</body>
</html>