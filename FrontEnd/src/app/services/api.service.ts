import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hero } from '../models/hero';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private apiUrl = 'http://localhost/4201'

  constructor(private http: HttpClient) { 
  }

 getContacts(): Observable<Hero[]>{
    return this.http.get<Hero[]>(`${this.apiUrl}/heroes`);
 }

 postHero(heroName: string, action: string): Observable<Hero> {
  const body = { name: heroName, action: action };
  return this.http.post<Hero>(`${this.apiUrl}/evolve`, body);
}

}
