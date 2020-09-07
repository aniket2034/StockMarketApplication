import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {User} from './../../Models/AccountService/user';
import {TokenDetail} from './../../Models/AccountService/token-detail';
import {InputData} from './../../Models/AccountService/input-data';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {
  path: string = "https://localhost:44392";
  constructor(private http: HttpClient) {
   }

   SignIn(InputData): Observable<TokenDetail> 
  {
    return this.http.post<TokenDetail>(this.path+"/AuthService/login",InputData);
  }

  Signup(item: User): Observable<User>
  {
    return this.http.post<User>(this.path+"/AuthService/signup",item);
  }




}
