import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {PollService} from '../../services/poll.service';
import {PollGetResponse} from '../../DTOs/poll-get-response';
import {VoteService} from '../../services/vote.service';
import {Observable} from 'rxjs';
import {VoteResult} from '../../DTOs/vote-result';

@Component({
  selector: 'app-poll-details',
  templateUrl: './poll-details.component.html',
  styleUrls: ['./poll-details.component.css']
})
export class PollDetailsComponent implements OnInit {
  constructor(route: ActivatedRoute, private voteService: VoteService) {
    route.params.subscribe(x => {
      this.code = x.code;
      this.result = this.voteService.getVotes(this.code);
    });
  }
  code: string;
  result: Observable<Array<VoteResult>>;


  ngOnInit(): void {
  }

  onUploaded = () => {
    this.result = this.voteService.getVotes(this.code);
  }

}
