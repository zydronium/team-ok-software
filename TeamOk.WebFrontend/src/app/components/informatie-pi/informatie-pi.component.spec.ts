import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InformatiePiComponent } from './informatie-pi.component';

describe('InformatiePiComponent', () => {
  let component: InformatiePiComponent;
  let fixture: ComponentFixture<InformatiePiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InformatiePiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InformatiePiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
