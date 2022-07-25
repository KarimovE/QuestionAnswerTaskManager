import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Data } from '../Data';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private apiUrl = 'https://localhost:7297/Info';

  constructor(private http: HttpClient) {} 

    getData(): Observable<Data> {
      return this.http.get<Data>(this.apiUrl);
      
    }
  }
