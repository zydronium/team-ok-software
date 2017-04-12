import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocatiesComponent } from './locaties.component';

describe('LocatiesComponent', () => {
  let component: LocatiesComponent;
  let fixture: ComponentFixture<LocatiesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocatiesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocatiesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
