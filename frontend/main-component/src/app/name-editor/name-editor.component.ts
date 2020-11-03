import {Component, Output} from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-name-editor',
  templateUrl: './name-editor.component.html',
  styleUrls: ['./name-editor.component.css'],
})
export class NameEditorComponent {
  name: string;
  constructor(private modalService: NgbModal, public activeModal: NgbActiveModal) {}

  close() {
    localStorage.setItem("usernam", name);
  }
}
