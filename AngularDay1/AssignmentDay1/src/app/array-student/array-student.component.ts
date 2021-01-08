import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-array-student',
  templateUrl: './array-student.component.html',
  styleUrls: ['./array-student.component.css']
})
export class ArrayStudentComponent implements OnInit {
  Student:any =[{"name":"Premi","id": 125,"iscleared": true,"photo":"assets/images/id1.jpg"},
  {"name":"Swamy","id": 126,"iscleared": true,"photo":"assets/images/id3.jpg"},
  {"name":"Sravan","id": 127,"iscleared": false,"photo":"assets/images/id4.jpg"},
  {"name":"Priya","id": 128,"iscleared": true,"photo":"assets/images/id2.jpg"}];
  constructor() { }

  ngOnInit(): void {
  }

}
