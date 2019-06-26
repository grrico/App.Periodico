import { Injectable } from '@angular/core';

// se add el HttpClient
import {HttpClient} from '@angular/common/http';

// carga la ulr de environments
import { environment} from 'src/environments/environment'

// importa la clase estado
import {PeriodicoEstadoList} from './estados'

@Injectable({
  providedIn: 'root'
})

//PeriodicoEstadoList
export class PeridicoEstadoServiceApi {

  uriApi:string;

  constructor(private httpClient: HttpClient) { 
    console.log('service esta trabajando el servicio estado!');
    this.uriApi=environment.UrlServiceJson;
  }
  getDataEstadoAll(){
    //return this.httpClient.get<PeriodicoEstadoList[]>('http://localhost/Periodico.WebApi/EstadoGetAll');
    return this.httpClient.get<PeriodicoEstadoList[]>(this.uriApi);
  }
  
}
