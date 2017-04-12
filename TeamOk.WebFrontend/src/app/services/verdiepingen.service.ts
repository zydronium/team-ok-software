import { Injectable } from '@angular/core';
import {Verdieping} from "../models/Verdieping";

@Injectable()
export class VerdiepingenService {

  constructor() { }

  getVerdiepingen(locatieid: number) : Array<Verdieping> {
    let verdiepingen : Array<Verdieping> = [
      {id: 1, naam: "Bagane grond", werkplekken: 15, vrije_werkplekken: 5, locatieid: 1},
      {id: 2, naam: "Verdieping 1", werkplekken: 9, vrije_werkplekken: 3, locatieid: 1},
      {id: 3, naam: "Instituutsplein ICT", werkplekken: 42, vrije_werkplekken: 0, locatieid: 1},
      {id: 4, naam: "Verdieping 3", werkplekken: 11, vrije_werkplekken: 4, locatieid: 1},
      {id: 5, naam: "Verdieping 4", werkplekken: 16, vrije_werkplekken: 6, locatieid: 1},
      {id: 51, naam: "Verdieping 5", werkplekken: 16, vrije_werkplekken: 6, locatieid: 1},
      {id: 52, naam: "Verdieping 6", werkplekken: 16, vrije_werkplekken: 6, locatieid: 1},
      {id: 6, naam: "Bagane grond", werkplekken: 15, vrije_werkplekken: 5, locatieid: 2},
      {id: 7, naam: "Verdieping 1", werkplekken: 20, vrije_werkplekken: 4, locatieid: 2},
      {id: 8, naam: "Verdieping 2", werkplekken: 14, vrije_werkplekken: 0, locatieid: 2},
      {id: 9, naam: "Verdieping 3", werkplekken: 19, vrije_werkplekken: 9, locatieid: 2},
      {id: 10, naam: "Verdieping 4", werkplekken: 7, vrije_werkplekken: 2, locatieid: 2}
    ];

    verdiepingen = verdiepingen.filter(verdieping => verdieping.locatieid == locatieid);

    return verdiepingen
  }
}
