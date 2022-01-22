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
<h2 style = "text-align:center">Using SWITCH</h2>
<form action="BirthYear_switch.php" method = "post">
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
$ShowForm = TRUE;
if(isset($_POST['Submit'])){
	$YoB = $_POST['YoB'];
	validateInput($YoB, 'YoB');
	
	if($errorCount == 0){
		$ShowForm = FALSE;
	}
	else {
		$ShowForm = TRUE;
	}
	if($ShowForm){
		//first time or submit with errors
		if($errorCount > 0){
			//page with entry errors
			echo "<p>Please re-enter the form information below. </p> \n";
			//$YoB = "";
			//displayForm($YoB);
		}
	}
	else {
		
		//submit with no errors
		$Animal = "";		
				
		$Sign = $YoB % 12;
		switch($Sign){
		case '4':
			$Animal = "Rat";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rat.PNG />";
			break;
		case '5':
			$Animal = "Ox";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Ox.PNG />";
			break;
		case '6':
			$Animal = "Tiger";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Tiger.PNG />";
			break;
		case '7':
			$Animal = "Rabbit";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rabbit.PNG />";
			break;
		case '8':
			$Animal = "Dragon";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Dragon.PNG />";
			break;
		case '9':
			$Animal = "Snake";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Snake.PNG />";
			break;
		case '10':
			$Animal = "Horse";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Horse.PNG />";
			break;
		case '11':
			$Animal = "Goat";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Goat.PNG />";
			break;
		case '0':
			$Animal = "Monkey";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Monkey.PNG />";
			break;
		case '1':
			$Animal = "Rooster";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Rooster.PNG />";
			break;
		case '2':
			$Animal = "Dog";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Dog.PNG />";
			break;
		case '3':
			$Animal = "Pig";
			echo "You were born under the sign of $Animal<br/>\n";
			echo "<img src=Images/Pig.PNG />";
			break;
		}
		//Adds the years for a sign and a president that shares that sign
		$AnimalSigns = array(
		"Rat" => array("StartDate" => "1900", "EndDate" => "2020",
		"President" => "George Washington"),
		"Ox" => array("StartDate" => "1901", "EndDate" => "2021",
		"President" => "Barack Obama"),
		"Tiger" => array("StartDate" => "1902", "EndDate" => "2022",
		"President" => "Dwight Eisenhower"),
		"Rabbit" => array("StartDate" => "1903", "EndDate" => "2023",
		"President" => "John Adams"),
		"Dragon" => array("StartDate" => "1904", "EndDate" => "2024",
		"President" => "Abraham Lincoln"),
		"Snake" => array("StartDate" => "1905", "EndDate" => "2025",
		"President" => "John Kennedy"),
		"Horse" => array("StartDate" => "1906", "EndDate" => "2026",
		"President" => "Theodore Roosevelt"),
		"Goat" => array("StartDate" => "1907", "EndDate" => "2027",
		"President" => "James Madison"),
		"Monkey" => array("StartDate" => "1908", "EndDate" => "2028",
		"President" => "Harry Truman"),
		"Rooster" => array("StartDate" => "1909", "EndDate" => "2029",
		"President" => "Grover Cleveland"),
		"Dog" => array("StartDate" => "1910", "EndDate" => "2030",
		"President" => "George Walker Bush"),
		"Pig" => array("StartDate" => "1911", "EndDate" => "2031",
		"President" => "Ronald Reagan"));
		
		//Modified because original variable is different
		$ChosenSign = $Animal;
		
		$SignMessage = "If your Chinese zodiac sign is the $ChosenSign,
		you share a zodiac sign with President ".
		$AnimalSigns[$ChosenSign]["President"].
		".";
		$SignMessage .="Years of the $ChosenSign
		include ";
		for($i = $AnimalSigns[$ChosenSign]["StartDate"];
		$i < $AnimalSigns[$ChosenSign]["EndDate"];
		$i += 12)
		$SignMessage .= $i.",";
		$SignMessage .= "and ".
		$AnimalSigns[$ChosenSign]["EndDate"].".";
		
		echo "<p>$SignMessage</p>";
		
		
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