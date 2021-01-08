import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title= "Welcome to learn Pipes";
  employee:object={name:'Satya',age:24,gender:'female'}
  public todayDate: Date;
  public amount: number;

  public products: any; //this variable holds the list of products
  public searchText: any;

  ngOnInit(){
  this.todayDate = new Date();
  this.amount =100;
  this.products =[
    { Id: 1, pname: "MilkPacket", price:50},
    { Id: 2, pname: "WaterBottle", price:50},
    { Id: 4, pname: "OrangeJuice", price:50},
    { Id: 5, pname: "Chocoloate", price:50},
    { Id: 3, pname: "cookies", price:50},
    { Id: 6, pname: "CoffeeBeans", price:50},
    { Id: 7, pname: "pen", price:50},
    { Id: 8, pname: "Paper", price:50},  
  ];
  }}
