<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Alphabetize Signs</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<h1>Alphabetize Signs</h1>
<hr />
<form action="AlphabetizeSigns.php" method="POST">
<span style="font-weight:bold">Signs:</span>
	<input type="text" name="signs" /><br />
	<p>The signs will be displayed alphbetically</p>
<input type="submit" name="submit"
	value="Alphabetize Signs" />
<input type="reset" name="reset"
	value="Reset Form" />
</form>
<hr />

<?php
if(isset($_POST['submit'])){
	$Signs = stripslashes($_POST['signs']);
	
	// Replace any ' ' characters
	//		with',' characters
	$SignsArray = explode(",", $Signs);
	sort($SignsArray);
	echo "<pre>";
	print_r($SignsArray);
	echo "</pre>";
}
?>
</body>
</html>