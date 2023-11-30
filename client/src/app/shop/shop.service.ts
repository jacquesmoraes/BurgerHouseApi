import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/pagination';
import { Product } from '../shared/models/product';
import { Category } from '../shared/models/category';
import { ShopParams } from '../shared/models/shopParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/'
  
  constructor(private http: HttpClient) { }

  getProducts(ShopParams: ShopParams){
    let params = new HttpParams();
    if(ShopParams.categoryId > 0) params = params.append('categoryId', ShopParams.categoryId);
    params = params.append('pageIndex', ShopParams.pageIndex);
    params = params.append('pageSize', ShopParams.pageSize);
    if(ShopParams.search) params = params.append('search', ShopParams.search);
    return this.http.get<Pagination<Product[]>>(this.baseUrl + 'products', {params});
  }

  getCategories(){
    return this.http.get<Category[]>(this.baseUrl + 'products/categories');
  }

  getProduct(id: number){
    return this.http.get<Product>(this.baseUrl + 'products/' + id);

  }

}
