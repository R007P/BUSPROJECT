import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ResetComponent } from './reset/reset.component';
import { ResetconfirmpgComponent } from './resetconfirmpg/resetconfirmpg.component';
import { ChangepasswordComponent } from './changepassword/changepassword.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { FeedbacknewComponent } from './feedbacknew/feedbacknew.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { AddBusComponent } from './add-bus/add-bus.component';
import { LoginService } from './login.service';
import { ViewBusComponent } from './view-bus/view-bus.component';
import { ViewMonthComponent } from './view-month/view-month.component';

@NgModule({
  declarations: [
    AppComponent,
    ResetComponent,
    ResetconfirmpgComponent,
    ChangepasswordComponent,
    FeedbackComponent,
    FeedbacknewComponent,
    AdminHomeComponent,
    AddBusComponent,
    ViewBusComponent,
    ViewMonthComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
