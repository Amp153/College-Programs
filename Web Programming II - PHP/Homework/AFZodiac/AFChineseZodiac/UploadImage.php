<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<!-- Anthony Fuller -->
<head>
<title>UPLOAD Image</title>
<meta http-equiv="content-type"
	content="text/html; charset=iso-8859-1" />
</head>
<body>
<?php 
 	$Dir = '.\Images';
if(isset($_POST['upload'])){
	if(isset($_FILES['new_file'])){
		if(move_uploaded_file(
		$_FILES['new_file']['tmp_name'],
		$Dir."\\".$_FILES['new_file']
		['name']) == True){
			chmod($Dir."\\".$_FILES['new_file']
			['name'], 0644);
			echo "File \"".
				htmlentities($_FILES['new_file']
				['name']).
				"\"successfully uploaded.
				<br />\n";
		}
		else
			echo "There was an error
			uploading \"".
			htmlentities($_FILES['new_file']
			['name']).
			"\".<br />\n";
	}
}
?>
 <form action="UploadImage.php" method="POST"
 enctype="multipart/form-data">
 <input type="hidden" name="MAX_FILE_SIZE"
 value="25000" /><br />
 File to upload:<br />
 <input type="file" name="new_file" /><br />
 (25,000 byte size limit) <br />
 <input type="submit" name="upload" value="upload the 
 File" />
 <br />
 </form>

</body>
</html>