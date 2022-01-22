<?php 
//set up for the session
session_start();
$Session = session_id();
$FirstName = "";
$LastName = "";
$Address = "";
$City = "";
$State = "";
$Zip = "";
$Email = "";
$Telephone = "";
//echo $Session;

//check if it exists in the session
if(isset($_SESSION['firstname']))
	$FirstName = $_SESSION['firstname'];
if(isset($_SESSION['lastname']))
	$LastName = $_SESSION['lastname'];
if(isset($_SESSION['address']))
	$Address = $_SESSION['address'];
if(isset($_SESSION['city']))
	$City = $_SESSION['city'];
if(isset($_SESSION['state']))
	$State = $_SESSION['state'];
if(isset($_SESSION['zip']))
	$Zip = $_SESSION['zip'];
if(isset($_SESSION['email']))
	$Email = $_SESSION['email'];
if(isset($_SESSION['telephone']))
	$Telephone = $_SESSION['telephone'];
?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Conference Registration</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Professional Conference</h1>
<h2>Personal Information</h2>

<form action = "SecondPage.php?<?php echo $Session ?>" method = "POST">
<p>First Name <input type="text" name="firstname" 
	value= "<?php echo $FirstName; ?>" /> &nbsp; </p>
<p>Last Name <input type="text" name="lastname"
	value= "<?php echo $LastName; ?>" /> &nbsp; </p>
<p>Address <input type="text" name="address"
	value= "<?php echo $Address; ?>" /> &nbsp; </p>
<p>City <input type="text" name="city"
	value= "<?php echo $City; ?>" /> &nbsp; </p>
<p>State <input type="text" name="state"
	value= "<?php echo $State; ?>" /> &nbsp; </p>
<p>Zip <input type="text" name="zip"
	value= "<?php echo $Zip; ?>" /> &nbsp; </p>
<p>Email <input type="text" name="email"
	value= "<?php echo $Email; ?>" /> &nbsp; </p>
<p>Telephone <input type="text" name="telephone"
	value= "<?php echo $Telephone; ?>" /> &nbsp; </p>
<!--<p><input type="hidden" name="PHPSESSID" 
	value="<?php echo session_id(); ?>" /></p> -->
<p><input type="submit" value="Next" /></p>
</form>

<form action = "SessionDestroy.php" method = "POST">
<p><input type="submit" value="Reset Session" /></p>
</form>

</body>
</html>