<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Bug List</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<h2>Bug List</h2>

<table border="1">
<tr>
<th><strong>Product Name</strong></th>
<th><strong>Product Version</strong></th>
<th><strong>Type of Hardware</strong></th>
<th><strong>Operating System</strong></th>
<th><strong>Frequency</strong></th>
<th><strong>Proposed Solution</strong></th>
</tr>
<?php

//reads the files
$DirList = scandir("projects");
foreach($DirList as $File){
	//for debuging
	//echo "$File";
	//preg_match("/^Bug\.\d+\d*\.txt$/i", $File))
	if(preg_match("/^Bug\.\d+\.\d*\.txt$/i", $File)){
		//one of our files
		$BugFileContents = file('projects\\'.$File);
		$BugFileContents++;
		
		echo "<tr>";
		echo "<td> $BugFileContents[0] </td>";
		echo "<td> $BugFileContents[1] </td>";
		echo "<td> $BugFileContents[2] </td>";
		echo "<td> $BugFileContents[3] </td>";
		echo "<td> $BugFileContents[4] </td>";
		echo "<td> $BugFileContents[5] </td>";
		echo "</tr>";
	}
}
if($BugFileContents == 0){
	echo "<tr><td colspan ='7'> There are no reports</tr>";
}
?>

</table>

<br />
</br>

<!--writes to the files-->
<h3>New Bug Report</h3>
<form action ="CreateReport.php" method="post">
<table border="1">
<tr><td colspan="2">Bug Description:</td></tr>
<tr><td colspan="2"><textArea cols="60" rows="3" name="Description">
</textArea></td></tr>
<tr><td>(*)Product Name</td>
	<td><input type="text" name="ProductName" /></td></tr>
<tr><td>(*)Product Version</td>
	<td><input type="text" name="ProductVersion" /></td></tr>
<tr><td>Type of Hardware</td>
	<td><input type="text" name="HardwareType" /></td></tr>
<tr><td>Operating System</td>
	<td><input type="text" name="OS" /></td></tr>
<tr><td>Frequency of Occurrence</td>
	<td><input type="text" name="Freq" /></td></tr>
<tr><td>Proposed Solution</td>
	<td><input type="text" name="Solution" /></td></tr>

</table>
<input type="submit" name="create" value="Create New Report" />
</form>
Fields marked with an asterisk(*) are required
</body>
</html>