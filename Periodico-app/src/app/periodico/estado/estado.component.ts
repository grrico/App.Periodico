import { Component, OnInit } from '@angular/core';
import { EstadoServiceApi } from './estado.service';

@Component({
  selector: 'app-estado',
  templateUrl: './estado.component.html',
  styleUrls: ['./estado.component.css']
})
export class EstadoComponent implements OnInit {

  estadoList=[];
  
  constructor(private dataEstadoService: EstadoServiceApi) {

    this.dataEstadoService.getDataEstadoAll().subscribe(dataEstadoService => {
      this.estadoList=dataEstadoService;
    });

   }

  ngOnInit() {
  }

}
