import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {HomeComponent} from "./components/home/home.component";
import {LocatiesComponent} from "./components/locaties/locaties.component";
import {LocatieComponent} from "./components/locatie/locatie.component";
import {VerdiepingenComponent} from "./components/verdiepingen/verdiepingen.component";
import {VerdiepingComponent} from "./components/verdieping/verdieping.component";
import {WerkplekComponent} from "./components/werkplek/werkplek.component";


export const router: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'locaties', component: LocatiesComponent},
  { path: 'locaties/:locatieid', component: LocatieComponent},
  { path: 'locaties/:locatieid/verdiepingen', component: VerdiepingenComponent},
  { path: 'locaties/:locatieid/verdiepingen/:verdiepingid', component: VerdiepingComponent},
  { path: 'locaties/:locatieid/verdiepingen/:verdiepingid/:werkplekid', component: WerkplekComponent}
]

export const routes: ModuleWithProviders = RouterModule.forRoot(router);
