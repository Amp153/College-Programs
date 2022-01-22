<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Message Board</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Message Board</h1>
<?php
if((!file_exists("MessageBoard/Messages.txt"))
	|| (filesize("MessageBoard/Messages.txt")
	== 0))
	echo "<p>There are no messages
	posted.</p>\n";
else{
	$MessageArray =
		file("MessageBoard/Messages.txt");
	echo "<table
		style=\"background-color:lightgrey\"
		border=\"1\" width=\"100%\">\n";
	$count = count($MessageArray);
	for($i = 0; $i < $count; ++$i){
		$CurrMsg = explode("~",
			$MessageArray[$i]);
	echo "<tr>\n";
	echo "<td width=\"5%\"
		style=\"text-align:center;
		font-weight:bold\">" .
		($i + 1) . "</td>\n";
	}
}
?>
<p>
<a href="PostMessage.php">
	Post New Message</a>
</p>
</body>
</html>