import { Component, OnInit } from '@angular/core';
import { CompanyServiceService } from 'src/app/Services/CompanyService/company-service.service';
import { IpoDetails } from 'src/app/Models/CompanyService/ipo-details';
import { Company } from 'src/app/Models/CompanyService/company';
import { StockExchange } from 'src/app/Models/CompanyService/stock-exchange';
import { StockExchangeServiceService } from 'src/app/Services/StockExchangeService/stock-exchange-service.service';
import { Router } from '@angular/router';



@Component({
  selector: 'app-admin-manage-ipo',
  templateUrl: './admin-manage-ipo.component.html',
  styleUrls: ['./admin-manage-ipo.component.css']
})
export class AdminManageIPOComponent implements OnInit {

  ipo_item= new IpoDetails();
  isAddIpoShown:boolean;

  existing_exchanges: StockExchange[];

  constructor(private service:CompanyServiceService, private service1: StockExchangeServiceService, private router:Router) {
      this.isAddIpoShown=true;
      
      this.service1.listOfStockExchange().subscribe(res=>
        {
          this.existing_exchanges=res;
        }
        
        )

  

   }

  ngOnInit(): void {
  }


  back()
  {
      this.router.navigateByUrl("adminlandingpage");
  }


  addIpo()
  {
    console.log(this.ipo_item);
      this.service.AddIPO(this.ipo_item).subscribe(res=> 
        {
            console.log(res);
            alert("IPO addition completed");
        }, (err) => 
        {
          console.log(err);
        }        
      
      )



  }




}
