var Temperature = /** @class */ (function () {
    function Temperature(fahrenheit) {
        this.ftemp = fahrenheit;
    }
    Object.defineProperty(Temperature.prototype, "celsius", {
        get: function () {
            return (5 / 9) * (this.ftemp - 32);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Temperature.prototype, "kelvin", {
        get: function () {
            return ((5 / 9) * (this.ftemp - 32) + 273);
        },
        enumerable: true,
        configurable: true
    });
    return Temperature;
}());
var fahrenheit = window.prompt("Please enter a fahrenheit value to convert");
var temperature = new Temperature(parseInt(fahrenheit));
window.alert(temperature.ftemp + " Fahrenheit\n"
    + temperature.celsius + " Celsius\n" + temperature.kelvin + " Kelvin");
