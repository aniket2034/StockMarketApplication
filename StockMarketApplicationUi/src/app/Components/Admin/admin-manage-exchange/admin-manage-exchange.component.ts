import { Component, OnInit } from '@angular/core';
import { StockExchangeServiceService } from 'src/app/Services/StockExchangeService/stock-exchange-service.service';
import { StockExchange } from 'src/app/Models/CompanyService/stock-exchange';
import { CompanyServiceService } from 'src/app/Services/CompanyService/company-service.service';
import { Company } from 'src/app/Models/CompanyService/company';
import {StockCompany} from 'src/app/Models/StockCompany/stock-company'
import {StockCompanyService} from 'src/app/Services/StockExchangeCompanies/stock-company.service'


@Component({
  selector: 'app-admin-manage-exchange',
  templateUrl: './admin-manage-exchange.component.html',
  styleUrls: ['./admin-manage-exchange.component.css']
})
export class AdminManageExchangeComponent implements OnInit {

  stockcomp:StockCompany;
  existing_companies: Company[];
  isNewStockExchangeShown: boolean;
  stockexchange_item:StockExchange;
  showstockexchange:boolean;
  allStockExchanges: StockExchange[];
  showAddStockCompany:boolean;

  constructor(private service: StockExchangeServiceService, private service1: CompanyServiceService
    , private service2: StockCompanyService) {

    this.service.listOfStockExchange().subscribe(res=>
      {
        console.log(res);
        this.allStockExchanges=res;
      }
            
      )


      this.service1.listOfCompanies().subscribe(res=>
        {
          console.log(res);
          this.existing_companies=res;
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
    this.showstockexchange=false;
    this.stockexchange_item=new StockExchange();
  }

  adminLanding()
  {

  }

  cancel()
  {
    this.isNewStockExchangeShown=false;
    this.showAddStockCompany=false;
    this.showstockexchange=false;
  }

  addCompStock()
  {
    console.log(this.stockcomp);
    /*
    this.service2.AddCompanyStock(this.stockcomp).subscribe(res=>
     {
       console.log(res);
       alert("Company Added to StockExchange");
     }, (err) => 
     {
       console.log(err);
     }  
      
      )
*/
      this.service2.AddCompanyStock(this.stockcomp).subscribe(res=>
        
        {
          console.log(res);
          alert("Company Added to StockExchange");
        }, (err) => 
        {
          console.log(err);
        }
        
        
        )


  }

  addCompanyStock()
  {
    this.showstockexchange=false;
    this.isNewStockExchangeShown=false;
    this.showAddStockCompany=true;
    this.stockcomp=new StockCompany();
  }

  showStockExchange()
  {
      this.isNewStockExchangeShown=false;
      this.showstockexchange=true;
      this.showAddStockCompany=false;
  }


}
