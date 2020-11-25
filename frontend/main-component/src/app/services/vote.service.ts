import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {VoteResult} from '../DTOs/vote-result';
import {VoteRequest} from '../DTOs/vote-request';

@Injectable({
  providedIn: 'root'
})
export class VoteService {
  constructor(private http: HttpClient) { }
  getVotes(code: string): Observable<Array<VoteResult>>{
    return this.http.get<Array<VoteResult>>('/api/votes', {params: {code}});
  }

  vote(code: string, optionId: number, likes: boolean): Observable<any>{
    const vote: VoteRequest = {
      code,
      option_id: optionId,
      likes,
      nickname: ''
    };
    return this.http.post('api/votes', vote);
  }

}
