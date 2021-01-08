import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms';
import {AbstractControl} from '@angular/forms'
@Component({
  selector: 'app-assignmentreactive',
  templateUrl: './assignmentreactive.component.html',
  styleUrls: ['./assignmentreactive.component.css']
})
export class AssignmentreactiveComponent implements OnInit {
  employee:FormGroup
  constructor() {
    this.employee= new FormGroup({
      username: new FormControl(null,[Validators.required, Validators.minLength(3), Validators.maxLength(12)]),
      age: new FormControl(0,this.ageRangeValidator),
      email:new FormControl(null, [Validators.email, Validators.required])

    });
   }
   ageRangeValidator(control:AbstractControl):
   { [key: string]: boolean} | null{
     if(control.value !== undefined && (isNaN(control.value) || control.value <18 || control.value >45)) {
       return{ 'ageRange':true };
     }
     return null;

   }

   onSubmit(): void { 
     console.log(this.employee.value);
   }
  ngOnInit(): void {
  }

}
