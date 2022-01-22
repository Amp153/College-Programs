/*var name = window.prompt("What is your name");

document.writeln("Hello " + name + ". Welcome to my page");

var first, second, sum;

first = window.prompt("Enter the first number ");
second = window.prompt("Enter the second number ");
sum = parseInt(first) + parseInt(second);

document.writeln("The sum is " + sum);*/

var oneSquare = 1*1;
var oneCube = 1*1*1;
var twoSquare = 2*2;
var twoCube = 2*twoSquare;

document.getElementById('1S').textContent = oneSquare;
document.getElementById('1C').textContent = oneCube;
document.getElementById('2S').textContent = twoSquare;
document.getElementById('2C').textContent = twoCube;
document.getElementById('2C').style.color = 'red';