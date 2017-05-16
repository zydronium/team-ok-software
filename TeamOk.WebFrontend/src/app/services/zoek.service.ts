import { Injectable } from '@angular/core';
import {ZoekWerkplek} from "../models/ZoekWerkplek";

@Injectable()
export class ZoekService {

  constructor() { }

  getVrijeWerkplekken() : Array<ZoekWerkplek> {
    let werkplekken : Array<ZoekWerkplek> = [
      {id: 1, naam: "Tafel 1", zitplaatsen: 5, stopcontacten: 2, verdiepingNaam: "Instituutsplein ICT", locatieid: 1, locatieAdress: "Daltonlaan 200", locatiePlaats: "Utrecht"},
      {id: 2, naam: "Tafel 2", zitplaatsen: 4, stopcontacten: 0, verdiepingNaam: "Instituutsplein ICT", locatieid: 1, locatieAdress: "Daltonlaan 200", locatiePlaats: "Utrecht"},
      {id: 3, naam: "Tafel 3", zitplaatsen: 10, stopcontacten: 6, verdiepingNaam: "Instituutsplein ICT", locatieid: 1, locatieAdress: "Daltonlaan 200", locatiePlaats: "Utrecht"},
      {id: 4, naam: "Tafel 1", zitplaatsen: 3, stopcontacten: 2, verdiepingNaam: "Bagane grond", locatieid: 2, locatieAdress: "Daltonlaan 500", locatiePlaats: "Utrecht"},
      {id: 5, naam: "Tafel 2", zitplaatsen: 5, stopcontacten: 0, verdiepingNaam: "Bagane grond", locatieid: 2, locatieAdress: "Daltonlaan 500", locatiePlaats: "Utrecht"},
      {id: 6, naam: "Tafel 3", zitplaatsen: 7, stopcontacten: 4, verdiepingNaam: "Bagane grond", locatieid: 2, locatieAdress: "Daltonlaan 500", locatiePlaats: "Utrecht"}
    ];

    return werkplekken
  }
}
