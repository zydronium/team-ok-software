import { Injectable } from '@angular/core';
import {Locatie} from "../models/Locatie";

@Injectable()
export class LocatiesService {

  constructor() { }

  getLocaties() {
    var locaties =[
      {'id':1,
        'naam': 'Daltonlaan 200 (tijdelijke locatie)',
      'adress':'Daltonlaan 200',
      'postcode':'3584 BJ',
      'plaats':'Utrecht',
      'telefoonnummer': '088-48183',
      'openingstijden': '08:00 - 20:00',
      'cafetaria':false,
      'parkeerMogelijkheden': 'Ja, genoeg',
        'lat': 52.0871692,
        'lng': 5.159740899999974
      },
      {'id':2,'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:00 - 20:00',
        'cafetaria':false,
        'parkeerMogelijkheden': 'Ja, genoeg',
        'lat': 52.0884244,
        'lng': 5.159922700000038
      }
    ];
    return locaties;
  }

  getLocatie(locatieid: number) : Locatie {
    var locaties : Array<Locatie> = [
      {
        id: 1,
        naam: 'Daltonlaan 200 (tijdelijke locatie)',
        adress:'Daltonlaan 200',
        postcode:'3584 BJ',
        plaats:'Utrecht',
        telefoonnummer: '088-48183',
        openingstijden: 'maandag t/m vrijdag van 08:00 tot 20:00',
        cafetaria:false,
        parkeermogelijkheden: 'Ja, genoeg',
        lat: 52.0871692,
        lng: 5.159740899999974
      },
      {
        id: 2,
        naam: 'Daltonlaan 500 (tijdelijke locatie)',
        adress:'Daltonlaan 500',
        postcode:'3584 BJ',
        plaats:'Utrecht',
        telefoonnummer: '088-4818283',
        openingstijden: '08:30 - 19:00',
        cafetaria:true,
        parkeermogelijkheden: 'Ja, genoeg',
        lat: 52.0884244,
        lng: 5.159922700000038
      }
    ];

    var locaties = locaties.filter(locatie => locatie.id == locatieid);

    if(locaties.length == 1){
      return locaties[0];
    }
    else {
      return null;
    }
  }
}
