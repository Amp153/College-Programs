// Anthony Fuller

//I tried using pure jquery and this is the result after several hours.
//Also I read somewhere online that it's difficult using jquery to modify text nodes.

$(document).ready(function(){
    /*Row 2 - Clicking the left-most cell doesn't wrap its contents to the right-most cell. Having me double click is not the solution (code to the requirements, don't change the requirements due to the code). Here's what you could do to get it to work (in the html, I also added an id of last to the 5th td in row 2):

$('.two').on('click', function() {
  //oVal = $(this);)
  if ($(this).index() == 0)       //the first cell
   $('#last').text($(this).text());    //change last cell's text
  else      //on the false path, do what you were doing
  {
  val = $(this).prev();
 
  $(val).text($(this).text());
  }
 });

Row 1 - on a click, change the case (no double clicking). As an example of what you could do is (an this requires that an id is set in the html for your first tr element)

document.getElementById("row1").addEventListener('click',function(e) {processRow1(e);},false);
 function processRow1(e) {
 var txt = e.target.textContent;
 if (txt == txt.toLowerCase())
  e.target.textContent = txt.toUpperCase();
 else
  e.target.textContent = txt.toLowerCase();
}*/
 

	//The fade for the top row is to know when the page is ready.
	//I've spent hours on this so I got impatiant waiting for the page to load.
	//Use it if you need it.
	//$('td:lt(5)').hide().fadeIn(1500);
	
	//Separating everything into small sections.
	$('td:lt(5)').addClass('one');
	$('td:gt(4)').addClass('two');
	$('td:gt(9)').removeClass('two');
	$('td:gt(9)').addClass('three');
	
	//Jquery makes if else statements really hard so everything I would've used one with uses double click.
	//Had trouble getting it to go back to uppercase. Double click makes it uppercase.
	$('.one').on('click', function() {	
	var txt = $(this).text()
 if (txt == txt.toLowerCase())
  $(this).textContent = txt.toUpperCase();
 else
  $(this).textContent = txt.toLowerCase();
});
 
 
	//Double click the leftmost td on the second row to change the character for the rightmost td.
	$('.two').on('click', function() {
		oVal = $(this);
		if ($(this).index() == 0)       //the first cell
   $(this).next().next().next().next().text($(this).text());    //change last cell's text
  else	
		$(this).prev().text($(this).text());
	});
 
 
	//Technically it's css.
	$('.three').on('mouseover', function() {
		$(this).css('color','blue');
		$(this).css('background-color','red');  
	});
	$('.three').on('mouseout', function() {
		$(this).css('color','black');
		$(this).css('background-color','white');  
	});
 });