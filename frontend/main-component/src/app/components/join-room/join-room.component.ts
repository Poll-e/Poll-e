import { Component, OnInit } from '@angular/core';
import {CommonModule} from '@angular/common';
import {Router} from '@angular/router';
import {FormsModule} from '@angular/forms';
import {PollService} from '../../services/poll.service';

@Component({
  selector: 'app-join-room',
  templateUrl: './join-room.component.html',
  styleUrls: ['./join-room.component.css'],
})
export class JoinRoomComponent implements OnInit {
  code = '';
  error = false;

  constructor(private router: Router, private pollService: PollService) {}

  ngOnInit(): void {}

  gotoRoom(): void {  
    this.pollService
      .getPoll(this.code)
      .subscribe(_ => this.router.navigate(['polls', this.code]),
          error => this.error = true);
  }
}
