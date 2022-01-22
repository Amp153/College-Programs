<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chinese Zodiac for loop</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<!--Table Header-->
<table border='1'>
<tr>
<th>Rat</th>
<th>Ox</th>
<th>Tiger</th>
<th>Rabbit</th>
<th>Dragon</th>
<th>Snake</th>
<th>Horse</th>
<th>Sheep</th>
<th>Monkey</th>
<th>Rooster</th>
<th>Dog</th>
<th>Pig</th>
</tr>

<?php

//Adds the picture locations to the array
$Signs = array("Images/Rat.PNG","Images/Ox.PNG","Images/Tiger.PNG","Images/Rabbit.PNG",
"Images/Dragon.PNG","Images/Snake.PNG","Images/Horse.PNG","Images/Sheep.PNG",
"Images/Monkey.PNG","Images/Rooster.PNG","Images/Dog.PNG","Images/Pig.PNG");


//Displayes the pictures in the array
echo ("<tr>");
$I = 0;
while($I < 12){
	echo ("<td>");
	echo ("<img src=$Signs[$I] />");
	echo ("</td>");
	$I++;
}
echo ("</tr>");
$i = 1912;
//Displays the dates in the table
while( $i<=2017){
	if($i % 12 == 4){
	echo ("<tr>");
	}
	echo ("<td>");
	echo ($i);
	echo ("</td>");
	if($i % 12 == 3){
	echo ("</tr>");
	}
	$i++;
}

?>

</table>

</body>
</html>