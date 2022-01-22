// Anthony Fuller

/*1. In the first section, display your name, the date (in human-readable format) and the assignment number. This information should be put together in an IIFE.

2. Get a random number between 1 and 20

3. In a loop that will execute for that random number of times, call a function. After calling the function, concatenate the object’s property to a string. When done looping, the concatenated string should display in the second section on your page.

4. The function should set an object’s property to be either “red”, “green” or “yellow”. Which one should you set it to? Every 1st, 4th, 7th, etc. iteration should use “red”. Every 2nd, 5th, 8th, etc. iteration should use “green”. Every 3rd, 6th, 9th, etc. should use “yellow”.

5. On the page, when “red” is displayed, it should use the color red (and green for “green” and yellow for “yellow”). FYI: say you have a string in a variable named word. To display the word in red, you can call the fontcolor() function such as: word.fontcolor(“red”)

Zip the 2 files for your program and submit.*/


// I was having problems with getting step 4 to work and after spending hours on it I have given up.


// iife runs immediately.
( function(){
  var iife = {
	name: 'Anthony',
	date: new Date(),
	assignment: 5,
    lab: function(){
      return this.name + this.date + this.assignment;
    }
  };
  document.write('My name is: ' + iife.name + '<br>');
  document.write('The date is: '+ iife.date + '<br>');
  document.write('Assignment: '+ iife.assignment + '<br>');
}());


/*
// Random number between 1 and 20.
	var ranNum = Math.floor((Math.random() * 19.5)+1);
	
// For debugging purposes
	console.log(ranNum);
	
// Code that doesn't work.
// Before dealing with the for loop I wanted to deal with getting a single line of text to appear.
	if ((Math.floor(ranNum / 3)) === 0){
	msg.color = this.fontcolor('red');
	document.getElementById('second').innerHTML = document.write('red');
	msg = 'red';
	}
	else if ((Math.floor(ranNum / 3)) === 1){
	msg.color = this.fontcolor('green');
	document.getElementById('second').innerHTML = document.write('green');
	msg = 'green';
	}
	else {
	msg.color = this.fontcolor('yellow');
	document.getElementById('second').innerHTML = document.write('yellow');
	msg = 'yellow';
	}
	//}
	document.getElementById('second').innerHTML = msg;
//};


document.write(ranColor); */

var ranNum = Math.floor((Math.random() * 19.5)+1);
 
 var light = new Object();       //define an object
 var msg = '';
 for (var x = 1; x <= ranNum; x++) {    //loop
  setColor(x);                                      //invoke a function
  msg += light.color + '<br/>';          //concatenate the color
 }
 document.getElementById('second').innerHTML = msg;


 
 function setColor(loop) {
 if(loop % 3 === 1){
  light.color = "red";
  light.color = light.color.fontcolor("red");
 }
 else if(loop % 3 === 0){
  light.color = "yellow";
  light.color = light.color.fontcolor("yellow");
 }
 else {
  light.color = "green";
  light.color = light.color.fontcolor("green");
 }
 }