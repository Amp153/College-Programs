<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>THE CHINESE ZODIAC</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
 <?php
 $YoB = "";
 $errorCount = 0;
 $retVal = "";
 displayForm($YoB);
 function displayForm($YoB){
 ?>
 <!-- Still inside brace -->
<h2 style = "text-align:center">Using IF ELSE</h2>
<form action="BirthYear_ifelse.php" method = "post">
<p>Year of Birth: <input type="text" name="YoB"
	value="<?php echo $YoB; ?>" /></p>
	
<p><input type="reset" value ="Clear Form" name ="Reset"/>&nbsp;&nbsp;
<p><input type="submit" name = "Submit" value ="Submit Form" />&nbsp;&nbsp;
 </form>
  <!-- Still inside brace -->
<?php 
 }
function validateInput($data, $fieldName){
	global $errorCount;
	//empty field check
	if(strlen($data) <= 0){
		echo "\"$fieldName\" is a required field. <br /> \n";
		$errorCount++;
		$retVal = "";
	}
	else{
		//have an entry
		$retVal = trim($data);
		$retVal = stripcslashes($retVal);
		
		if(!is_numeric($retVal)){
			echo "\"$fieldName\" must be a number. <br /> \n";
			$errorCount++;
			$retVal = "";
		}
		else{
			//number
			if($retVal <= 0){
				echo "\"$fieldName\" must be greater than 0. <br /> \n";
				$errorCount++;
				$retVal = "";
			}
		}
	}
	return $retVal;
}
$ShowForm = True;
if(isset($_POST['Submit'])){
	$YoB = $_POST['YoB'];
	validateInput($YoB, 'YoB');
	
	if($errorCount == 0){
		$ShowForm = False;
	}
	else {
		$ShowForm = True;
	}
	if($ShowForm){
		//first time or submit with errors
		if($errorCount > 0){
			//page with entry errors
			echo "<p>Please re-enter the form information. </p> \n";
		}
	}
	else {
		//submit with no errors
		$Sign = $YoB % 12;
		
		if($Sign == 4){
			$Animal = "Rat";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rat.PNG />";
		}
		else if($Sign == 5){
			$Animal = "Ox";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Ox.PNG />";}
		else if($Sign == 6){
			$Animal = "Tiger";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Tiger.PNG />";}
		else if($Sign == 7){
			$Animal = "Rabbit";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rabbit.PNG />";}
		else if($Sign == 8){
			$Animal = "Dragon";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Dragon.PNG />";}
		else if($Sign == 9){
			$Animal = "Snake";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Snake.PNG />";}
		else if($Sign == 10){
			$Animal = "Horse";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Horse.PNG />";}
		else if($Sign == 11){
			$Animal = "Sheep";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Sheep.PNG />";}
		else if($Sign == 0){
			$Animal = "Monkey";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Monkey.PNG />";}
		else if($Sign == 1){
			$Animal = "Rooster";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rooster.PNG />";}
		else if($Sign == 2){
			$Animal = "Dog";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Dog.PNG />";}
		else if($Sign == 3){
			$Animal = "Pig";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Pig.PNG />";}
			
			//creates the file
			$CreateFile = fopen("statistics\\$YoB.txt", 'ab');
			fclose($CreateFile);
			
			//gets the contents of the file and adds 1
			$File = fopen("statistics\\$YoB.txt", 'r+');
			$Count = fgets($File) + 1;
			
			//writes to the file
			file_put_contents("statistics\\$YoB.txt", $Count);
			fclose($File);
			echo "You are person $Count to enter $YoB\n";		
	}
}
?>
</body>
</html>