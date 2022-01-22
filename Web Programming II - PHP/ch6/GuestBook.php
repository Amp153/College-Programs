<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>GuestBook</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
//teacher messed up the viewer
if(file_exists('GuestBook.txt') &&
	filesize('GuestBook.txt') != 0){
		$GuestBookArray = file("GuestBook.txt");
		for ($x = 0; $x < count($GuestBookArray); $x += 2){
		$Names[$GuestBookArray[$x] => $GuestBookArray[$x+1]];
	}
	}
	else {
		$GuestBookArray = array();
		$Names = array();
	}
}

$ValidData = TRUE;
$Process = "none";

if(isset($_POST['enter'])){
	if(empty($_POST['name'])){
		echo "You need to enter your name \n";
		$ValidData = false;
	}
	else if (empty($_POST['email'])){
		echo "You need to enter your email \n";
		$ValidData = false;
	}
	else{
		$ValidData = TRUE;
		$Process = "entry";
	}
}
if(isset($_POST['clear'])){
	unlink("GuestBook.txt");
	if(file_exists('GuestBook.txt') &&
	filesize('GuestBook.txt') != 0){
		$GuestBookArray = file("GuestBook.txt");
	}
	else {
		$GuestBookArray = array();
	}
}
if($ValidData){
	?>
	<h1>GuestBook</h1>
<hr />
<form action="GuestBook.php" method="POST">
<p>Email:<input type="text" name="email" /n></p>
<p>Name:<input type="text" name="name" /n></p>
<br />
<input type="submit" name="view"
	value="View all Guests" />
<input type="submit" name="enter"
	value="Sign the GuestBook" />
<input type="reset" name="reset"
	value="Reset Form" />
<input type="submit" name="clear"
	value="Delete Form" />
</form>
<hr />
<?php
}

if ($Process == "entry"){
	if(!array_key_exists($_POST['name'],$Names)){
		//$GustBookArray[] = $_POST['name'];
		$Names[$_POST['name']][$_POST['email']];
		file_put_contents('GuestBook.txt',
		$_POST['name']."\r\n".$_POST['email']."\r\n",
		FILE_APPEND);
		
	}
 else{
	echo "The user name has been used \n";
	}
}
else {
	if (isset($_POST['view'])){
		ksort($Names);
		?>
		<textarea cols="45" rows ="20" name ="guests"><?php
		//echo implode("\r\n", $GuestBookArray);
		foreach($Name as $n){
			echo "<p>$n</p>";
		}
		?></textarea>
		<?php
		
	}
}

?>

</body>
</html>