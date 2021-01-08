import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/models/customer.model';
import{NgForm} from '@angular/forms'

@Component({
  selector: 'app-templatedform',
  templateUrl: './templatedform.component.html',
  styleUrls: ['./templatedform.component.css']
})
export class TemplatedformComponent implements OnInit {

  domain:string[] =["cse","ece","mech","pe","pce"];
  cust:Customer;
  constructor() { 
    this.cust={
      cname:"",
      age:0,
      phno:"",
      mailid:"",
      gender:"",
      newsletter:false,
    }
  }

  onRegister(customerform:NgForm)
  {
    console.log(customerform.value)
  }

  ngOnInit(){
  }

}
