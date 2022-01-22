import { Component } from '@angular/core';

/**
 * Generated class for the GeometryComponent component.
 *
 * See https://angular.io/api/core/Component for more info on Angular
 * Components.
 */
@Component({
  selector: 'geometry',
  templateUrl: 'geometry.html'
})
export class GeometryComponent {

  text: string;
  geometry: Geometry;

  constructor() {
    console.log('Hello GeometryComponent Component');
    this.text = 'Hello Geometry';
    this.geometry = new Geometry(5,5);
  }

}

class Geometry{
  length:number;
  width:number;
  constructor(length:number,width:number){
    this.length = length;
    this.width = width;
  }
  get area(){
    return this.length * this.width;
  }
}
