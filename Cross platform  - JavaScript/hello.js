var greeting = "Hello Typescript!";
alert(greeting);
var variable2 = "variable2";
var add = function (a, b) { return a + b; };
greeting = "3";
var firstName = "Anthony";
var greeter = function (personName, age) {
    return 'Hello ${personName} you are ${age}';
};
greeter(firstName, 598);
var earDrummers = "3";
earDrummers = 3;
earDrummers = false;
var unionType = "string value";
unionType = false;
function myFunction() {
    return false;
}
function myOtherFunction(arg1, arg2, arg3) {
    return 3;
}
var someNumber = myOtherFunction("", 3, false);
function optionalArguments(arg1, arg2, arg3) {
}
optionalArguments("");
var Geometry = /** @class */ (function () {
    function Geometry(length, width) {
        this.length = length;
        this.width = width;
    }
    Geometry.prototype.getArea = function () {
        return this.length * this.width;
    };
    return Geometry;
}());
var geometry = new Geometry(3, 3);
geometry.getArea();
var Car = /** @class */ (function () {
    //make:string;
    //model:string;
    function Car(make, model) {
        this.make = make;
        this.model = model;
        //this.make = make;
        //this.model = model;
    }
    return Car;
}());
var car = new Car("Ford", "Mustang");
var Person = /** @class */ (function () {
    function Person(firstName, lastName) {
        this._firstName = firstName;
        this.lastName = lastName;
    }
    Object.defineProperty(Person.prototype, "firstName", {
        get: function () {
            return this._firstName;
        },
        set: function (firstName) {
            this._firstName = firstName;
        },
        enumerable: true,
        configurable: true
    });
    return Person;
}());
var person = new Person("Anthony", "Fuller");
person.firstName = "bob";
person.lastName;
