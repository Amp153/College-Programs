var variableName= "string value";
var numberVariable= 3;
var decimalVariable= 4.1;

variableName= "a new value";
numberVariable= "string";

console.log("hello from basic.js",variableName,numberVariable);

var booleanVariable = false;
var someOtherBooleanVariable;

function add(a=2,b=4){
    return a+b;
}
//assumes defaults
add();
//assumes b is 4
add(8);
//assumes nothing
add(3,5);

