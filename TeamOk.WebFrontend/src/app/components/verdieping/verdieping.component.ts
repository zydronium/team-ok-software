import { Component, OnInit } from '@angular/core';
import {Locatie} from "../../models/Locatie";
import {Verdieping} from "../../models/Verdieping";
import {ActivatedRoute, Router} from "@angular/router";
import {LocatiesService} from "../../services/locaties.service";
import {VerdiepingenService} from "../../services/verdiepingen.service";
import {WerkplekkenService} from "../../services/werkplekken.service";
import {Werkplek} from "../../models/Werkplek";

@Component({
  selector: 'app-verdieping',
  templateUrl: './verdieping.component.html',
  styleUrls: ['./verdieping.component.css']
})
export class VerdiepingComponent implements OnInit {
  locatieid: number;
  verdiepingid: number;
  locatie: Locatie;
  verdieping: Verdieping;
  werkplekken: Array<Werkplek> = [];
  werkplekkenSelectie: Array<Werkplek> = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private locatiesService: LocatiesService,
    private verdiepingenService : VerdiepingenService,
    private werkplekkenService: WerkplekkenService
  ) {

  }

  ngOnInit() {
    this.locatieid = this.route.snapshot.params['locatieid'];
    this.locatie = this.locatiesService.getLocatie(this.locatieid);

    this.verdiepingid = this.route.snapshot.params["verdiepingid"];
    this.verdieping = this.verdiepingenService.getVerdieping(this.verdiepingid);

    this.werkplekken = this.werkplekkenService.getWerkplekken(this.verdiepingid);
    this.werkplekkenSelectie = this.werkplekken;
  }

  openWerkplek(werkplekid: number){
    this.router.navigate(["/locaties/"+ this.locatie.id+"/verdiepingen/"+this.verdieping.id+"/"+werkplekid]);
  }

  changeFilter(filter : string){
    if(filter == "alle"){
      this.werkplekkenSelectie = this.werkplekken;
    }
    else if(filter == "vrij"){
      this.werkplekkenSelectie = this.werkplekken.filter(werkplek => !werkplek.bezet);
    }
  }
}
