import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrjRoutingEg';
  loginsessionuser;
  loginsessionadmin;
  adminemail;
  username;
  constructor(private router:Router)
  { 

  }
  //part of angular life cycle hook,call back method that performs change-detection
  ngDoCheck()
  {
    if(sessionStorage.getItem('email'))//localStorage.getItem('email'))
    {
      //this.loginsession=true;
      this.adminemail = sessionStorage.getItem('email');
      if(this.adminemail=='admin@gmail.com')
      {
        this.loginsessionadmin=true;
        this.adminemail=true;
      }
    
    else
    {
      this.loginsessionuser=true;
    }
  }
  else{
    this.loginsessionadmin=false;
    this.loginsessionuser=false;
  }
  }

  logOff()
  {
    //localStorage.clear();
    //this.loginsession=false;
    sessionStorage.clear();
    this.loginsessionadmin=false;
    this.loginsessionuser=false;
    this.router.navigate(['/home']);
  }
}