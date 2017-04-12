import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VerdiepingenComponent } from './verdiepingen.component';

describe('VerdiepingenComponent', () => {
  let component: VerdiepingenComponent;
  let fixture: ComponentFixture<VerdiepingenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VerdiepingenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VerdiepingenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
