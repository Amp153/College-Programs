<?php
session_start();
require_once("class_EventCalendar.php");
if (class_exists("EventCalendar")){
	if (isset($_SESSION['currentCalendar']))
		$Calendar = unserialize($_SESSION['currentCalendar']);
	else{
		$Calendar = new EventCalendar();
	}
}
else{
	$Calendar = NULL;
}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Event Details</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Event Details</h1>
<?php

//determine the event based on the url
$url=$_SERVER['REQUEST_URI'];
//strrpos gets the position of the last occurrence of the string
//substr returns everything after that position.
$EventID = substr($url, strrpos($url, '&EventID=') + 9);

//invokes the function in class_EventCalendar
$Calendar->getEventDetails($EventID);



?>
<a href="EventCalendar.php?PHPSESSID=<?php echo
	session_id(); ?>">View the event calendar</a>

<br />
<a href="RemoveCalendarEvent.php?PHPSESSID=<?php echo
						session_id()."&EventID=".$EventID; ?>"
						>Delete the event</a>
</body>
</html>