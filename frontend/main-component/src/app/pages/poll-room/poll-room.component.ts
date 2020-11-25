import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Route, Router} from '@angular/router';
import {PollGetResponse} from '../../DTOs/poll-get-response';
import {PollService} from '../../services/poll.service';
import {CommonModule} from '@angular/common';

@Component({
  selector: 'app-poll-room',
  templateUrl: './poll-room.component.html',
  styleUrls: ['./poll-room.component.css']
})
export class PollRoomComponent implements OnInit {
  constructor(route: ActivatedRoute, private pollService: PollService) {
    route.params.subscribe(x => pollService.getPoll(x.code).subscribe(y => this.room = y));
  }

  room: PollGetResponse;

  ngOnInit(): void {
  }
}
