
<p><?php //reads from the file
			
	$Array = file("proverbs.txt");
	$ProverbCount = count($Array);
	echo "<p>A randomly displayed chinese proverb read from a text file.</p>";
	$NewProverb = rand(0, $ProverbCount - 1);
	echo "<p> $Array[$NewProverb] </p>";

?></p>
			
<p><?php 

	$DragonArray = array('Images/Dragon1.png',
	'Images/Dragon2.png','Images/Dragon3.png',
	'Images/Dragon4.png','Images/Dragon5.png');
	
	shuffle($DragonArray);
	echo '<img src='.$DragonArray[0].' />';

?></p>
<!-- Copyright and Date -->
<p>&copy; <?php echo date("Y") ?></p>