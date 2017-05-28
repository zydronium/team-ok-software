import { Component, OnInit } from '@angular/core';
import {WerkplekkenService} from "../../services/werkplekken.service";
import {Werkplek} from "../../models/Werkplek";
import {Router} from "@angular/router";
import {LocatiesService} from "../../services/locaties.service";

@Component({
  selector: 'app-zoek',
  templateUrl: './zoek.component.html',
  styleUrls: ['./zoek.component.css']
})
export class ZoekComponent implements OnInit {

  constructor(private werkplekkenService: WerkplekkenService, private locatiesService : LocatiesService, private router: Router) { }
  werkplekken: any = [];
  vrijeWerkplekken: any = [];
  result: any = [];
  zitplaatsen: number = 1;
  stopcontacten: number = 1;

  dropdownList = [];
  selectedItems = [];
  dropdownSettings = {};

  ngOnInit() {
    this.werkplekkenService.getAlleWerkplekken().subscribe(result => this.getAlleVrijeWerkplekken(result));
    this.locatiesService.getLocaties().subscribe(result => this.loadLocations(result));

    this.dropdownSettings = {
      singleSelection: false,
      text:"Selecteer gebouwen",
      selectAllText:'Selecteer alle',
      unSelectAllText:'Selectie wissen',
      enableSearchFilter: false,
      badgeShowLimit: 3
    };
  }

  loadLocations(result: any){
    this.dropdownList = [];
    for(var i = 0; i < result.length; i++){
      let currentResult = result[i];
      let location = {id: currentResult.id, itemName: currentResult.name};
      this.dropdownList.push(location);
    }
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
}

  processData(result: any){
    this.werkplekken = result;

    for(var i =0; i < this.werkplekken.length; i++){
      if(this.werkplekken[i].claimed == false){
        this.werkplekken[i].seat = this.getZitplaatsen(this.werkplekken[i].facilities);
        this.werkplekken[i].outlet = this.getStopcontacten(this.werkplekken[i].facilities);

        this.vrijeWerkplekken.push(this.werkplekken[i]);
      }
    }

    for(var i =0; i < this.vrijeWerkplekken.length; i++){
      let werkplek = this.vrijeWerkplekken[i];
      if(this.inSelection(werkplek.floor.locationId) && werkplek.outlet >= this.stopcontacten && werkplek.seat >= this.zitplaatsen ){
        this.result.push(werkplek);
      }
    }
  }

  inSelection(id: number) : boolean{
    let filtered =  this.selectedItems.filter(location => location.id == id);

    if(filtered.length == 1){
      return true;
    }
    else{
      return false;
    }
  }

  onItemSelect(item:any){
    console.log(item);
    console.log(this.selectedItems);
  }
  OnItemDeSelect(item:any){
    console.log(item);
    console.log(this.selectedItems);
  }
  onSelectAll(items: any){
    console.log(items);
  }
  onDeSelectAll(items: any){
    console.log(items);
  }
}
