import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sector } from 'src/app/Models/CompanyService/sector';

@Injectable({
  providedIn: 'root'
})
export class SectorService {

  path:string = "https://localhost:44392";
  constructor(private client: HttpClient) { }

  public AddSector(sector:Sector):Observable<any>
  {
    return this.client.post<Sector>(this.path+"/AdminService/Sector",sector);
  }


}
