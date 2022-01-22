// Anthony Fuller

//I tried using pure jquery and this is the result after several hours.
//Also I read somewhere online that it's difficult using jquery to modify text nodes.

$(document).ready(function(){
    
 

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
		$(this).css('text-transform','lowercase');
	});
	
	$('.one').on('dblclick', function() {				
		$(this).css('text-transform','uppercase');
	});
 
 
	//Double click the leftmost td on the second row to change the character for the rightmost td.
	$('.two').on('click', function() {
		oVal = $(this);
		val = $(this).prev();
	
		$(val).text($(this).text());
	});
	$('.two').on('dblclick', function() {
		oVal = $(this);
		val = $(this).next().next().next().next();
	
		$(val).text($(this).text());
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