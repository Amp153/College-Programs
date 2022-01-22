<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Two Trains</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
 <?php
 $SpeedA = "";
 $SpeedB = "";
 $Distance = "";
 $errorCount = 0;
 $retVal = "";
 function displayForm($SpeedA, $SpeedB, $Distance){
 ?>
 <!-- Still inside brace -->
<h2 style = "text-align:center">Two Trains</h2>
<form action="TwoTrains.php" method = "post">
<p>Speed of Train A: <input type="text" name="SpeedA"
	value="<?php echo $SpeedA; ?>" />mph</p>
<p>Speed of Train B: <input type="text" name="SpeedB"
	value="<?php echo $SpeedB; ?>" />mph</p>
<p>Distance between the 2 trains: <input type="text" name="Distance"
	value="<?php echo $Distance; ?>" />miles</p>
	
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
	$SpeedA = $_POST['SpeedA'];
	validateInput($SpeedA, 'SpeedA');
	$SpeedB = $_POST['SpeedB'];
	validateInput($SpeedB, 'SpeedB');
	$Distance = $_POST['Distance'];
	validateInput($Distance, 'Distance');
	
	if(errorCount == 0){
		$ShowForm = False;
	}
	else {
		$ShowForm = True;
	}
	if($ShowForm){
		//first time or submit with errors
		if($errorCount > 0){
			//page with entry errors
			echo "<p>Please re-enter the form information below. </p> \n";
			//$SpeedA = "";
			//$SpeedB = "";
			//$Distance = "";
			displayForm($SpeedA, $SpeedB, $Distance);
		}
	}
	else {
		//submit with no errors
		//calculate the time
		$DistanceA = round((($SpeedA/$SpeedB)*$Distance)/(1+($SpeedA/$SpeedB)),2);
		$DistanceB = round($Distance - $DistanceA,2);
		$TimeA = round($DistanceA/$SpeedA,2);
		$TimeB = round($DistanceB/$SpeedB,2);
		
		echo "Train A traveling $DistanceA miles in $TimeA hours at $SpeedA mph <br/>\n";
		echo "Train B traveling $DistanceB miles in $TimeB hours at $SpeedB mph <br/>\n";
		echo "The sum of the two distances is".($DistanceA + $DistanceB)."<br/>\n";
	}
}
?>
 

</body>
</html>