import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department.model';

@Component({
  selector: 'app-cruddepartment',
  templateUrl: './cruddepartment.component.html',
  styleUrls: ['./cruddepartment.component.css']
})
export class CruddepartmentComponent implements OnInit {

  dept:Department[]=[
    {deptid:1001,dname:"Admin",location:"Pune"},
  {deptid:1002,dname:"Hr",location:"Patna"},
  {deptid:1003,dname:"Sales",location:"Hyd"},
  {deptid:1004,dname:"Finance",location:"chennai"}
];
  getdeptinfo:any={};

  constructor() { }
  addDepartment()
  {
    this.dept.push(this.getdeptinfo);
    this.getdeptinfo={};
  }
  deleteDepartment(i)
  {
    console.log(i);
    this.dept.splice(i,1);
  }
indexvalue;
editDepartment(i)
{
  this.getdeptinfo.deptid = this.dept[i].deptid;
  this.getdeptinfo.dname = this.dept[i].dname;
  this.getdeptinfo.location = this.dept[i].location;
  this.indexvalue =i;
}
updateDepartment()
{
  let k = this.indexvalue;
  for(let i=0;i<this.dept.length;i++)
  {
    if(k==i)
    {
      this.dept[i] = this.getdeptinfo;
      this.getdeptinfo={};
    }
  }
}
  ngOnInit(): void {
  }

}
