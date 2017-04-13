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
      'plaats':'Utrecht28',
      'telefoonnummer': '088-48183',
      'openingstijden': '08:00 - 20:00',
      'cafetaria':false,
      'parkeerMogelijkheden': 'Ja, genoeg'
      },
      {'id':2,'naam': 'Daltonlaan 200 (tijdelijke locatie)',
        'adress':'Daltonlaan 400',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:00 - 20:00',
        'cafetaria':false,
        'parkeerMogelijkheden': 'Ja, genoeg',
      },
      {'id':3,'naam': 'Daltonlaan 500 (tijdelijke locatie)',
        'adress':'Daltonlaan 500',
        'postcode':'3584 BJ',
        'plaats':'Utrecht',
        'telefoonnummer': '088-4818283',
        'openingstijden': '08:30 - 19:00',
        'cafetaria':true,
        'parkeerMogelijkheden': 'Ja, genoeg'
      }
    ];
    return locaties;
  }

  getLocatie(locatieid: number) : Locatie {
    let locaties : Array<Locatie> = [
      {
        id: 1,
        naam: 'Daltonlaan 200 (tijdelijke locatie)',
        adress:'Daltonlaan 200',
        postcode:'3584 BJ',
        plaats:'Utrecht',
        telefoonnummer: '088-48183',
        openingstijden: '08:00 - 20:00',
        cafetaria:false,
        parkeermogelijkheden: 'Ja, genoeg'
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
        parkeermogelijkheden: 'Ja, genoeg'
      }
    ];

    locaties = locaties.filter(locatie => locatie.id == locatieid);

    if(locaties.length == 1){
      return locaties[0];
    }
    else {
      return null;
    }
  }
}
