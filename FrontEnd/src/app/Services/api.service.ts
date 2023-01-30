import { Injectable, ViewChild } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  newHeroList : any;
 
  // 1.create new service called 'api'

  constructor(private http: HttpClient) { }

  //get method to retrieve information from the api
  //2. add 1 method to service to get the contacts from the api located at 'http://localhost:4201/heroes'
  getHeroes(): Observable<any> {
    return this.http.get('http://localhost:4201/api/heroes');
  }

  //when the button is clicked, it should post the hero name and action to the relevant endpoint
  //Post method to API to evolve Hero
  evolve(name: string, action: string){ 
   return this.http.post('http://localhost:4201/api/heroes', {Hero: name, action: action});   
  }
}
