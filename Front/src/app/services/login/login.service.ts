import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private url = `https://localhost:7037/usuario/login`;

  constructor(private http: HttpClient) { }

  login(creadenciales: any): Observable<any> {

    return this.http.post(this.url, creadenciales);

  }

}
