import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CruddepartmentComponent } from './cruddepartment/cruddepartment.component';
import {FormsModule} from '@angular/forms';
import { CrudEmployeeComponent } from './crud-employee/crud-employee.component'
@NgModule({
  declarations: [
    AppComponent,
    CruddepartmentComponent,
    CrudEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
