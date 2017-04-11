import { TestBed, inject } from '@angular/core/testing';

import { LocatieService } from './locatie.service';

describe('LocatieService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LocatieService]
    });
  });

  it('should ...', inject([LocatieService], (service: LocatieService) => {
    expect(service).toBeTruthy();
  }));
});
