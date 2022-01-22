<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0
Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head>
<title>Similar Names</title>
</head>
<body>
<h1>Similar Names</h1><hr />
<?php
$SignNames = array(
	"Rat",
	"Ox",
	"Tiger",
	"Rabbit",
	"Dragon",
	"Snake",
	"Horse",
	"Goat",
	"Monkey",
	"Rooster",
	"Dog",
	"Pig");
	$LevenshteinSmallest = 999999;
	$SimilarTextLargest = 0;
	
	for ($i=0; $i<11; ++$i){
		for ($j=$i+1; $j<12; ++$j){
			$LevenshteinValue =
				levenshtein($SignNames[$i],
					$SignNames[$j]);
			if($LevenshteinValue <
				$LevenshteinSmallest){
					$LevenshteinSmallest =
						$LevenshteinValue;
					$LevenshteinWorld1 =
						$SignNames[$i];
					$LevenshteinWorld2 =
						$SignNames[$j];
			}
			$SimilarTextValue =
				similar_text($SignNames[$i],
					$SignNames[$j]);
			if($SimilarTextValue >
				$SimilarTextLargest){
				$SimilarTextLargest =
					$SimilarTextValue;
				$SimilarTextWorld1 =
					$SignNames[$i];
				$SimilarTextWorld2 =
					$SignNames[$j];
			}
		}
	}
	echo "<p>The levenshtein() function has determined that
	&quot; $LevenshteinWorld1&quot; and
	&quot; $LevenshteinWorld2&quot; are the most
	similar names.</p>\n";
	echo "<p>The similar_text() function has determined that
	&quot; $SimilarTextWorld1&quot; and
	&quot; $SimilarTextWorld2&quot; are the most
	similar names.</p>\n";
?>
</body>
</html>