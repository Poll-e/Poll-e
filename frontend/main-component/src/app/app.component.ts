import { Component } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NameEditorComponent } from './name-editor/name-editor.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private modalService: NgbModal) {}

  title = 'main-component';
  savedName = '';
  name = `Welcome, ${this.savedName}`;

  ngOnInit() {
    this.openDialog();
  }
  openDialog() {
    this.modalService
      .open(NameEditorComponent, {
        size: 'sm',
        centered: true,
      })
      .result.then((result) => (console.log({result})));
  }
}
