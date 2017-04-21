import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ZoekResultatenComponent } from './zoek-resultaten.component';

describe('ZoekResultatenComponent', () => {
  let component: ZoekResultatenComponent;
  let fixture: ComponentFixture<ZoekResultatenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ZoekResultatenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ZoekResultatenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
