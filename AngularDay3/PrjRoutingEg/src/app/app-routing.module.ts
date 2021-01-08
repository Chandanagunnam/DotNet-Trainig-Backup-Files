import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DepartmentComponent } from './department/department.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { StockComponent } from './stock/stock.component';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
const routes: Routes = [
  //default route
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:HomeComponent},
  {path:'department',component:DepartmentComponent},
  {path:'login',component:LoginComponent},
  {path:'admin',component:AdminComponent,
children:[{path:'productcrud',component:ProductcrudComponent},
{
  path:'stock',component:StockComponent
}]
},
{path:'**',component:PagenotfoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }