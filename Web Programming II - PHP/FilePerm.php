<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>PHP Template</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php
//1st digit is 0 
//2nd is user permission binary 7 is 111 or read write execute
//3rd is group
//4th is other
chmod('FilePerm.jpg',0730);

//Gives lots of info
$perm = fileperms('FilePerm.jpg');
//gives permissions
$perm = decoct($perm % 01000);

echo 'file permissions for FilePerm.jpg: 0'.$perm.'.';

?>

</body>
</html>