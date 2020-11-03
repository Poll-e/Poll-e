import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PathChooserComponent } from './components/path-chooser/path-chooser.component';
import {PollCreateComponent} from './components/poll-create/poll-create.component';

const routes: Routes = [
  {path: 'polls/create', component: PollCreateComponent},
  {path: 'choose', component: PathChooserComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
