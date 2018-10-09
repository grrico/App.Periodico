import { Component, OnInit, ViewChild} from '@angular/core';
import { PeridicoEstadoServiceApi } from './estado.service';

import {MatSort, MatTableDataSource, MatPaginator} from '@angular/material';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-estado',
  templateUrl: './estado.component.html',
  styleUrls: ['./estado.component.css']
})

export class EstadoComponent implements OnInit {
  
  DataEstadoperidico=[];
  columnsToDisplay: string[] = ['codigo', 'nombre_Estado', 'activo'];
  dataSource = new MatTableDataSource<object>(this.DataEstadoperidico);
  
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchKey: string;


  constructor(private dataEstadoService: PeridicoEstadoServiceApi) {
    this.dataEstadoService.getDataEstadoAll().subscribe(dataEstadoService => {
        this.DataEstadoperidico=dataEstadoService;
        this.dataSource.data = this.DataEstadoperidico;
        
        let num = [7, 8, 9];
        num.forEach(function (value) {
          console.log(value);
        });
        this.dataSource.data.forEach(function (value) {
          console.log(value);
        });

        console.log('Cantidad:' + this.dataSource.data.length);
        console.log('Cantidad:' + this.dataSource.data.forEach);
    });
   }

  ngOnInit() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  onSearchClear() {
    this.searchKey = "";
    this.applyFilter();
  }

  applyFilter() {
    this.dataSource.filter = this.searchKey.trim().toLowerCase();
  }

}


