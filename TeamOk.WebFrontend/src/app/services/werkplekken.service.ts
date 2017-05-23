import { Injectable } from '@angular/core';
import {Http, Headers} from "@angular/http";

@Injectable()
export class WerkplekkenService {

  private WORKSPACE_URL = "https://backend.werkplek.123apps.net/api/Workspaces";
  private NOTIFICATION_URL = "https://backend.werkplek.123apps.net/api/Notifications";

  constructor(private http : Http) { }

  getWerkplekken(verdiepingid: number) : any {
    var headers = new Headers();
    const result = this.http.get(this.WORKSPACE_URL+"/"+verdiepingid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  getWerkplek(verdiepingid: number, werkplekid: number) : any {
    var headers = new Headers();
    const result = this.http.get(this.WORKSPACE_URL+"/"+verdiepingid+"/"+werkplekid, {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  getAlleWerkplekken() : any {
    var headers = new Headers();
    const result = this.http.get(this.WORKSPACE_URL+"/all", {headers});
    const transformedResult = result.map(result => result.json());
    return transformedResult;
  }

  notifyWerkplek(werkplekid: number, claimed: boolean):any{
    var headers = new Headers();
    return this.http.get(this.NOTIFICATION_URL+"/"+werkplekid+"/"+claimed, {headers});
  }
}
