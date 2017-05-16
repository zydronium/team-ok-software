import { Injectable } from '@angular/core';
import {Verdieping} from "../models/Verdieping";
import {Http, Headers} from "@angular/http";

@Injectable()
export class VerdiepingenService {

  private FLOORS_URL = "https://backend.werkplek.123apps.net/api/Floors";

  constructor(private http : Http) { }

  getVerdiepingen(locatieid: number) : any {
    var headers = new Headers();
    const result = this.http.get(this.FLOORS_URL+"/"+locatieid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  getVerdieping(locatieid : number, verdiepingid: number) : any{
    var headers = new Headers();
    const result = this.http.get(this.FLOORS_URL+"/"+locatieid+"/"+verdiepingid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }
}
