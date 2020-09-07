import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomePageComponent } from './Components/home-page/home-page.component';
import { AdminLoginComponent } from './Components/Admin/admin-login/admin-login.component';
import { AdminLandingPageComponent } from './Components/Admin/admin-landing-page/admin-landing-page.component';
import { AdminManageCompanyComponent } from './Components/Admin/admin-manage-company/admin-manage-company.component';
import { AdminManageExchangeComponent } from './Components/Admin/admin-manage-exchange/admin-manage-exchange.component';
import { AdminManageIPOComponent } from './Components/Admin/admin-manage-ipo/admin-manage-ipo.component';
import { AdminUploadFileComponent } from './Components/Admin/admin-upload-file/admin-upload-file.component';


const routes: Routes = [
  {path:"",component:HomePageComponent},
  {path:"adminlogin", component:AdminLoginComponent},          
  {path:"adminlandingpage", component:AdminLandingPageComponent}, 
  {path:"adminlandingpage/adminmanagecompany", component:AdminManageCompanyComponent},
  {path:"adminlandingpage/adminmanageexchanges", component:AdminManageExchangeComponent}, 
  {path:"adminlandingpage/adminmanageipo", component:AdminManageIPOComponent}, 
  {path:"adminlandingpage/adminuploadfile", component:AdminUploadFileComponent}  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
