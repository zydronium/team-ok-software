import { Component, OnInit } from '@angular/core';
import {Locatie} from "../../models/Locatie";
import {Verdieping} from "../../models/Verdieping";
import {Werkplek} from "../../models/Werkplek";
import {ActivatedRoute, Router} from "@angular/router";
import {LocatiesService} from "../../services/locaties.service";
import {VerdiepingenService} from "../../services/verdiepingen.service";
import {WerkplekkenService} from "../../services/werkplekken.service";

@Component({
  selector: 'app-werkplek',
  templateUrl: './werkplek.component.html',
  styleUrls: ['./werkplek.component.css']
})
export class WerkplekComponent implements OnInit {
  locatieid: number;
  verdiepingid: number;
  werkplekid: number;
  locatie: any = {};
  verdieping: any = {};
  werkplek: Werkplek;

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
    this.locatiesService.getLocatie(this.locatieid).subscribe(result => this.locatie = result);

    this.verdiepingid = this.route.snapshot.params["verdiepingid"];
    this.verdiepingenService.getVerdieping(this.locatieid, this.verdiepingid).subscribe(result => this.verdieping = result);

    this.werkplekid = this.route.snapshot.params["werkplekid"];
    this.werkplek = this.werkplekkenService.getWerkplek(this.werkplekid);
  }

}
