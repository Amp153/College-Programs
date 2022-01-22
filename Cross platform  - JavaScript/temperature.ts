class Temperature{
    ftemp:number;
    constructor(fahrenheit:number){
        this.ftemp = fahrenheit;
    }
    get celsius(){
        return (5/9)*(this.ftemp-32);
    }
    get kelvin(){
        return((5/9)*(this.ftemp-32)+273);
    }
}
let fahrenheit = window.prompt("Please enter a fahrenheit value to convert");

let temperature:Temperature = new Temperature(parseInt(fahrenheit));

window.alert(temperature.ftemp + " Fahrenheit\n"
 + temperature.celsius + " Celsius\n" + temperature.kelvin + " Kelvin");