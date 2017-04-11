import { Component, OnInit } from '@angular/core';
import {Router, ActivatedRoute} from "@angular/router";
import {Verdieping} from "../../models/Verdieping";
import {VerdiepingenService} from "../../services/verdiepingen.service";
import {LocatiesService} from "../../services/locaties.service";
import {Locatie} from "../../models/Locatie";

@Component({
  selector: 'app-verdiepingen',
  templateUrl: './verdiepingen.component.html',
  styleUrls: ['./verdiepingen.component.css']
})
export class VerdiepingenComponent implements OnInit {
  locatieid: number;
  locatie: Locatie;
  verdiepingen: Array<Verdieping> = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private locatiesService: LocatiesService,
    private verdiepingenService : VerdiepingenService
  ) {

  }

  ngOnInit() {
    this.locatieid = this.route.snapshot.params['locatieid'];

    this.locatie = this.locatiesService.getLocatie(this.locatieid);
    this.verdiepingen = this.verdiepingenService.getVerdiepingen(this.locatieid);
  }

}
