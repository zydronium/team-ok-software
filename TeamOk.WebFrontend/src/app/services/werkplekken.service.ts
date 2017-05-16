import { Injectable } from '@angular/core';
import {Werkplek} from "../models/Werkplek";
import {Http, Headers} from "@angular/http";

@Injectable()
export class WerkplekkenService {

  private WORKSPACE_URL = "https://backend.werkplek.123apps.net/api/Workspaces";

  constructor(private http : Http) { }

  getWerkplekken(verdiepingid: number) : any {
    var headers = new Headers();
    const result = this.http.get(this.WORKSPACE_URL+"/"+verdiepingid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  getWerkplek(werkplekid: number) : Werkplek {
    let werkplekken : Array<Werkplek> = [
      {id: 1, naam: "Tafel 1", zitplaatsen: 5, stopcontacten: 2, bezet: true, verdiepingid: 1},
      {id: 2, naam: "Tafel 2", zitplaatsen: 5, stopcontacten: 0, bezet: false, verdiepingid: 1},
      {id: 3, naam: "Tafel 3", zitplaatsen: 5, stopcontacten: 3, bezet: true, verdiepingid: 1},
      {id: 4, naam: "Tafel 1", zitplaatsen: 5, stopcontacten: 2, bezet: true, verdiepingid: 6},
      {id: 5, naam: "Tafel 2", zitplaatsen: 5, stopcontacten: 0, bezet: false, verdiepingid: 6},
      {id: 6, naam: "Tafel 3", zitplaatsen: 5, stopcontacten: 3, bezet: true, verdiepingid: 6}
    ];

    werkplekken = werkplekken.filter(werkplek => werkplek.id == werkplekid);

    if(werkplekken.length == 1){
      return werkplekken[0];
    }
    else {
      return null;
    }
  }

  getAlleWerkplekken() : any {
    var headers = new Headers();
    const result = this.http.get(this.WORKSPACE_URL+"/all", {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }
}
