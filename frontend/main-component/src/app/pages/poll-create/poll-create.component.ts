import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {CategoryService} from '../../services/category.service';
import {Observable} from 'rxjs';
import {debounceTime, distinctUntilChanged, map} from 'rxjs/operators';
import {Router} from '@angular/router';
import {PollService} from '../../services/poll.service';

@Component({
  selector: 'app-poll-create',
  templateUrl: './poll-create.component.html',
  styleUrls: ['./poll-create.component.css']
})
export class PollCreateComponent implements OnInit {
  title: string;
  category: string;
  categories: string[];

  searchCategories = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map((term: string ) =>
        term.length < 2 ? []
        : this.categories
          .filter(v => v.toLowerCase().indexOf(term.toLowerCase()) > -1)
          .slice(0, 10)))

  constructor(private categoryService: CategoryService, private pollService: PollService, private router: Router) {
    categoryService.getCategories().subscribe(x => this.categories = x);
  }

  ngOnInit(): void {
  }

  createPoll(): void {
    this.pollService.createPoll(this.title, this.category)
      .subscribe(code => this.router.navigate(['polls', code]));
  }
}
