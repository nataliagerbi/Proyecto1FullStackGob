import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MistransaccionesComponent } from './mistransacciones.component';

describe('MistransaccionesComponent', () => {
  let component: MistransaccionesComponent;
  let fixture: ComponentFixture<MistransaccionesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MistransaccionesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MistransaccionesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
