import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VerdiepingComponent } from './verdieping.component';

describe('VerdiepingComponent', () => {
  let component: VerdiepingComponent;
  let fixture: ComponentFixture<VerdiepingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VerdiepingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VerdiepingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
