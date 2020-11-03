import { Component, OnInit } from '@angular/core';
import {CommonModule} from '@angular/common';
import {Router} from '@angular/router';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-join-room',
  templateUrl: './join-room.component.html',
  styleUrls: ['./join-room.component.css'],
})
export class JoinRoomComponent implements OnInit {
  code: string;

  constructor(private router: Router) {}

  ngOnInit(): void {}

  gotoRoom(): void {
    console.log(this.code);
    this.router.navigate(['polls', this.code]);
  }
}
