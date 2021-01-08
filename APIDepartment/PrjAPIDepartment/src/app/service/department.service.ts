import {HttpClient} from '@angular/common/http';
import {Injectable} from '@angular/core'
import { Department } from '../models/department.model';



@Injectable({providedIn:"root"})
//1
export class DepartmentService
{
    formData:Department;
    list:Department[];

    //2      //3
constructor(private http:HttpClient)
{
    this.list=[];
}
//4 retrive dept details from api
public getDept()
{
    return this.http.get("https://localhost:44315/api/tblDepartments");

}

//adding dept info in dept table
public postDept(department)
{
    return this.http.post("https://localhost:44315/api/tblDepartments",department);

}

//delete
public deleteDept(id)
{
    return this.http.delete("https://localhost:44315/api/tblDepartments"+id);
 
}

}