import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department.model';
import { DepartmentService } from '../service/department.service';

@Component({
  selector: 'app-showdepartment',
  templateUrl: './showdepartment.component.html',
  styleUrls: ['./showdepartment.component.css']
})
export class ShowdepartmentComponent implements OnInit {

  //get
  departments;
//post
  department:Department;
  result;
  del;

  constructor(private deptService:DepartmentService)
   { 

   }

  ngOnInit() {
    this.fetchDept();
  }

  //calling getDept from departmentService

  fetchDept()
  {
    console.log("Inside Method");
    this.deptService.getDept().subscribe(
    (data)=>{this.departments = data; console.log(data)})
  }

  //post
  
  insertDept()
  {
    this.deptService.postDept(this.department).subscribe(
      (data)=>{this.result=data;}
    )
  }

  //Delete
  deleteDept(id)
  {
    this.deptService.deleteDept(id).subscribe(
      (data) =>{this.del=data;}
    )
  }



}
