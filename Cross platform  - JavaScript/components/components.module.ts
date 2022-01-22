import { NgModule } from '@angular/core';
import { HelloComponent } from './hello/hello';
import { CommonModule} from '@angular/common';
//automatically imported
import { GeometryComponent } from './geometry/geometry';
import { CircleComponent } from './circle/circle';
import { TriangleComponent } from './triangle/triangle';
@NgModule({
	declarations: [HelloComponent,
    GeometryComponent,
    CircleComponent,
    TriangleComponent],
	imports: [CommonModule],
	exports: [HelloComponent,
    GeometryComponent,
    CircleComponent,
    TriangleComponent]
})
export class ComponentsModule {}
