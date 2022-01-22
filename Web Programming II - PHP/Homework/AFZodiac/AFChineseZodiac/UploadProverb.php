<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>UPLOAD PROVERB</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
 <?php
 $Proverb = "";
 $errorCount = 0;
 $retVal = "";
 displayForm($Proverb);
 function displayForm($Proverb){
 ?>
 <!-- Still inside brace -->
<h2 style = "text-align:center">Using PROVERB</h2>
<form action="UploadProverb.php" method = "post">
<p>Upload new Proverb: <input type="text" name="Proverb"
	value="<?php echo $Proverb; ?>" /></p>
	
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
		
		if(is_numeric($retVal)){
			echo "\"$fieldName\" can't be a number. <br /> \n";
			$errorCount++;
			$retVal = "";
		}
		
	}
	return $retVal;
}
$ShowForm = True;
if(isset($_POST['Submit'])){
	$Proverb = $_POST['Proverb'];
	validateInput($Proverb, 'Proverb');
	
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
			//$Proverb = "";
			//displayForm($Proverb);
		}
		
	}
	else {
		
		//submit with no errors
		
		//echo "$Proverb was submitted successfully\n";
		
			//creates the file if it's not available
			//$CreateFile = fopen("proverbs.txt", 'ab');
			//fclose($CreateFile);
		
			//writes to the file
			$File = fopen("proverbs.txt", 'ab');
			//$Count = fgets($File);
			fwrite($File, $Proverb."\r\n");
	//file_put_contents("statistics\\$Proverb.txt", $Count);
	
	fclose($File);
		echo "$Proverb was submitted successfully\n";
		
		
	}
}
?>
 

</body>
</html>