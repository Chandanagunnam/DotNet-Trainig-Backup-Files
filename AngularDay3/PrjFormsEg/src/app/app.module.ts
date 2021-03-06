import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TemplatedformComponent } from './templatedform/templatedform.component';
import{FormsModule} from "@angular/forms";
import {LoginreactiveformComponent} from './loginreactiveform/loginreactiveform.component';
import{ReactiveFormsModule} from '@angular/forms';
import { AssignmentreactiveComponent } from './assignmentreactive/assignmentreactive.component';

@NgModule({
  declarations: [
    AppComponent,
    TemplatedformComponent,
    LoginreactiveformComponent,
    AssignmentreactiveComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
