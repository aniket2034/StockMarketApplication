import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomePageComponent } from './Components/home-page/home-page.component';
import { AdminLoginComponent } from './Components/Admin/admin-login/admin-login.component';
import { AdminLandingPageComponent } from './Components/Admin/admin-landing-page/admin-landing-page.component';
import { AdminManageCompanyComponent } from './Components/Admin/admin-manage-company/admin-manage-company.component';
import { AdminManageExchangeComponent } from './Components/Admin/admin-manage-exchange/admin-manage-exchange.component';
import { AdminManageIPOComponent } from './Components/Admin/admin-manage-ipo/admin-manage-ipo.component';
import { AdminUploadFileComponent } from './Components/Admin/admin-upload-file/admin-upload-file.component';
import { AuthguardGuard } from "./Services/AuthGuard/auth-guard.service"
import { AdminManangeSectorComponent } from './Components/Admin/admin-manange-sector/admin-manange-sector.component';

const routes: Routes = [
  {path:"",component:HomePageComponent},
  {path:"adminlogin", component:AdminLoginComponent},
  {path:"adminlandingpage", component:AdminLandingPageComponent, children:[
    {path:"adminuploadfile", component:AdminUploadFileComponent},
    {path:"adminmanageexchanges", component:AdminManageExchangeComponent},
    {path:"adminmanagecompany", component:AdminManageCompanyComponent},
    {path:"adminmanageipo", component:AdminManageIPOComponent},
    {path:"adminmanagesector", component:AdminManangeSectorComponent}    
  ]} 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
