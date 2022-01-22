// Anthony Fuller

//The javascript code  starts immediately
$(document).ready(function(){
	
	//Each item has a picture before it and a price after it.
	$('.one').prepend('<img src=css/1.PNG>');
	$('.one').append(' $5.00');
	$('.two').prepend('<img src=css/2.PNG>');
	$('.two').append(' $6.00');
	$('.three').prepend('<img src=css/3.PNG>');
	$('.three').append(' $7.00');
	$('.four').prepend('<img src=css/4.PNG>');
	$('.four').append(' $8.00');
	$('.five').prepend('<img src=css/5.PNG>');
	$('.five').append(' $9.00');
	$('.six').prepend('<img src=css/6.PNG>');
	$('.six').append(' $7.00');
	$('.seven').prepend('<img src=css/7.PNG>');
	$('.seven').append(' $4.00');
	$('.eight').prepend('<img src=css/8.PNG>');
	$('.eight').append(' $9.00');
	$('.nine').prepend('<img src=css/9.PNG>');
	$('.nine').append(' $8.00');
	$('.ten').prepend('<img src=css/10.PNG>');
	$('.ten').append(' $12.00');
	
//Enlarge the image when the cursor is on the image
	$('img').on('mouseover', function() {
		 $(this).animate({height: '500px'});
	});
	
//Resets the image to it's original value
	$('img').on('mouseout', function() {
		 $(this).animate({height: 'auto'});
	});
	
//Adds the checkboxs for each item.
	$('.one').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.two').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.three').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.four').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.five').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.six').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.seven').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.eight').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.nine').append('-Buy one: <input type="checkbox" value="1"/>');
	$('.ten').append('-Buy one: <input type="checkbox" value="1"/>');

//Adds the button at the end
	$('.button').append('<input type="button" value="proceed to cart"/>');
		
//I got localStorage to work but haven't fully tested it.
		localStorage.setItem('item1', '5');
		console.log('the item is ' + localStorage.getItem('item1'));
		localStorage.setItem('item2', '6');
		console.log('the item is ' + localStorage.getItem('item2'));
		localStorage.setItem('item3', '7');
		console.log('the item is ' + localStorage.getItem('item3'));
		localStorage.setItem('item4', '8');
		console.log('the item is ' + localStorage.getItem('item4'));
		localStorage.setItem('item5', '9');
		console.log('the item is ' + localStorage.getItem('item5'));
		localStorage.setItem('item6', '7');
		console.log('the item is ' + localStorage.getItem('item6'));
		localStorage.setItem('item7', '4');
		console.log('the item is ' + localStorage.getItem('item7'));
		localStorage.setItem('item8', '9');
		console.log('the item is ' + localStorage.getItem('item8'));
		localStorage.setItem('item9', '8');
		console.log('the item is ' + localStorage.getItem('item9'));
		localStorage.setItem('item10', '12');
		console.log('the item is ' + localStorage.getItem('item10'));
	

 });