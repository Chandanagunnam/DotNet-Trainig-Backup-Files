import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {
name: string = "Sagar";
age: number;
hobbies:string[];
marks:Array<number>;
Istrue:boolean;
Student:object;
tupleExample:[string,number,boolean];
dynamicvalueExample:any;
picture = "assets/images/cat.jpg";
  constructor() { 
    this.age=25;
    this.hobbies=["eat","sleep","play"];
    this.marks=[80,60,50,98];
    this.Istrue=false;
    this.tupleExample=["ram",80,true];
    this.Student={fathername:"siva" , city: "pune"};
    this.dynamicvalueExample="hello";
    this.dynamicvalueExample=580;
  }

  ngOnInit(): void {
  }

}
