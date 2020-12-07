import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddBusComponent } from './add-bus/add-bus.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { FeedbacknewComponent } from './feedbacknew/feedbacknew.component';
import { ViewBusComponent } from './view-bus/view-bus.component';
import { ViewMonthComponent } from './view-month/view-month.component';
// import { ChangepasswordComponent } from'./changepassword/changepassword.component';

const routes: Routes = [
   {path:'feedbacknew',component:FeedbacknewComponent},
   {
     path:'admin-home',
     component:AdminHomeComponent 
   },
   {
     path:'add-bus',
     component:AddBusComponent
   },
   {
     path:'view-bus',
     component:ViewBusComponent
   },
   {
     path:'view-month',
     component:ViewMonthComponent
   }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
