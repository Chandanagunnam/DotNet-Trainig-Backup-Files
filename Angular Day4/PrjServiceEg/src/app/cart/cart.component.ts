import { Component, OnInit } from '@angular/core';
import { element } from 'protractor';
import { Products } from 'src/models/Product.model';
import { ProductService } from 'src/services/productservice';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  products:Products[];
  grandTotal:number;
  //di
  constructor(private proservice:ProductService) { 
    this.products=this.proservice.cart;
    //console.log(this.products.value)
  }
  //calculate grand total
  ngDoCheck():void{
    this.grandTotal=0;
    this.products.forEach(element=>{
      this.grandTotal+=element.price*element.quantity;
    });
  }
  //calling removeitem service
  removeItem(prod:Products)
  {
    console.log("in reoveitem in cart",prod);
    this.proservice.removeItemfromCartservice(prod);
  }
  ngOnInit(): void {
  }

}
