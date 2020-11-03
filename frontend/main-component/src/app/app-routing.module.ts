import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { JoinRoomComponent } from './components/join-room/join-room.component';
import { PathChooserComponent } from './components/path-chooser/path-chooser.component';
import {PollCreateComponent} from './components/poll-create/poll-create.component';

const routes: Routes = [
  {path: 'polls/create', component: PollCreateComponent},
  {path: 'choose', component: PathChooserComponent},
  {path: 'join', component: JoinRoomComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
