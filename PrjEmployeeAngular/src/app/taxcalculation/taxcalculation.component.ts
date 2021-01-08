import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/Services/employeeService';

@Component({
  selector: 'app-taxcalculation',
  templateUrl: './taxcalculation.component.html',
  styleUrls: ['./taxcalculation.component.css']
})
export class TaxcalculationComponent implements OnInit {

  constructor(private empservice:EmployeeService) { }

  Taxamount;

  calculateTax(id){
    this.empservice.getCallTaxCalculate(id).subscribe(data=>{this.Taxamount=data});
  }



  ngOnInit(): void {
  }

}
