import { TestBed, inject } from '@angular/core/testing';

import { LocatiesService } from './locaties.service';

describe('LocatiesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LocatiesService]
    });
  });

  it('should ...', inject([LocatiesService], (service: LocatiesService) => {
    expect(service).toBeTruthy();
  }));
});
