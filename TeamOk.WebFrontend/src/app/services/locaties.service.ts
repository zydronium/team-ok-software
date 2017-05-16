import { Injectable } from '@angular/core';
import {Locatie} from "../models/Locatie";
import 'rxjs/Rx';
import {Observable} from "rxjs";
import {Http, Headers} from "@angular/http";

@Injectable()
export class LocatiesService {

  private LOCATIONS_URL = "https://backend.werkplek.123apps.net/api/Locations";

  constructor(private http : Http) { }

  getLocaties() {
    var headers = new Headers();
    const result = this.http.get(this.LOCATIONS_URL, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  getLocatie(locatieid: number){
    var headers = new Headers();
    const result = this.http.get(this.LOCATIONS_URL+"/"+locatieid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }
}
