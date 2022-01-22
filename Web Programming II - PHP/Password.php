<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Password Check</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<?php
//array of 10 passwords
//at least 6 are bad
//5 fail pattern match
//1 fail on length checkdate

//rules
//At least 1 number
//At least 1 lowercase letter
//At least 1 uppercase letter
//No spaces
//at least 1 non-digit or alpha character
//8 - 16 characters

$password = array("tShot!1",
			"tooLongPassword!8", 
			"BKruger@1",
			"bkruger@12",
			"BKRUGER^BOSS1",
			"Bkruger^boss",
			"betty kruger@5",
			"bettykruger1",
			"BK!@#$%81cat",
			"",
			"123bK$#@",
			"&45allOKAY");

			//start with / end with /
			//ldquo and rdquo add quotes
			//i case insensitive
			//^ accept any number
			//* zero or more(Optional)
			//No difference this way or the short way processing
			foreach($password as $word){
				echo "The password &ldquo; ".$word."&rdquo; </br>";
				$valid = true;
				//code executes faster because it doesn't need to proceess twice
				$len = strlen($word);
				if($len < 8 || $len > 16){
				//if(strlen($word) < 8 || strlen($word) > 16){
					echo "$word: is not a valid password. Must contain at least 8-16 characters </br>";
					$valid = false;
				}
				if(preg_match("/\d/", $word) == 0){
					echo "$word: is not a valid password. Must contain at least 1 number </br>";
					$valid = false;
				}
				if(preg_match("/[a-z]/", $word) == 0){
					echo "$word: is not a valid password. Must contain at least 1 lowercase character </br>";
					$valid = false;
				}
				if(preg_match("/[A-Z]/", $word) == 0){
					echo "$word: is not a valid password. Must contain at least 1 uppercase character </br>";
					$valid = false;
				}
				if(preg_match("/[^A-Za-z\d]/", $word) == 0){
					echo "$word: is not a valid password. Must contain at least 1 special character </br>";
					$valid = false;
				}
				if(preg_match("/\s/", $word) == 1){
					echo "$word: is not a valid password. Must not contain any spaces </br>";
					$valid = false;
				}
				if($valid){
					echo "$word: is a valid password. </br>";
				}
					
				
				
				echo "</br>";
/*
$email = array("jsmith123@example.org",
			"john.smith.mail@example.org",
			"john.smith.example.org",
			"john.smith@example",
			"jsmith123@mail.example.org");

			//start with / end with /
			//ldquo and rdquo add quotes
			//i case insensitive
			//^ accept any number
			//* zero or more(Optional)
			foreach($email as $ea){
				echo "The email address &ldquo; ".$ea."&rdquo;";
				if(preg_match("/^(([A-Za-z]+\d*)|".
				"([A-Za-z]+\.[A-Za-z]+))".
				"@((mail\.)?)example\.org$/i",
				$ea) ==1) 
				echo "is a valid email address";
				else 
					echo"is not a valid email address";
				echo "</br>";*/
			}
?>

</body>
</html>