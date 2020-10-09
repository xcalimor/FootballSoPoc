import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TeamListComponent } from './team-list/team-list.component';
import { TeamComponent } from './team/team.component';

const routes: Routes = [
  {path: 'teams', component: TeamListComponent},
  {path: 'teams/:id', component: TeamComponent},
  {path: '', component: TeamListComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
