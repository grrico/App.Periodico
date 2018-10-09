import { Injectable } from '@angular/core';

// se add el HttpClient
import {HttpClient} from '@angular/common/http';

// importa la clase estado
import {Estados} from './estadoList'

@Injectable({
  providedIn: 'root'
})
export class EstadoServiceApi {

  constructor(private httpClient: HttpClient) { 
    console.log('service esta trabajando el servicio estado!');
  }

  getDataEstadoAll(){
    //return this.httpClient.get<Estados>('http://localhost/Periodico.WebApi/swagger/ui/index#!/Estado/Estado_EstadoGetAll');
    return this.httpClient.get<Estados>('https://jsonplaceholder.typicode.com/posts');
  }

}
