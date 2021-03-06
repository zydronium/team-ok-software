import { Component, OnInit } from '@angular/core';
import {LocatiesService} from "../../services/locaties.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-locaties',
  templateUrl: './locaties.component.html',
  styleUrls: ['./locaties.component.css']
})
export class LocatiesComponent implements OnInit {
   locaties : any = [];
   loading : boolean = true;

   constructor(private locatiesService : LocatiesService, private router: Router) { }

  ngOnInit() {
    this.locatiesService.getLocaties().subscribe(result => this.processResult(result));
  }

  processResult(result : any){
    this.locaties = result
    this.loading = false;
  }

  openLocatie(locatie){
      this.router.navigate(['/locaties/'+ locatie.id]);
  }
}
