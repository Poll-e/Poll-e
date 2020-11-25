import { Component } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NameEditorComponent } from './components/name-editor/name-editor.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private modalService: NgbModal, private router: Router) {}

  title = 'main-component';

  ngOnInit() {
    if (!sessionStorage.getItem('username')) {
      this.openDialog();
    }
  }

  openDialog() {
    this.modalService
      .open(NameEditorComponent, {
        size: 'sm',
        centered: true,
      })
      .result.then(() => {
        this.router.navigate(['choose']);
      });
  }
}
