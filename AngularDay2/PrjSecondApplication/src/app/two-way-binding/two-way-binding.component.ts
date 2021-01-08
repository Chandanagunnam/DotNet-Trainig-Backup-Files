import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-two-way-binding',
  templateUrl: './two-way-binding.component.html',
  styleUrls: ['./two-way-binding.component.css']
})
export class TwoWayBindingComponent implements OnInit {
  uname:string;
  fname:string ;

  constructor() { 

  }
  fullname(){
    this.fname= this.uname + "KUMAR";

  }


  ngOnInit(): void {
  }

}
