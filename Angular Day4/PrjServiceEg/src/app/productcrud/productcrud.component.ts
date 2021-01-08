import { Component, OnInit } from '@angular/core';
import { pid } from 'process';
import { Products } from 'src/models/Product.model';
import { ProductService } from 'src/services/productservice';

@Component({
  selector: 'app-productcrud',
  templateUrl: './productcrud.component.html',
  styleUrls: ['./productcrud.component.css']
})
export class ProductcrudComponent implements OnInit {

  pro:Products[];
  
  getnewProduct:Products;

  message;
  constructor(private proservice:ProductService) { 
    this.getnewProduct=new Products();
  }
 
  ngOnInit() {
    this.fetchproductdetails()
  }

  fetchproductdetails(){
    this.pro =this.proservice.getProducts();

  }

  addProducts()
  {
    console.log("inside productclient add Products");
    if(this.proservice.addProduct(this.getnewProduct))
    {
      this.message='Product added successfully!!!';
    }
    else{
      this.message='Product Not Added!!';

    }
  }
  deleteProducts(id)
  {
    console.log('client:'+id);
    if(this.proservice.deleteProduct(id))
    {
      this.message='Product Deleted!!'
    }
    else{
      this.message='Product not deleted!!'
    }
  }

 /*editProduct()
  {
    
    if(this.proservice.editProduct(this.proservice.product[].pid))
    {
      this.message='Product editable!!'
    }
    else{
     this.message='Product not editable!!'
    }
  } */
  
  



}
