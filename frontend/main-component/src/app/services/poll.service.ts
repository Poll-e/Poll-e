import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {PollCreateResponse} from '../DTOs/poll-create-response';
import {map} from 'rxjs/operators';
import {PollCreateRequest} from '../DTOs/poll-create-request';
import {PollGetResponse} from '../DTOs/poll-get-response';

@Injectable({
  providedIn: 'root'
})
export class PollService {
  constructor(private http: HttpClient) { }

  createPoll(title: string, category: string): Observable<string>{
    return this.http.post<PollCreateResponse>('/api/polls', {title: title, category: category} as PollCreateRequest)
      .pipe(map(x => x.code));
  }

  getPoll(code: string): Observable<PollGetResponse> {
    return this.http.get<PollGetResponse>(`/api/polls/${code}`);
  }
}
