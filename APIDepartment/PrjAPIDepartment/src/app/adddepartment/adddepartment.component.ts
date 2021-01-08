import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department.model';
import { DepartmentService } from '../service/department.service';

@Component({
  selector: 'app-adddepartment',
  templateUrl: './adddepartment.component.html',
  styleUrls: ['./adddepartment.component.css']
})
export class AdddepartmentComponent implements OnInit {

/*department:Department;
result;

  constructor(private departmentServive:DepartmentService) { 
    this.department = new Department();
  }

  insertDepartment()
  {
    this.departmentServive.postDept(this.department).subscribe(
      (data)=>{this.result=data;
      })
  }
*/
  ngOnInit(){
  }

}
