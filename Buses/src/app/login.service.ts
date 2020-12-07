import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {AddBus, UpdateBus} from './models/add-bus';


@Injectable({
  providedIn: 'root'
})
export class LoginService {

  Url :string;  
  token : string;  
  header : any;  
  constructor(private http : HttpClient) {   
  
     
  
    const headerSettings: {[name: string]: string | string[]; } = {};  
    this.header = new HttpHeaders(headerSettings);  
  }  

  createbus(addbus:AddBus)  
  {  
   const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };  
   return this.http.post<AddBus[]>('https://localhost:44387/Api/Buses/createbus', addbus, httpOptions)  
  }

  getBusDetails(){
    //debugger;
    return this.http.get<any>("https://localhost:44387/getbus");
  }

  getMonthDetails(){
    return this.http.get<any>("https://localhost:44387/view-month");
  }

  updatebus(updatebus:UpdateBus): Observable<AddBus> {  
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
    return this.http.put<AddBus>('https://localhost:44387/api/bus/UpdateBus', updatebus, httpOptions);  
  }
}
