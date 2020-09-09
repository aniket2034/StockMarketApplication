import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StockExchange } from 'src/app/Models/CompanyService/stock-exchange';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StockExchangeServiceService {

  constructor(private client: HttpClient) { }

  path:string = "https://localhost:44392";

  addStockExchange(stockexchange: StockExchange):Observable<StockExchange>
  {
    return this.client.post<StockExchange>(this.path+"/AdminService/StockExchange/addStockExchange", stockexchange);
  }

  listOfStockExchange():Observable<StockExchange[]>
  {
    return this.client.get<StockExchange[]>(this.path+"/UserService/StockExchange/getAllStockExchanges");
  }


}
