import { Component, OnInit } from '@angular/core';
import {LocatiesService} from "../../services/locaties.service";

@Component({
  selector: 'app-locaties',
  templateUrl: './locaties.component.html',
  styleUrls: ['./locaties.component.css']
})
export class LocatiesComponent implements OnInit {
locaties: any;
  constructor(private locatiesService : LocatiesService) { }

  ngOnInit() {
    this.locaties = this.locatiesService.getLocaties();
  }

}
