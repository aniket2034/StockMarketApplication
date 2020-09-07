import { Component, OnInit } from '@angular/core';
import { StockExchangeServiceService } from 'src/app/Services/StockExchangeService/stock-exchange-service.service';
import { StockExchange } from 'src/app/Models/CompanyService/stock-exchange';

@Component({
  selector: 'app-admin-manage-exchange',
  templateUrl: './admin-manage-exchange.component.html',
  styleUrls: ['./admin-manage-exchange.component.css']
})
export class AdminManageExchangeComponent implements OnInit {

  isNewStockExchangeShown: boolean;
  stockexchange_item:StockExchange;
  showstockexchange:boolean;
  allStockExchanges: StockExchange[];
  constructor(private service: StockExchangeServiceService) {

    this.service.listOfStockExchnage().subscribe(res=>
      {
        this.allStockExchanges=res;
      }      
      )


   }



  ngOnInit(): void {
  }

  addStockExchanges()
  {
    console.log(this.stockexchange_item);
    this.service.addStockExchange(this.stockexchange_item).subscribe(res=>
      {
          console.log(res);
          console.log('added stock exchange');
          window.location.reload();
      },(err)=>{
        console.log(err.error)
      }
      
      )
  }


  addStockExchangeForm()
  {
    this.isNewStockExchangeShown=true;
    this.stockexchange_item=new StockExchange();
  }

  adminLanding()
  {

  }

  cancel()
  {
    this.isNewStockExchangeShown=false;
  }


  showStockExchange()
  {
      this.showstockexchange=true;
  }


}
