import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  private apiURL = 'http://localhost:7071/api';
  private queryParam = '{ posts }';

  constructor(
    private http: HttpClient) { }

  getPosts(): Observable<any> {
    const url = `${this.apiURL}/get?query=${this.queryParam}`;
    return this.http.get(url);
  }
}
