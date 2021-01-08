import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event-biding',
  templateUrl: './event-biding.component.html',
  styleUrls: ['./event-biding.component.css']
})
export class EventBidingComponent implements OnInit {
  like:number;
  dislike:number;
  togglestar:boolean;
  clsName:string;

  constructor() {
    this.like=0;
    this.dislike =0;
    //star eg
    this.togglestar = false;
    this.clsName='glyphicon glyphicon-star-empty'
   }

  ngOnInit(): void {
  }
  welcomeMsg()
  {
    alert("Welcome to class");
  }
  //eg2
  fname;
  displayfullname(uname:HTMLInputElement)
  {
    this.fname =uname.value + "Gunnam"
  }
  finalsalary:number;
  incrementsalary(sal:HTMLInputElement)
  {
    //console.log("inside incresal",sal.value);
    this.finalsalary=parseInt(sal.value)+500;
    //console.log(this.finalslary);
  }
  increaselikes()
  {
    this.like+=1;
  }
  increasedislikes()
  {
    this.dislike+=1;
  }
  Starfill()
  {
    this.togglestar=! this.togglestar;
    if(this.togglestar)
    {
      this.clsName="glyphicon glyphicon-star";
    }
    else{
      this.clsName="glyphicon glyphicon-star-empty";
    }
  }
}
