import { Component, OnInit } from '@angular/core';
import {Locatie} from "../../models/Locatie";
import {LocatiesService} from "../../services/locaties.service";
import {Router, ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-locatie',
  templateUrl: './locatie.component.html',
  styleUrls: ['./locatie.component.css']
})
export class LocatieComponent implements OnInit {
  locatieid: number;
  locatie: any = {};
  cafetaria : any = {};
  parkeermogelijkheden : any = {};

    constructor(
    private route: ActivatedRoute,
    private router: Router,
    private locatiesService: LocatiesService
  ) {

  }

  ngOnInit() {
    this.locatieid = this.route.snapshot.params['locatieid'];
    this.locatiesService.getLocatie(this.locatieid).subscribe(result => this.loadLocation(result));
  }

  loadLocation(result){
      this.locatie = result;
      this.parkeermogelijkheden = this.getFacility('Parkeermogelijkheden');
      this.cafetaria = this.getFacility('Cafetaria');
  }

  bekijkVerdiepingen(){
    this.router.navigate(['/locaties/'+ this.locatie.id + '/verdiepingen'] );
  }

  openOV(){
    var newWindow = window.open('http://9292.nl/');
  }

  getFacility(name : string) : any{
    let facilities =  this.locatie.facilities.filter(facility => facility.name == name);

    if(facilities.length == 1){
      return facilities[0];
    }
    else{
      return null;
    }
  }
}
