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
  locatie: any = {};
  verdiepingen: any = [];
  loading : boolean = true;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private locatiesService: LocatiesService,
    private verdiepingenService : VerdiepingenService
  ) {

  }

  ngOnInit() {
    this.locatieid = this.route.snapshot.params['locatieid'];

    this.locatiesService.getLocatie(this.locatieid).subscribe(result => this.locatie = result);
    this.verdiepingenService.getVerdiepingen(this.locatieid).subscribe(result => this.processVerdiepingen(result));
  }

  processVerdiepingen(result : any){
    this.verdiepingen = result;
    this.loading = false;
  }

  openVerdieping(verdiepingid: number){
    this.router.navigate(["/locaties/"+ this.locatie.id+"/verdiepingen/"+verdiepingid]);
  }
}
