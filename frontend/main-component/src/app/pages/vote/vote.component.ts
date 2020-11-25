import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {VoteService} from '../../services/vote.service';
import {OptionService} from '../../services/option.service';
import {PollOption} from '../../DTOs/poll-option';

@Component({
  selector: 'app-vote',
  templateUrl: './vote.component.html',
  styleUrls: ['./vote.component.css']
})
export class VoteComponent implements OnInit {
  code: string;
  currentOption: PollOption;
  freeze = false;
  private options: PollOption[];

  constructor(private route: ActivatedRoute, private optionService: OptionService, private voteService: VoteService, private router: Router){
    route.parent.params.subscribe(x => {
      this.code = x.code;
      optionService.getOptions(this.code).subscribe(y => this.setUp(y));
    });
  }
  ngOnInit(): void {
  }
  setUp(options: PollOption[]): void{
    this.options = options;
    this.next();
  }
  next(): void{
    if (this.options.length < 1){
      this.router.navigate([`../../${this.code}`], {relativeTo: this.route}).then();
      return;
    }
    this.currentOption = this.options.pop();
    this.freeze = false;
  }
  like(likes: boolean): void{
    this.freeze = true;
    this.voteService.vote(this.code, this.currentOption.id, likes)
      .subscribe(_ => this.next());
  }

}
