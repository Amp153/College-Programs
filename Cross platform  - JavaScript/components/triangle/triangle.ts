import { Component } from '@angular/core';

/**
 * Generated class for the TriangleComponent component.
 *
 * See https://angular.io/api/core/Component for more info on Angular
 * Components.
 */
@Component({
  selector: 'triangle',
  templateUrl: 'triangle.html'
})
export class TriangleComponent {

  text: string;
  triangle:Triangle;

  constructor() {
    console.log('Hello TriangleComponent Component');
    this.text = 'Hello World';
    this.triangle = new Triangle(5,10);

  }

}
class Triangle{
  base:number;
  height:number;
  constructor(base:number,height:number){
    this.base = base;
    this.height = height;
  }
  get area(){
    return .5 * this.base * this.height;

  }
}
