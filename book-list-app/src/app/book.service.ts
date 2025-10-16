import { Injectable } from '@angular/core';
import { Book } from './book';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl = 'http://localhost:5099'; // URL to web api
  
  constructor(private http : HttpClient) { }
    getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl + '/api/books');
  }
}
