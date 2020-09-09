import { Component, OnInit, APP_INITIALIZER } from '@angular/core';
import {CompanyServiceService} from './../../../Services/CompanyService/company-service.service';
import {StockExchangeServiceService} from './../../../Services/CompanyService/stock-exchange-service.service';
import {Company} from './../../../Models/CompanyService/company';
import {IpoDetails} from './../../../Models/CompanyService/ipo-details'
import {Sector} from './../../../Models/CompanyService/sector'
import {StockExchange} from './../../../Models/CompanyService/stock-exchange'

@Component({
  selector: 'app-admin-manage-company',
  templateUrl: './admin-manage-company.component.html',
  styleUrls: ['./admin-manage-company.component.css']
})
export class AdminManageCompanyComponent implements OnInit {

  //lists of all the existing companies, stock exchanges and the sectors
  existing_companies: Company[];
  existing_stockExchanges: StockExchange[];
  existing_sectors: Sector[];

  //Company Item and an Ipo Item
  company_item: Company;
  ipo_item: IpoDetails;


  constructor(private service:CompanyServiceService) { 
    //Initialise the lists first
    this.company_item=new Company();

    this.service.listOfCompanies().subscribe(res=>
      {this.existing_companies=res;
      }
    )

    this.service.listOfStockExchanges().subscribe(res=>
      {this.existing_stockExchanges=res;
      }
    )
    this.service.listOfSectors().subscribe(res=>
      {this.existing_sectors=res;
      }
    )

  }

  


  ngOnInit(): void {
  }

  isNewCompanyShown:boolean;
  isUpdateCompanyShown:boolean;
  isDeleteCompanyShown:boolean;
  isAddIpoShown:boolean;


  newCompany()
  {
      this.isNewCompanyShown=true;
      this.isUpdateCompanyShown=false;
      this.isDeleteCompanyShown=false;
      this.isAddIpoShown=false;
      this.company_item=new Company();
  }

  updateCompany()
  {
    this.isNewCompanyShown=false;
    this.isUpdateCompanyShown=true;
    this.isDeleteCompanyShown=false;
    this.isAddIpoShown=false;
  }

  deleteCompany()
  {
    this.isNewCompanyShown=false;
    this.isUpdateCompanyShown=false;
    this.isDeleteCompanyShown=true;
    this.isAddIpoShown=false;
    this.company_item=new Company();
  }

  addIpo()
  {
    this.isNewCompanyShown=false;
    this.isUpdateCompanyShown=false;
    this.isDeleteCompanyShown=false;
    this.isAddIpoShown=true;
    this.ipo_item=new IpoDetails();
  }

  cancel()
  {
      this.isNewCompanyShown=false;
      this.isUpdateCompanyShown=false;
      this.isDeleteCompanyShown=false;
      this.isAddIpoShown=false;
  }

  back()
  {
      this.isNewCompanyShown=true;
      this.isUpdateCompanyShown=false;
      this.isDeleteCompanyShown=false;
      this.isAddIpoShown=false;
  }


  addCompany()
  {
    console.log(this.company_item);
      this.service.AddCompany(this.company_item).subscribe(res=>
        {
          console.log(res);
          alert("Company Added");
        } ,(err)=>{
          console.log(err.error)
        }
      ) 
        
  }


  delete()
  {
    console.log("here");
    console.log(this.company_item);
      this.service.deleteCompany(this.company_item.id).subscribe(res=>
        {
          console.log("deleted");
          alert("delete Complete");
        },(err)=>{
          console.log(err.error)
        }
        )
  }

  update()
  {
    console.log(this.company_item);
      this.service.updateCompany(this.company_item).subscribe(res=>
        {
          console.log("updated");
          alert("update Complete");
          window.location.reload();
        },(err)=>{
          console.log(err.error)
        })
  }

}
