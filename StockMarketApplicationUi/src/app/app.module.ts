import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { AdminLoginComponent } from './Components/Admin/admin-login/admin-login.component';
import { AdminLandingPageComponent } from './Components/Admin/admin-landing-page/admin-landing-page.component';
import { AdminManageCompanyComponent } from './Components/Admin/admin-manage-company/admin-manage-company.component';
import { AdminManageExchangeComponent } from './Components/Admin/admin-manage-exchange/admin-manage-exchange.component';
import { AdminManageIPOComponent } from './Components/Admin/admin-manage-ipo/admin-manage-ipo.component';
import { AdminUploadFileComponent } from './Components/Admin/admin-upload-file/admin-upload-file.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    AdminLoginComponent,
    AdminLandingPageComponent,
    AdminManageCompanyComponent,
    AdminManageExchangeComponent,
    AdminManageIPOComponent,
    AdminUploadFileComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
