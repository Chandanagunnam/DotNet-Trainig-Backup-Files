import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrjServiceEg';
  loginuser;
  email;
  constructor(private router:Router)
  {}
    ngDoCheck()
    {
      if(sessionStorage.getItem('email'))
      {
        this.email=sessionStorage.getItem('email');
        this.loginuser=true;
      }
      else{
        this.loginuser=false;
      }
    }
    logOff()
  {
    sessionStorage.clear();
    this.loginuser=false;
    this.router.navigate(['/productlist']);
  }
  }

