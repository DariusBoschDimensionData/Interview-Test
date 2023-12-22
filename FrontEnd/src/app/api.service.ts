import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Hero } from 'src/app/hero';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) {
  }

  
  getContacts(): Observable<Hero> {
    return this.http.get<Hero>('http://localhost/4201/api/heroes');
  }

  postHero(heroName: string, action: string): Observable < Hero > {
    const body = { name: heroName, action: action };
    return this.http.post<Hero>('http://localhost/4201/api/heroes/evolve', body);
  }
  
}
