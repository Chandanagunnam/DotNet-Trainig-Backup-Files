import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm:FormGroup;
  constructor(private router:Router) {

    this.loginForm=new FormGroup({
      mailid:new FormControl(null,[Validators.required,Validators.email]),
      password:new FormControl(null,Validators.required)
    });


   }
   get mailid()
  {
    return this.loginForm.get('mailid')
  }

  get password()
  {
    return this.loginForm.get('password')
  }
  err;
  doLogin()
  {
    if(this.mailid.value=="chandana@gmail.com" && this.password.value=="chandana")
    {
         this.router.navigate(['productlist']);
       
       //  localStorage.setItem('email',this.mailid.value)
       sessionStorage.setItem('email',this.mailid.value)
    }
    else{
      this.err ="invalid username or password";
    }
  }
  ngOnInit(): void {
  }

}
