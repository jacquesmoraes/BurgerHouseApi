import { HttpClient } from '@angular/common/http';
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

  getProducts(){
    return this.http.get<Pagination<Product[]>>(this.baseUrl + 'products?pageSize=50');
  }

  getCategories(){
    return this.http.get<Category[]>(this.baseUrl + 'products/categories');
  }
}
