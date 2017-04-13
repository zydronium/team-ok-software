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
  locatie: Locatie;
    constructor(
    private route: ActivatedRoute,
    private router: Router,
    private locatiesService: LocatiesService
  ) {

  }

  ngOnInit() {
    this.locatieid = this.route.snapshot.params['locatieid'];
    this.locatie = this.locatiesService.getLocatie(this.locatieid);

  }
  bekijkVerdiepingen(){
    this.router.navigate(['/locaties/'+ this.locatie.id + '/verdiepingen'] );
  }
}
