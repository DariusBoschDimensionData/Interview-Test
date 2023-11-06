import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiServices {
  private apiUrl = 'http://localhost:4201/heroes';
  private getHeroByID = 'http://localhost:4201/heroes/${id}';
  constructor(private http: HttpClient) {}

  getHeroes() {
    return this.http.get(this.apiUrl);
  }
  getHeroesbyid() {
    
    return this.http.get(this.getHeroByID);
  }
  
}