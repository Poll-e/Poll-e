import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PollCreateComponent } from './pages/poll-create/poll-create.component';
import { NameEditorComponent } from './components/name-editor/name-editor.component';
import {HttpClientModule} from '@angular/common/http';
import { PathChooserComponent } from './pages/path-chooser/path-chooser.component';
import { JoinRoomComponent } from './pages/join-room/join-room.component';
import { PollRoomComponent } from './pages/poll-room/poll-room.component';
import { AddOptionComponent } from './components/add-option/add-option.component';
import { PollOptionResultListComponent } from './components/poll-option-result-list/poll-option-result-list.component';
import { VoteComponent } from './pages/vote/vote.component';
import { PollDetailsComponent } from './pages/poll-details/poll-details.component';

@NgModule({
  declarations: [
    AppComponent,
    NameEditorComponent,
    PollCreateComponent,
    PollRoomComponent,
    NameEditorComponent,
    PathChooserComponent,
    JoinRoomComponent,
    AddOptionComponent,
    PollOptionResultListComponent,
    VoteComponent,
    PollDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    HttpClientModule
  ],
  entryComponents:[],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
