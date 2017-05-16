import { Component, OnInit } from '@angular/core';
import {WerkplekkenService} from "../../services/werkplekken.service";
import {Werkplek} from "../../models/Werkplek";

@Component({
  selector: 'app-zoek',
  templateUrl: './zoek.component.html',
  styleUrls: ['./zoek.component.css']
})
export class ZoekComponent implements OnInit {

  constructor(private werkplekkenService: WerkplekkenService) { }
  werkplekken: any = [];
  vrijeWerkplekken: any = [];
  result: any = [];
  zitplaatsen: number = 1;
  stopcontacten: number = 1;
  ngOnInit() {
  }

  zoek() {
    this.werkplekken = this.werkplekkenService.getAlleWerkplekken();
    for(var i =0; i < this.werkplekken.length; i++){
      if(this.werkplekken[i].claimed == false){
        this.werkplekken[i].seat = 1;
        this.vrijeWerkplekken.push(this.werkplekken[i]);
      }
    }
    for(var i =0; i < this.vrijeWerkplekken.length; i++){
      if(this.vrijeWerkplekken[i].stop == false){
        this.vrijeWerkplekken.push(this.werkplekken[i]);
      }
    }
    console.log("zoek");
  }
}
