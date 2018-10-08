import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

import { PostUsr } from './UsrPost';

@Injectable({
  providedIn: 'root'
})
export class DataUsrServiceApi {

  constructor(private httpClient: HttpClient) { 
    // console.log('service esta trabajando!');
  }

  getDataUsr(){
    return this.httpClient.get<PostUsr[]>('https://jsonplaceholder.typicode.com/posts');
  }
}
