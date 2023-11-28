import { Component, OnInit } from '@angular/core';
import { Product } from '../shared/models/product';
import { ShopService } from './shop.service';
import { Category } from '../shared/models/category';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit{
products : Product[] = [];
categories: Category[] = [];
categoryIdSelected = 0;

constructor(private shopService : ShopService){}

  ngOnInit(): void {
   this.getProducts();
   this.getCategories();
  }
getProducts(){
  this.shopService.getProducts(this.categoryIdSelected).subscribe({
    next: response => this.products = response.data,
    error: error => console.log(error)
  })
}
getCategories(){
  this.shopService.getCategories().subscribe({
    next: response => this.categories = [{id: 0, categoryName:'all'}, ...response],
    error: error => console.log(error)
  })
}

onCategorySelected(categoryId: number){
  this.categoryIdSelected = categoryId;
  this.getProducts();
}

}
