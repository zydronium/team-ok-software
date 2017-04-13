import { Injectable } from '@angular/core';
import {Werkplek} from "../models/Werkplek";

@Injectable()
export class WerkplekkenService {

  constructor() { }

  getWerkplekken(verdiepingid: number) : Array<Werkplek> {
    let werkplekken : Array<Werkplek> = [
      {id: 1, naam: "Tafel 1", zitplaatsen: 5, stopcontacten: 2, bezet: true, verdiepingid: 1},
      {id: 2, naam: "Tafel 2", zitplaatsen: 5, stopcontacten: 0, bezet: false, verdiepingid: 1},
      {id: 3, naam: "Tafel 3", zitplaatsen: 5, stopcontacten: 3, bezet: true, verdiepingid: 1},
      {id: 4, naam: "Tafel 1", zitplaatsen: 5, stopcontacten: 2, bezet: true, verdiepingid: 6},
      {id: 5, naam: "Tafel 2", zitplaatsen: 5, stopcontacten: 0, bezet: false, verdiepingid: 6},
      {id: 6, naam: "Tafel 3", zitplaatsen: 5, stopcontacten: 3, bezet: true, verdiepingid: 6}
    ];

    werkplekken = werkplekken.filter(werkplek => werkplek.verdiepingid == verdiepingid);

    return werkplekken
  }

}
