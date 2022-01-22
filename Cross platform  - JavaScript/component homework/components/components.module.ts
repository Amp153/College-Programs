import { NgModule } from '@angular/core';
import { PersonComponent } from './person/person';
import { CommonModule } from '@angular/common';
@NgModule({
	declarations: [PersonComponent],
	imports: [CommonModule],
	exports: [PersonComponent]
})
export class ComponentsModule {}
