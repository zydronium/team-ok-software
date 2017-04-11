import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {HomeComponent} from "./components/home/home.component";


export const router: Routes = [
  { path: '', component: HomeComponent}
  // { path: '', redirectTo: 'login', pathMatch: 'full' },
  // { path: 'login', component: LoginComponent },
  // { path: 'signup', component: SignupComponent },
  // { path: 'login-email', component: EmailComponent },
  // { path: 'members', component: MembersComponent, canActivate: [AuthGuard] },
  // { path: 'projects', component: ProjectlistComponent, canActivate: [AuthGuard]},
  // { path: 'project/:id', component: ProjectComponent, canActivate: [AuthGuard]},
  // { path: 'template/:projectid/:templateid', component: TemplateDetailComponent, canActivate: [AuthGuard]},
  // { path: 'template-new/:projectid', component: TemplateNewComponent, canActivate: [AuthGuard]},
  // { path: 'template-edit/:projectid/:templateid', component: TemplateEditComponent, canActivate: [AuthGuard]},
  // { path: 'person-new/:projectid/:templateid', component: PersonNewComponent, canActivate: [AuthGuard]},
  // { path: 'person-edit/:projectid/:templateid/:personid', component: PersonDetailComponent, canActivate: [AuthGuard]}
]

export const routes: ModuleWithProviders = RouterModule.forRoot(router);
