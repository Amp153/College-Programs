<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chapter 1</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<p>
<!--
<?php
echo "This text is displayed using standard PHP 
script delimiters. ";
//phpinfo();
$word = "Hi";
echo "My word is $word";
echo 'My word is $word';
?>
<script language="php">
echo "Does this text work?";
</script>
<?
echo "Does this text work?";
?>
<%
echo "Does this text work?";
%> -->

<?php
// This is a comment
/* Another comment*/
//Variable identifiers MUST start with $, then letters, numbers or underscore and are case sensitive

$one = "abc";
$two = 'def';

// This is a constant
// FINAL int RATE = 8; -->java
define ("RATE", 8);

echo "My var are " ,$one,$two;
$one = 51;
echo "</br>";
echo "Multiplication attempt",$one *2;
echo "</br>";
echo $one;
//echo "<strong> Some text </strong>";
echo "</br>";
$classList = array("Josh", "Mike", 37);
echo $classList[2];
echo "<pre>";
echo print_r($classList);
echo "</pre>";
$cL[] = "Josh";
$cL[] = "Mike";
$cL[] = 37;
echo "</br>";

$x = 7;
$y = 2;
$z = 0;
$z = $x/$y;
echo $z;
echo $x/$y;

//False wont show up, make statements true instead to make a 1 appear
$k = 2 == 3; 
echo $k;
$k = "2" + "3";
echo $k;
$k = 2 >= 3;
echo $k;
$k = (2 >=3)XOR (2 > 3);
echo $k;
$k = 2 == '2';
echo $k;
$k = !(2 === "2"); 
echo $k;
$k = (2 >= 3? false: true); //conditional expression
echo $k;
?>
</p>
</body>
</html>