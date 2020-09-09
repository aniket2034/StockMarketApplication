import { Component, OnInit } from '@angular/core';
import { Sector } from 'src/app/Models/CompanyService/sector';
import {SectorService} from 'src/app/Services/SectorService/sector.service'
import { Router } from '@angular/router';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-admin-manange-sector',
  templateUrl: './admin-manange-sector.component.html',
  styleUrls: ['./admin-manange-sector.component.css']
})
export class AdminManangeSectorComponent implements OnInit {

  sector_item:Sector;
  constructor(private service: SectorService, private router: Router) {
    this.sector_item=new Sector();
   }

  ngOnInit(): void {
  }

  addSector()
  {
    console.log(this.sector_item);
    this.service.AddSector(this.sector_item).subscribe(res=>
      {
        console.log(res);
            alert("Sector addition completed");
        }, (err) => 
        {
          console.log(err);
        }    
      )
  }

  back()
  {
      this.router.navigateByUrl("adminlandingpage");
  }


}
