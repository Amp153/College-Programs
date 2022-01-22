<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Guest</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>

<?php

if(empty($_POST['first_name']) || empty($_POST['last_name'])){
	echo "<p>You must enter your first and last name.";
	echo "Click your browser's Back button to ";
	echo "return to the Guest Book</p>";
}
else{
	$FirstName = addslashes($_POST['first_name']);
	$LastName = addslashes($_POST['last_name']);
	
	//file processing
	//a = open a file to write to and place at end of file
	//w = open a file to write to
	//r = read only
	//b = forces file to open in binary mode
	$GuestBook = fopen("guestbook.txt", "ab");
	if($GuestBook == false)
		echo "File issue";
	else{
		//echo "Free to proceed";
	
	if(is_writeable("guestbook.txt")){
		if(fwrite($GuestBook, $LastName. ", ".$FirstName. "\r\n")
			=== False)
			echo "<p>Cannot add your name to the guest book. </p>";
			else
				echo "<p>Thank you for signing our guest book</p>";
	}
	else
		echo "<p>Cannot write to the file. </p>";
		fclose($GuestBook);
	}
	

}

?>

</body>
</html>