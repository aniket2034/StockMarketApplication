import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Company} from './../../Models/CompanyService/company';
import {IpoDetails} from './../../Models/CompanyService/ipo-details'
import {Sector} from './../../Models/CompanyService/sector'
import {StockExchange} from './../../Models/CompanyService/stock-exchange'



@Injectable({
  providedIn: 'root'
})
export class CompanyServiceService {

  path:string = "https://localhost:44392";

  constructor(private client: HttpClient) { }

  public listOfCompanies() : Observable<Company[]>
  {
    return this.client.get<Company[]>(this.path+"/AdminService/Company/getAllCompanies");
  }

  public listOfStockExchanges():Observable<StockExchange[]>
  {
    return this.client.get<StockExchange[]>(this.path+"/UserService/StockExchange/getAllStockExchanges")
  }

  public listOfSectors():Observable<Sector[]>
  {
    return this.client.get<Sector[]>(this.path+"/UserService/Sector/getAllSectors");
  }


  public AddCompany(company:Company):Observable<Company>
  {
    return this.client.post<Company>(this.path+"/AdminService/Company/addCompany",company);
  }

  public AddIPO(ipo:IpoDetails):Observable<any>
  {
    return this.client.post<IpoDetails>(this.path+"/AdminService/IPODetails",ipo);
  }

  public updateCompany(company:Company):Observable<any>
  {
    return this.client.put<Company>(this.path+"/AdminService/Company/updateCompany/"+company.id,company);
  }

  public deleteCompany(companyId:number):Observable<any>
  {
    return this.client.delete(this.path+"/AdminService/Company/deleteCompany/"+companyId);
  }

 
}
