import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { InputData } from './../../../Models/AccountService/input-data';
import { AuthServiceService } from './../../../Services/AuthService/auth-service.service';


@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {

  constructor(private service:AuthServiceService, private router: Router) {
    this.input=new InputData();
   }
  input: InputData;
  errMsg: string;
  ngOnInit(): void {
  }  
  SignIn()
  { console.log(this.input);
    this.service.SignIn(this.input).subscribe(res=>{
      console.log(res);
      console.log(res.usertype);
      console.log(res.token);
      if(res.token==null || res.token=="") {this.errMsg="Wrong username or password";}
      else if((res.usertype)!=1) {this.errMsg="Wrong username or password";}
      else
      {
        localStorage.setItem("token", res.token);
        console.log(res);
        this.router.navigateByUrl("adminlandingpage");
      }

    })
  }




}
