import { Injectable } from '@angular/core';

@Injectable()
export class LocatiesService {

  constructor() { }

  getLocaties() {
    var locaties =[
      {'naam': 'Daltonlaan 200 (tijdelijke locatie)',
      'adress':'Daltonlaan 200',
      'postcode':'3584 BJ',
      'plaats':'Utrecht28',
      'telefoonnummer': '088-48183',
      'openingstijden': '08:00 - 20:00',
      'cafetaria':false,
      'parkeerMogelijkheden': 'Ja, genoeg'
      },
      {'naam': 'Daltonlaan 200 (tijdelijke locatie)',
        'adress':'Daltonlaan 400',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:00 - 20:00',
        'cafetaria':false,
        'parkeerMogelijkheden': 'Ja, genoeg',
      },
      {'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:30 - 19:00',
        'cafetaria':true,
        'parkeerMogelijkheden': 'Ja, genoeg'

      },
      {'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:30 - 19:00',
        'cafetaria':true,
        'parkeerMogelijkheden': 'Ja, genoeg'

      },
      {'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:30 - 19:00',
        'cafetaria':true,
        'parkeerMogelijkheden': 'Ja, genoeg'

      },
      {'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:30 - 19:00',
        'cafetaria':true,
        'parkeerMogelijkheden': 'Ja, genoeg'

      }
      ]
return locaties;
  }
}
