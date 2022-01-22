function start()
{
	var current = new Date();
	var hour = current.getHours();
	var msg;
	
	switch (hour) {
		case 0:
			msg = 'midnight';
			break;
		case 1:
		case 2:
		case 3:
		case 4:
			msg = 'early morning';
			break;
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
			msg= 'morning';
			break;
		case 12:
			msg = 'noon';
			break;
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
			msg = 'afternoon';
			break;
		default:
			msg= 'evening';
			break;
	}
	document.getElementById("decision").innerHTML = msg + ' ' + hour;
	
	document.getElementById("strings").innerHTML =
	'<p>toString: '+ current.toString()+ '</p>' +
	'<p>toLocaleString: '+ current.toLocaleString()+ '</p>' +
	'<p>toUTCString: '+ current.toUTCString()+ '</p>' +
	'<p>valueOf: '+ current.valueOf()+ '</p>';
	
	document.getElementById('getMethods').innerHTML =
	'<p>getDate: ' + current.getDate() + '</p>' +
	'<p>getDay: ' + current.getDay() + '</p>' +
	'<p>getMonth: ' + current.getMonth() + '</p>' +
	'<p>getFullYear: ' + current.getFullYear() + '</p>' +
	'<p>getTime: ' + current.getTime() + '</p>' +
	'<p>getHours: ' + current.getHours() + '</p>' +
	'<p>getMinutes: ' + current.getMinutes() + '</p>' +
	'<p>getSeconds: ' + current.getSeconds() + '</p>' +
	'<p>getMilliseconds: ' + current.getMilliseconds() + '</p>' +
	'<p>getTimezoneOffset: ' + current.getTimezoneOffset() + '</p>';
	
	var anotherDate = new Date(2015,2,18,1,5,0,0);
	document.getElementById("newArguments").innerHTML =
	'<p>Date: ' + anotherDate + '<p>';
	
	anotherDate.setDate(30);
	anotherDate.setMonth(3);
	anotherDate.setFullYear(2017);
	document.getElementById("setMethods").innerHTML =
	'<p>Modified Date: ' + anotherDate + '<p>';
	
	 
		
}
window.addEventListener('load',start,false);