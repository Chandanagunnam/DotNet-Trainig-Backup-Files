import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {
  people:any[] =[{"name":"Shree","age":22,"dept":"HR"},
  {"name":"Satya","age":23,"dept":"Admin"},
  {"name":"Laxmi","age":25,"dept":"HR"},
  {"name":"Ravi","age":29,"dept":"Finance"},
  {"name":"Viswa","age":21,"dept":"Admin"},
  {"name":"Shannu","age":31,"dept":"Sales"},
  {"name":"Sonali","age":23,"dept":"Transport"}


];


  constructor() { }

  ngOnInit(): void {
  }

}
