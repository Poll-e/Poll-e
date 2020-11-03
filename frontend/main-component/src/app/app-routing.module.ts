import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PollCreateComponent} from './components/poll-create/poll-create.component';
import {PollRoomComponent} from './components/poll-room/poll-room.component';

const routes: Routes = [
  {path: 'polls/create', component: PollCreateComponent},
  {path: 'polls/:id', component: PollRoomComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
