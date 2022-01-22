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


<?php

//Adds the picture locations to the array
$Signs = array("Rat.PNG" =>"A Rat","Ox.PNG" =>"A Ox","Tiger.PNG" =>"A Tiger",
"Rabbit.PNG" =>"A Rabbit","Dragon.PNG" =>"A Dragon","Snake.PNG" =>"A Snake",
"Horse.PNG" =>"A Horse","Sheep.PNG" =>"A Sheep","Monkey.PNG" =>"A Monkey",
"Rooster.PNG" =>"A Rooster","Dog.PNG" =>"A Dog","Pig.PNG" =>"A Pig");

$Sign = array_keys($Signs);
foreach($Signs as $File => $Caption){
	echo "<a href='Images/$File'><img src='Images/$File' alt ='$Caption'></a>";
}


?>
</body>
</html>