import { Component, Output } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-name-editor',
  templateUrl: './name-editor.component.html',
  styleUrls: ['./name-editor.component.css'],
})
export class NameEditorComponent {
  name: string;
  constructor(public activeModal: NgbActiveModal) {}

  close(setName: string): void {
    sessionStorage.setItem('username', setName);
    this.activeModal.close(setName);
  }
}
