import { Component, OnInit } from '@angular/core';
import { SubjectSubscriber } from 'rxjs/internal/Subject';
import { Employee } from '../models/employee.model';

@Component({
  selector: 'app-crud-employee',
  templateUrl: './crud-employee.component.html',
  styleUrls: ['./crud-employee.component.css']
})
export class CrudEmployeeComponent implements OnInit {
  EmployeeDetails:Employee[]=[
    {eid:1001,ename:"Alex",city:"Pune"},    {eid:1002,ename:"Siri",city:"Mumbai"},
    {eid:1003,ename:"Alexa",city:"Chennai"}
];
getempinfo:any={};
Message;
  constructor() { }
  Addemp()
  {
this.EmployeeDetails.push(this.getempinfo);
this.getempinfo={};
alert("employee added")
  }
  Deleteemp(eid)
  {
    for(let i=0;i<this.EmployeeDetails.length;i++)
    {
      if(eid == this.EmployeeDetails[i].eid)
      {
        this.EmployeeDetails.splice(i,1);
        alert("employee deleted")
      }
      else{
        this.Message = "Employee not deleted"
      }
    }

  }
  value;
  Editemp(eid)
{
  for(let i=0;i<this.EmployeeDetails.length;i++)
    {
      if(eid == this.EmployeeDetails[i].eid)
      {
        this.getempinfo.eid =this.EmployeeDetails[i].eid;
        this.getempinfo.ename =this.EmployeeDetails[i].ename;
        this.getempinfo.city =this.EmployeeDetails[i].city;
        this.value=eid;

      }
      else{
        this.Message="employee not editable";
      }
    }
}
Updateemp(){
  let x = this.value;
  for(let i=0;i<this.EmployeeDetails.length;i++)
  {
    if(x==this.EmployeeDetails[i].eid)
    {
this.EmployeeDetails[i] = this.getempinfo;
this.getempinfo={};
alert("employee updated");
    }
    else{
      this.Message ="Employee not updated";
    }
  }
}
  ngOnInit(): void {
  }
}