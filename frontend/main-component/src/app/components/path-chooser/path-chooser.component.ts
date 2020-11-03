import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-path-chooser',
  templateUrl: './path-chooser.component.html',
  styleUrls: ['./path-chooser.component.css'],
})
export class PathChooserComponent implements OnInit {
  name = '';
  constructor(private router: Router) {}

  ngOnInit(): void {
    this.name = localStorage.getItem('username');
  }

  chooseNew() {
    this.router.navigate(['polls/create']);
  }
}
