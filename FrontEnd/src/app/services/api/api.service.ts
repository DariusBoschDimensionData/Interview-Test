import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { retry, catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient) { }


  public getHeroes(): Observable<any[]> {
    return this.httpClient.get<any[]>(environment.baseURL + "heroes").pipe(
      retry(1),
      catchError(this.handleError)
    );
  }

  public postEvolve(): Observable<any[]> {
    return this.httpClient.get<any[]>(environment.baseURL + "heroes").pipe(
      retry(1),
      catchError(this.handleError)
    );
  }

  public handleError(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error 
      errorMessage = error.error.message;
    } else {
      // Get server-side error 
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
  }


  
}
