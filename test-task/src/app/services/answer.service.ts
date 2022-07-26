import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Data, Answer } from '../Data';
import { Observable } from 'rxjs';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root'
})
export class AnswerService {

  private apiUrl = 'https://localhost:7297/Answer';

  constructor(private http: HttpClient) { }


getAnswer(answer: Answer): Observable<Boolean> {
        const newLocal = this.http.post<Boolean>(this.apiUrl, answer, httpOptions);
        return newLocal;
      }
    }
  

