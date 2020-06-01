import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BlogService {
  private apiURL = 'http://localhost:7071/api';
  private queryParam = '{ blogs { posts } }';

  constructor(
    private http: HttpClient) { }

  getBlogs(): Observable<any> {
    const url = `${this.apiURL}/get?query=${this.queryParam}`;
    return this.http.get(url);
  }
}
