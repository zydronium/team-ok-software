import { Component, OnInit } from '@angular/core';
import {LocatiesService} from "../../services/locaties.service";
import {LocatieService} from "../../services/locatie.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-locaties',
  templateUrl: './locaties.component.html',
  styleUrls: ['./locaties.component.css']
})
export class LocatiesComponent implements OnInit {
locaties: any;
   constructor(private locatiesService : LocatiesService, private locatieService: LocatieService
              ,private router: Router) { }

  ngOnInit() {
    this.locaties = this.locatiesService.getLocaties();
  }
openLocatie(locatie){
    this.locatieService.setLocatie(locatie);
    this.router.navigate(['/locaties/'+ locatie.id]);
}
}
