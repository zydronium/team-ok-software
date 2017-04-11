import { Component, OnInit } from '@angular/core';
import {Locatie} from "../../models/Locatie";
import {LocatieService} from "../../services/locatie.service";

@Component({
  selector: 'app-locatie',
  templateUrl: './locatie.component.html',
  styleUrls: ['./locatie.component.css']
})
export class LocatieComponent implements OnInit {
  locatie: any;
  constructor(private locatieService: LocatieService) { }

  ngOnInit() {
  this.locatie = this.locatieService.getLocatie();
  }

}
