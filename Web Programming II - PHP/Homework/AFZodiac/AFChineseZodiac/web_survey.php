<?php
session_start();

$survey_questions = array(
	1 => "Was the navigation straightforward and " .
	" did all of the links work?", // Fixed sentence
	2 => "Was the selection of the background color " .
	" font color, and font size appropriate?",
	3 => "Were the images appropriate and did they " .
	" complement the Web content?",
	4 => "Were the descriptions of the PHP program " .
	" complete and easy to understand?",
	5 => "Was the PHP code structured properly and " .
	" well commented?");
$question_count = count($survey_questions);

if (isset($_SESSION['CurrentQuestion'])){
	if (($_SESSION['CurrentQuestion'] > 0) &&
		(isset($_POST['response']))){
		 $_SESSION['Responses']
		 [$_SESSION['CurrentQuestion']]
			= $_POST['response'];
		}
		++$_SESSION['CurrentQuestion'];
}
else
	$_SESSION['CurrentQuestion'] = 0;
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Web Survey</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<h1>Web Survey</h1>
<?php
if ($_SESSION['CurrentQuestion'] == 0){
?>
<p>Thank you for reviewing the Chinese Zodiac Web Site. Your candid
responses to the following five questions will help to improve the 
effectiveness of our PHP demonstration site.</p>
<?php
}
else if ($_SESSION['CurrentQuestion'] > $question_count){
?>
<p>Thank you for completeing the survey.</p>
<a href = "index.php"> Back to home page</a>
<?php 
//add code here to display the results
$MsgBody="The following responses were entered: ";
echo "<dl>";
foreach ($_SESSION['Responses'] as $index => $response) {
	echo "<dt>$index ".$survey_questions[$index]."</dt>";
	echo "<dd>".$response."</dd>";
	$MsgBody .= "Question $index".$survey_questions[$index]."\n";
	$MsgBody .= "* Response: $response \n\n";
}
echo "</dl>\n";

/*else {
	echo "<p>Question " . $_SESSION['CurrentQuestion'] .
	": " . $survey_questions[$_SESSION['CurrentQuestion']]
	. "</p>\n";*/
}

if ($_SESSION['CurrentQuestion'] <= $question_count)
{
	echo "<form method='post' action='web_survey.
	php'>\n";
	echo "<input type='hidden' name='PHPSESSID'
	value=' " .
	session_id() . "' />\n";
	if ($_SESSION['CurrentQuestion'] > 0){
		echo "<p><input type='radio'
			name='response' " .
			" value='Exceeds Expectations' /> " .
			" Exceeds Expectations<br />\n";
		echo "<input type='radio' name='response' " .
			" value='Meets Expectations'" .
			" checked='checked' /> " .
			" Meets Expectations<br />\n";
		echo "<input type='radio' name='response' " .
			" value='Below Expectations' /> " .
			" Below Expectations</p>";
	}
	echo "<input type='submit' name='submit' value='";
	if ($_SESSION['CurrentQuestion'] == 0)
		echo "Start the survey";
	else if ($_SESSION['CurrentQuestion'] ==
	$question_count)
		echo "Finished";
	else
		echo "Next Question";
	echo "' />\n";
	echo "</form>\n";
}
?>
</body>