import {HttpClient} from '@angular/common/http';
import {Injectable} from '@angular/core'

@Injectable({providedIn:"root"})

export class EmployeeService
{
    constructor(private http:HttpClient)
    {

    }
    //call tax calculation from webapi

    getCallTaxCalculate(id)
    {
        return this.http.get("https://localhost:44353/api/Employeeboard/"+id);
        
    }

    getempbydept(deptname:string)
    {
        //QueryString
        return this.http.get("https://localhost:44353/api/Employee?deptname="+deptname);

    }
}
