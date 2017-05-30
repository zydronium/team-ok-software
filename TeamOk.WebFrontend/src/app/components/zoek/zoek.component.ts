import { Component, OnInit } from '@angular/core';
import {WerkplekkenService} from "../../services/werkplekken.service";
import {Werkplek} from "../../models/Werkplek";
import {Router} from "@angular/router";

@Component({
  selector: 'app-zoek',
  templateUrl: './zoek.component.html',
  styleUrls: ['./zoek.component.css']
})
export class ZoekComponent implements OnInit {

  constructor(private werkplekkenService: WerkplekkenService, private router: Router) { }
  werkplekken: any = [];
  vrijeWerkplekken: any = [];
  result: any = [];
  zitplaatsen: number = 1;
  stopcontacten: number = 1;

  ngOnInit() {
    this.werkplekkenService.getAlleWerkplekken().subscribe(result => this.getAlleVrijeWerkplekken(result));
  }

  getZitplaatsen(facilities : any) : any{
    let filtered =  facilities.filter(facility => facility.name == 'Zitplaatsen');

    if(filtered.length == 1){
      return filtered[0].value;
    }
    else{
      return "onbekend aantal";
    }
  }

  getStopcontacten(facilities : any) : any{
    let filtered =  facilities.filter(facility => facility.name == 'Stopcontacten');

    if(filtered.length == 1){
      return filtered[0].value;
    }
    else{
      return "onbekend aantal";
    }
  }

  openWerkplek(werkplekid: number, floorId : number, locationId : number){
    this.router.navigate(["/locaties/"+ locationId+"/verdiepingen/"+floorId+"/"+werkplekid]);
  }

  getAlleVrijeWerkplekken(result: any){
    for(var i =0; i < result.length; i++){
      if(result[i].claimed == false){
        this.result.push(result[i]);
      }
    }
  }

  zoek() {
    this.result = [];
    this.werkplekken = [];
    this.vrijeWerkplekken = [];
    this.werkplekkenService.getAlleWerkplekken().subscribe(result => this.processData(result));

  //   for(var i =0; i < this.werkplekken.length; i++){
  //     if(this.werkplekken[i].claimed == false){
  //       this.werkplekken[i].seat = this.getZitplaatsen(this.werkplekken[i].facilities);
  //       this.werkplekken[i].outlet = this.getStopcontacten(this.werkplekken[i].facilities);
  //       this.vrijeWerkplekken.push(this.werkplekken[i]);
  //     }
  //   }
  //   for(var i =0; i < this.vrijeWerkplekken.length; i++){
  //     if(this.vrijeWerkplekken[i].outlet == this.stopcontacten || this.vrijeWerkplekken[i].seat == this.zitplaatsen ){
  //       this.result.push(this.vrijeWerkplekken[i]);
  //     }
  //   }
  //   console.log("zoek");
  // }
}

  processData(result: any){
    this.werkplekken = result;
  console.log(result)
    for(var i =0; i < this.werkplekken.length; i++){
      if(this.werkplekken[i].claimed == false){
        this.werkplekken[i].seat = this.getZitplaatsen(this.werkplekken[i].facilities);
        this.werkplekken[i].outlet = this.getStopcontacten(this.werkplekken[i].facilities);
        this.vrijeWerkplekken.push(this.werkplekken[i]);
      }
    }
    for(var i =0; i < this.vrijeWerkplekken.length; i++){
      if(this.vrijeWerkplekken[i].outlet >= this.stopcontacten && this.vrijeWerkplekken[i].seat >= this.zitplaatsen ){
        this.result.push(this.vrijeWerkplekken[i]);
      }
    }
    console.log("zoek");
  }
}
