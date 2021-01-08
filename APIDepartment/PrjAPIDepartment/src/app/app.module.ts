import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowdepartmentComponent } from './showdepartment/showdepartment.component';
import {FormsModule} from '@angular/forms';
import{HttpClientModule} from '@angular/common/http';
import { DepartmentService } from './service/department.service';
import { AdddepartmentComponent } from './adddepartment/adddepartment.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowdepartmentComponent,
    AdddepartmentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [DepartmentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
