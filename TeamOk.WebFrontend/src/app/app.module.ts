import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { routes } from './app.routes';
import {RouterModule} from "@angular/router";
import { HomeComponent } from './components/home/home.component';
import {APP_BASE_HREF} from "@angular/common";
import { LocatiesComponent } from './components/locaties/locaties.component';
import { LocatieComponent } from './components/locatie/locatie.component';
import { VerdiepingenComponent } from './components/verdiepingen/verdiepingen.component';
import { VerdiepingComponent } from './components/verdieping/verdieping.component';
import { WerkplekComponent } from './components/werkplek/werkplek.component';
import {AppComponent} from "./app.component";
import {LocatiesService} from "./services/locaties.service";
import {VerdiepingenService} from "./services/verdiepingen.service";

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LocatiesComponent,
    LocatieComponent,
    VerdiepingenComponent,
    VerdiepingComponent,
    WerkplekComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    routes,
    RouterModule
  ],
  providers: [{provide: APP_BASE_HREF, useValue : '/' }, LocatiesService, VerdiepingenService],
  bootstrap: [AppComponent]
})
export class AppModule { }
