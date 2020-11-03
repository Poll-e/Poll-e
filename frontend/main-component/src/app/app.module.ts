import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PollCreateComponent } from './components/poll-create/poll-create.component';
import { NameEditorComponent } from './name-editor/name-editor.component';
import {HttpClientModule} from '@angular/common/http';
import { PollRoomComponent } from './components/poll-room/poll-room.component';

@NgModule({
  declarations: [
    AppComponent,
    NameEditorComponent
    PollCreateComponent,
    PollRoomComponent
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
