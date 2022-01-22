<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Change Calculator</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Calculate Change</h1>
<?php
$AO = 0;
$AP = 0;

//Check for post back
if (isset($_POST["submit"])){
	//check to ensure data is entered
	// and that it's valid
	$errors = 0;
	if(isset($_POST["owed"])){
		if (is_numeric($_POST["owed"])){
			if(($_POST["owed"] >= .01) && ($_POST["owed"] <= 100)){
				//we list it in change.php so I don't know why it's nessary
				$AO = trim(sprintf("%4.2f",$_POST["owed"]));
				//$AO = 0; clear form gives back the previous
			}
			else{
				echo "<p>Amount owed between .01 and 100</p>";
				$errors++;
			}
		}
		else{
				echo "<p>Must be a number</p>";
				$errors++;
			}
	}
	else{
				echo "<p>Enter the amount owed</p>";
				$errors++;
			}
	if(isset($_POST["paid"])){
		if (is_numeric($_POST["paid"])){
			if(($_POST["paid"] >= .01) && ($_POST["paid"] <= 100)){
				//we list it in change.php so I don't know why it's nessary
				$AP = trim(sprintf("%4.2f",$_POST["paid"])); 
				//$AP = 0; clear form gives back the previous
			}
			else{
				echo "<p>Amount paid between .01 and 100</p>";
				$errors++;
			}
		}
		else{
				echo "<p>Must be a number</p>";
				$errors++;
			}
	}
	else{
				echo "<p>Enter the amount paid</p>";
				$errors++;
			}
			
	if ($errors ==0){
		//Assume that all is ok
		require_once("Change.php");
		$Change = new Change();
		$Change->SetAmountOwed($_POST["owed"]);
		$Change->SetAmountPaid($_POST["paid"]);
		echo "<h3>Calculate Results </h3>";
		$Change->ShowChange();
		echo "<br />";
		echo "<hr />";
		echo "<br />";
	}
	

}
?>

<h2>Enter a transaction</h2>
<form action="CC.php" method = "POST">
<table border="0">
<tr><td align="right">Amount Owed: </td>
<td align="left">$<input type="text" size="6" name="owed"
value = "<?php echo $AO; ?>" /></td></tr>

<tr><td align="right">Amount Paid: </td>
<td align="left">$<input type="text" size="6" name="paid"
value = "<?php echo $AP; ?>" /></td></tr>

<tr><td colspan="2" align="center">

<input type="reset" size="6" name="reset"
value = "Clear Form" />&nbsp;
<input type="submit" size="6" name="submit"
value = "Calculate Change" />&nbsp;
</td></tr>
</table>
</form>
</body>
</html>