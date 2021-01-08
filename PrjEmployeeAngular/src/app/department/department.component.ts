import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/Services/employeeService';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {

  constructor(private empservice:EmployeeService) { }
  Employee:any=[];

  getEmpByName(Dname){
    this.empservice.getempbydept(Dname).subscribe(data=>{this.Employee=data});
  }
  ngOnInit(): void {
  }

}
