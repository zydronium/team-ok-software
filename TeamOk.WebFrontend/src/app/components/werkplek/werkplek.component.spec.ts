import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WerkplekComponent } from './werkplek.component';

describe('WerkplekComponent', () => {
  let component: WerkplekComponent;
  let fixture: ComponentFixture<WerkplekComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WerkplekComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WerkplekComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
