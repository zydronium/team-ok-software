import { TestBed, inject } from '@angular/core/testing';

import { VerdiepingenService } from './verdiepingen.service';

describe('VerdiepingenService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [VerdiepingenService]
    });
  });

  it('should ...', inject([VerdiepingenService], (service: VerdiepingenService) => {
    expect(service).toBeTruthy();
  }));
});
