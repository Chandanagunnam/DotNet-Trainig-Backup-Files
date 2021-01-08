import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventBidingComponent } from './event-biding/event-biding.component';
import {FormsModule} from '@angular/forms';
import { TwoWayBindingComponent } from './two-way-binding/two-way-binding.component';
@NgModule({
  declarations: [
    AppComponent,
    EventBidingComponent,
    TwoWayBindingComponent
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
