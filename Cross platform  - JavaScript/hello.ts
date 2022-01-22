let greeting = "Hello Typescript!";
alert(greeting);
let variable2 = "variable2";
let add = (a,b)=>a+b;

greeting = "3";

let firstName:string = "Anthony";
let greeter = (personName:string, age:number)=>
    'Hello ${personName} you are ${age}'

greeter(firstName,598);

let earDrummers:any ="3";
earDrummers = 3;
earDrummers = false;

let unionType: boolean | string = "string value";
unionType = false;

function myFunction():boolean{
    return false;
}
function myOtherFunction(arg1:string,arg2:number,arg3:boolean):number{
    return 3;
}
let someNumber = myOtherFunction("",3,false);

function optionalArguments(arg1:string,arg2?:number,arg3?:number){

}
optionalArguments("");

class Geometry{
    length:number;
    width:number;
    constructor(length:number,width:number){
        this.length = length;
        this.width = width;
    }
    getArea():number{
        return this.length * this.width;
    }
}

let geometry:Geometry = new Geometry(3,3);
geometry.getArea();

class Car{
    //make:string;
    //model:string;
    constructor(public make:string,public model:string){
        //this.make = make;
        //this.model = model;
    }
}
let car:Car = new Car("Ford","Mustang");

class Person{
    private _firstName:string;
    lastName:string;
    constructor(firstName:string,lastName:string){
        this._firstName = firstName;
        this.lastName = lastName;
    }
    get firstName(){
        return this._firstName;
    }
    set firstName(firstName:string){
        this._firstName = firstName;
    }
}
let person:Person = new Person("Anthony","Fuller");
person.firstName = "bob";
person.lastName;