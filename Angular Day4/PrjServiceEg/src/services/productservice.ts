import { Injectable } from '@angular/core';
import { Products } from 'src/models/Product.model';
import{element} from 'protractor';

@Injectable()
export class ProductService
{
    product:Products[];
    cart:Products[];

    constructor()
    {
        this.product=[
            {pid:1001,pname:'Bag',price:1500,quantity:10,info:"Pure Leather",image:'assets/images/bag.jpg'},
            {pid:1002,pname:'Earrings',price:15000,quantity:30,info:"22 carates gold",image:'assets/images/earrings.jpg'},
            {pid:1003,pname:'Laptop',price:25000,quantity:15,info:"HD Touchdisplay spillresistant keyboard",image:'assets/images/laptop.jpg'},
            {pid:1004,pname:'Watch',price:3000,quantity:20,info:"water proof",image:'assets/images/Watch.jpg'},

        ];
        this.cart=[];
    }
    //fetching all the product information
    getProducts()
    {
        return this.product;
    }

    //by passing pid, fetch the particular product details
    getProductInfo(proid)
    {
        let productinfo;
        this.product.forEach(element=>{
            if(element.pid==proid)
            {
                productinfo=element;
            }
        });

        return productinfo
    }

    public addToCartService(product:Products)
    {
        //If the product already exist in cart adding quantity alone
        let flag=0;
        for (let index=0;index <this.cart.length;index++){
            if(this.cart[index].pid == product.pid)
            {
                flag = 1;
                this.cart[index].quantity++;
                break;
            }
        }
        
        //if product not exist in cart add the product to cart
        if(flag ==0)
        this.cart.push(product);

        //to reduce the original quantity in products array
        for(let index = 0;index <this.product.length;index++){
        if(this.product[index].pid == product.pid)
        {
            this.product[index].quantity--;
        } 
    }
    }
    //Removing item from cart
    removeItemfromCartservice(prod)
    {
        console.log("service:remove item",prod);
        for(let i=0;i<this.cart.length;i++)
        {
            if(this.cart[i].pid==prod.pid)
            {
                console.log("inside first if")
                if(prod.quantity>1)
                {
                    this.cart[i].quantity--;
                }
                else if(prod.quantity==1)
                {
                    this.cart.splice(i,1);
                }
            }
        }
        //incrementing quantity to list
        for(let index=0;index<this.product.length;index++)
        {
            if(this.product[index].pid==prod.pid)
            {
                this.product[index].quantity++;
                console.log("after remove quantity"+this.product[index].quantity)
            }
        }
    }


    //Adding new products
    addProduct(product:Products){
        console.log("inside service add Products");
        for (let index = 0; index < this.product.length; index++) {
            if(this.product[index].pid == product.pid)
            {
                return false;
            }  
        }
        this.product.push(product);
        return true;
    }


    //Deleting Product

 deleteProduct(productid:number)
 {
     console.log("inside service delete Products:"+productid);

     
//Passing Id
     for (let index = 0; index < this.product.length; index++) {
         console.log("inside service for ");
         if(this.product[index].pid==productid)  //when particular product id not exist
         {
             console.log('service id:'+this.product[index].pid);
             this.product.splice(index,1);   //when particular product id  exist
             return true;
         }  
     }
     return false;
 }

 infor:Products;

/*editProduct()
{
    for (let index = 0; index < this.product.length; index++) {
        console.log("inside service for ");
        if(this.infor.pid==this.product[index].pid)  //when particular product id not exist
        {
            this.infor.pid = this.product[index].pid;
            this.infor.pname = this.product[index].pname;
            this.infor.price = this.product[index].price;
            this.infor.quantity = this.product[index].quantity;
            this.infor.info = this.product[index].info;
            
            return true;
        }  
    }
    return false;
}*/

}

