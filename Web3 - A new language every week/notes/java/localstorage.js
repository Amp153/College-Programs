//chrome inspect application storage
localStorage.setItem("firstName","Anthony");
let uniqueName = localStorage.getItem("firstName");
console.log(uniqueName);

sessionStorage.setItem("dies","when closed");

localStorage.setItem("person",JSON.stringify({firstName:"Anthony",lastName:"Fuller"}));
let aPerson = JSON.parse(localStorage.getItem("person"));
console.log(aPerson);

let doesNotExist = JSON.parse(localStorage.getItem("highscore")) || 0;
console.log(doesNotExist);
