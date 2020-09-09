import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StockCompany } from 'src/app/Models/StockCompany/stock-company';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StockCompanyService {

  path:string = "https://localhost:44392";
  constructor(private client: HttpClient) { }

  public AddCompanyStock(sc: StockCompany):Observable<any>
  {
    return this.client.post<StockCompany>(this.path+"/AdminService/StockExchangeCompanies",sc);
  }


}
