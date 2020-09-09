import { Component, OnInit } from '@angular/core';

import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-landing-page',
  templateUrl: './admin-landing-page.component.html',
  styleUrls: ['./admin-landing-page.component.css']
})
export class AdminLandingPageComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  public adminUploadFile()
  {
    this.router.navigateByUrl("adminlandingpage/adminuploadfile");
  }

  public adminManageExchange()
  {
    this.router.navigateByUrl("adminlandingpage/adminmanageexchanges");
  }

  public adminManageCompany()
  {
    this.router.navigateByUrl("adminlandingpage/adminmanagecompany");
  }

  public adminManageIPO()
  {
    this.router.navigateByUrl("adminlandingpage/adminmanageipo");
  }

  public adminManageSector()
  {
    this.router.navigateByUrl("adminlandingpage/adminmanagesector");
  }


  public Logoff()
  {
    localStorage.clear();
    this.router.navigateByUrl("");
  }



}
