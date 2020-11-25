import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { JoinRoomComponent } from './pages/join-room/join-room.component';
import { PathChooserComponent } from './pages/path-chooser/path-chooser.component';
import {PollCreateComponent} from './pages/poll-create/poll-create.component';
import {PollRoomComponent} from './pages/poll-room/poll-room.component';
import {PollDetailsComponent} from './pages/poll-details/poll-details.component';
import {VoteComponent} from './pages/vote/vote.component';

const routes: Routes = [
  {path: '', component: PathChooserComponent},
  {path: 'join', component: JoinRoomComponent},
  {path: 'polls/create', component: PollCreateComponent},
  {
    path: 'polls/:code',
    component: PollRoomComponent,
    children: [
      {path: '', component: PollDetailsComponent},
      {path: 'vote', component: VoteComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
