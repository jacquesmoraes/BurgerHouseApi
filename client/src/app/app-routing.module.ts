import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BookingComponent } from './booking/booking.component';
import { BlogComponent } from './blog/blog.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'booking', component: BookingComponent},
  {path: 'blog', component: BlogComponent},
  {path: 'shop', loadChildren: () => import ('./shop/shop.module').then(m => m.ShopModule)},
  {path: '**', redirectTo:'', pathMatch:'full'}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
