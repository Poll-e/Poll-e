import {Component, Input, OnInit} from '@angular/core';
import {VoteService} from '../../services/vote.service';
import {Observable} from 'rxjs';
import {VoteResult} from '../../DTOs/vote-result';

@Component({
  selector: 'app-poll-option-result-list',
  templateUrl: './poll-option-result-list.component.html',
  styleUrls: ['./poll-option-result-list.component.css']
})
export class PollOptionResultListComponent implements OnInit {

  @Input()
  result: Observable<Array<VoteResult>>;

  constructor(){}

  ngOnInit(): void {
  }
}
