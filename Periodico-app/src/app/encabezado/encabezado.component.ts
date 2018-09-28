import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-encabezado',
  templateUrl: './encabezado.component.html',
  styleUrls: ['./encabezado.component.css']
})
export class EncabezadoComponent implements OnInit {
  title = 'Welcome to Periodico-Angular 6 Material'
  constructor() { }

  ngOnInit() {
  }

}
