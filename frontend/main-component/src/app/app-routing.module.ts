import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PollCreateComponent} from './components/poll-create/poll-create.component';

const routes: Routes = [
  {path: 'polls/create', component: PollCreateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
