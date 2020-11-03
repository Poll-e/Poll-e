import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { JoinRoomComponent } from './components/join-room/join-room.component';
import { PathChooserComponent } from './components/path-chooser/path-chooser.component';
import {PollCreateComponent} from './components/poll-create/poll-create.component';
import {PollRoomComponent} from './components/poll-room/poll-room.component';

const routes: Routes = [
  {path: '', component: PathChooserComponent},
  {path: 'join', component: JoinRoomComponent},
  {path: 'polls/create', component: PollCreateComponent},
  {path: 'polls/:code', component: PollRoomComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
