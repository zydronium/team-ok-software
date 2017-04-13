import { TestBed, inject } from '@angular/core/testing';

import { WerkplekkenService } from './werkplekken.service';

describe('WerkplekkenService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WerkplekkenService]
    });
  });

  it('should ...', inject([WerkplekkenService], (service: WerkplekkenService) => {
    expect(service).toBeTruthy();
  }));
});
