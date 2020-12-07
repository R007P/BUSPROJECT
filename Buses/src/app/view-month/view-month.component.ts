import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-view-month',
  templateUrl: './view-month.component.html',
  styleUrls: ['./view-month.component.css']
})
export class ViewMonthComponent implements OnInit {
monthdetails;any=[];
  constructor(private router:Router,private monthservice:LoginService) { }

  fetchmonth(){
    this.monthdetails = this.monthservice.getMonthDetails().subscribe((data)=>
    {this.monthdetails=data;console.log(data)})
    console.log(this.monthdetails);
  }

  ngOnInit(): void {
    this.fetchmonth;
  }

}
