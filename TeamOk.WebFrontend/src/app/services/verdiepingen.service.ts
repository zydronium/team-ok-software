import { Injectable } from '@angular/core';
import {Verdieping} from "../models/Verdieping";

@Injectable()
export class VerdiepingenService {

  constructor() { }

  getVerdiepingen(locatieid: number) : Array<Verdieping> {
    let verdiepingen : Array<Verdieping> = [
      {id: 1, naam: "Bagane grond", werkplekken: 15, locatieid: 1},
      {id: 2, naam: "Verdieping 1", werkplekken: 9, locatieid: 1},
      {id: 3, naam: "Instituutsplein ICT", werkplekken: 42, locatieid: 1},
      {id: 4, naam: "Verdieping 3", werkplekken: 11, locatieid: 1},
      {id: 5, naam: "Verdieping 4", werkplekken: 16, locatieid: 1},
      {id: 6, naam: "Bagane grond", werkplekken: 15, locatieid: 2},
      {id: 7, naam: "Verdieping 1", werkplekken: 20, locatieid: 2},
      {id: 8, naam: "Verdieping 2", werkplekken: 14, locatieid: 2},
      {id: 9, naam: "Verdieping 3", werkplekken: 19, locatieid: 2},
      {id: 10, naam: "Verdieping 4", werkplekken: 7, locatieid: 2}
    ];

    verdiepingen = verdiepingen.filter(verdieping => verdieping.locatieid == locatieid);

    return verdiepingen
  }
}
