import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {PollOption} from '../DTOs/poll-option';

@Injectable({
  providedIn: 'root'
})
export class OptionService {

  constructor(private http: HttpClient) { }

  createOption(code: string, text: string, formData: FormData): Observable<any> {
    return this.http.post(`/api/polls/${code}/options`, formData, {
      reportProgress: true,
      observe: 'events',
      params: {text}});

  }

  getOptions(code: string): Observable<PollOption[]> {
    return this.http.get<PollOption[]>(`/api/polls/${code}/options`);
  }
}
