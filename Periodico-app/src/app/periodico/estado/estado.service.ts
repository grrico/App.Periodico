import { Injectable } from '@angular/core';

// se add el HttpClient
import {HttpClient} from '@angular/common/http';

// importa la clase estado
import {PeriodicoEstadoList} from './estados'

@Injectable({
  providedIn: 'root'
})

//PeriodicoEstadoList
export class PeridicoEstadoServiceApi {


  constructor(private httpClient: HttpClient) { 
    console.log('service esta trabajando el servicio estado!');
  }
  getDataEstadoAll(){
    return this.httpClient.get<PeriodicoEstadoList[]>('http://localhost/Periodico.WebApi/EstadoGetAll');
  }
  
}
