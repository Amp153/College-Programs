<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>Chinese Zodiac</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<?php include("Includes/inc_site_counter.php"); ?>
<br />

<?php include("Includes/inc_banner_display.php"); ?>
<br />

<?php include("Includes/inc_header.php"); ?>
<br />

<?php include("Includes/inc_text_links.php"); ?>
<br />

<div style = "float:left">
<?php include("Includes/inc_button_nav.php"); ?>
</div>

<?php 
	if(isset($_GET['page'])){
		switch ($_GET['page']){
			case 'site_layout':
				include('Includes/inc_site_layout.php');
				break;
			case 'control_structures':
				include('Includes/'.
					'inc_control_structures.php');
				break;
			case 'string_functions':
				include('Includes/'.
					'inc_string_functions.php');
				break;
			case 'web_forms':
				include('Includes/inc_web_forms.php');
				break;
			case 'midterm_assessment':
				include('Includes/'.
					'inc_midterm_assessment.php');
				break;
			case 'state_information':
				include('Includes/'.
					'inc_state_information.php');
				break;
			case 'user_templates':
				include('Includes/'.
					'inc_user_templates.php');
				break;
			case 'final_project':
				include('Includes/'.
					'inc_final_project.php');
				break;
			case 'home_page': //A value of
							  //'home_page' means
							  //to display the
							  //default page
			default:
				include("Includes/inc_home.php"); 
				break;
		}
	}
else //If no button has been selected, then display 
	 //the default page
	 include("Includes/inc_home.php");
	
?>

<div style= "position: relative;clear: both;">
<?php include("Includes/inc_footer.php"); ?>
</div>
</body>
</html>