import { Component,Input } from '@angular/core';

/**
 * Generated class for the PersonComponent component.
 *
 * See https://angular.io/api/core/Component for more info on Angular
 * Components.
 */
@Component({
  selector: 'person',
  templateUrl: 'person.html'
})
export class PersonComponent {

  text: string;
  @Input()person:Person;

 /* constructor() {
    this.person = new Person("Anthony","Fuller");
  }*/

}
export class Person{
  firstName:string;
  lastName:string;
  constructor(firstName:string,lastName:string){
    this.firstName = firstName;
    this.lastName = lastName;
  }

  get fullName(){
    return `${this.firstName} ${this.lastName}`;
  }

  set fullName(fullName:string){
    let nameBits = fullName.split(" ");
    this.firstName = nameBits[0];
    this.lastName = nameBits[1];
  }
}
