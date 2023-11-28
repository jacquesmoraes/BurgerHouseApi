import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/pagination';
import { Product } from '../shared/models/product';
import { Category } from '../shared/models/category';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/'
  
  constructor(private http: HttpClient) { }

  getProducts(categoryId?: number){
    let params = new HttpParams();
    if(categoryId) params = params.append('categoryId', categoryId)
    return this.http.get<Pagination<Product[]>>(this.baseUrl + 'products', {params});
  }

  getCategories(){
    return this.http.get<Category[]>(this.baseUrl + 'products/categories');
  }
}
