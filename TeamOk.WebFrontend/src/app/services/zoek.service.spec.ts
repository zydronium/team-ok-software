import { TestBed, inject } from '@angular/core/testing';

import { ZoekService } from './zoek.service';

describe('ZoekService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ZoekService]
    });
  });

  it('should ...', inject([ZoekService], (service: ZoekService) => {
    expect(service).toBeTruthy();
  }));
});
