import { Injectable } from '@angular/core';
import {Locatie} from "../models/Locatie";

@Injectable()
export class LocatieService {

  constructor() { }

  locatie = {};

  setLocatie(currentLocatie: any) {
    this.locatie = currentLocatie;
  }

  getLocatie() {
    return this.locatie;
  }
}
