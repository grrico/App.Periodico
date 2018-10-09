import { Component, OnInit, ViewChild } from '@angular/core';
import { animate, state, style, transition, trigger} from '@angular/animations';

import {MatSort, MatTableDataSource, MatPaginator} from '@angular/material';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0', display: 'none'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class AboutComponent implements OnInit {
  
  dataSource = ELEMENT_DATA;
  listData: MatTableDataSource<any>;

  columnsToDisplay = ['nombre', 'peso', 'simbolo', 'posicion','actions'];
  
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchKey: string;

  expandedElement: PeriodicElement | null;
  
  ngOnInit() {
    
    this.listData = new MatTableDataSource(this.dataSource);
    this.listData.sort = this.sort;
    this.listData.paginator = this.paginator;

    console.log('Cantidad:' + this.listData.data.length);
  }

  onSearchClear() {
    this.searchKey = "";
    this.applyFilter();
  }

  applyFilter() {
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }

}
export interface PeriodicElement {  
  nombre: string;
  posicion: number;
  peso: number;
  simbolo: string;
  description: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {
    posicion: 1,
    nombre: 'Hydrogen',
    peso: 1.0079,
    simbolo: 'H',
    description: `Hydrogen is a chemical element with symbol H and atomic number 1. With a standard
        atomic weight of 1.008, hydrogen is the lightest element on the periodic table.`
  }, {
    posicion: 2,
    nombre: 'Helium',
    peso: 4.0026,
    simbolo: 'He',
    description: `Helium is a chemical element with symbol He and atomic number 2. It is a
        colorless, odorless, tasteless, non-toxic, inert, monatomic gas, the first in the noble gas
        group in the periodic table. Its boiling point is the lowest among all the elements.`
  }, {
    posicion: 3,
    nombre: 'Lithium',
    peso: 6.941,
    simbolo: 'Li',
    description: `Lithium is a chemical element with symbol Li and atomic number 3. It is a soft,
        silvery-white alkali metal. Under standard conditions, it is the lightest metal and the
        lightest solid element.`
  }, {
    posicion: 4,
    nombre: 'Beryllium',
    peso: 9.0122,
    simbolo: 'Be',
    description: `Beryllium is a chemical element with symbol Be and atomic number 4. It is a
        relatively rare element in the universe, usually occurring as a product of the spallation of
        larger atomic nuclei that have collided with cosmic rays.`
  }, {
    posicion: 5,
    nombre: 'Boron',
    peso: 10.811,
    simbolo: 'B',
    description: `Boron is a chemical element with symbol B and atomic number 5. Produced entirely
        by cosmic ray spallation and supernovae and not by stellar nucleosynthesis, it is a
        low-abundance element in the Solar system and in the Earth's crust.`
  }, {
    posicion: 6,
    nombre: 'Carbon',
    peso: 12.0107,
    simbolo: 'C',
    description: `Carbon is a chemical element with symbol C and atomic number 6. It is nonmetallic
        and tetravalent�making four electrons available to form covalent chemical bonds. It belongs
        to group 14 of the periodic table.`
  }, {
    posicion: 7,
    nombre: 'Nitrogen',
    peso: 14.0067,
    simbolo: 'N',
    description: `Nitrogen is a chemical element with symbol N and atomic number 7. It was first
        discovered and isolated by Scottish physician Daniel Rutherford in 1772.`
  }, {
    posicion: 8,
    nombre: 'Oxygen',
    peso: 15.9994,
    simbolo: 'O',
    description: `Oxygen is a chemical element with symbol O and atomic number 8. It is a member of
         the chalcogen group on the periodic table, a highly reactive nonmetal, and an oxidizing
         agent that readily forms oxides with most elements as well as with other compounds.`
  }, {
    posicion: 9,
    nombre: 'Fluorine',
    peso: 18.9984,
    simbolo: 'F',
    description: `Fluorine is a chemical element with symbol F and atomic number 9. It is the
        lightest halogen and exists as a highly toxic pale yellow diatomic gas at standard
        conditions.`
  }, {
    posicion: 10,
    nombre: 'Neon',
    peso: 20.1797,
    simbolo: 'Ne',
    description: `Neon is a chemical element with symbol Ne and atomic number 10. It is a noble gas.
        Neon is a colorless, odorless, inert monatomic gas under standard conditions, with about
        two-thirds the density of air.`
  },
   {
    posicion: 11,
    nombre: 'Fluorine',
    peso: 18.9984,
    simbolo: 'F',
    description: `Fluorine is a chemical element with symbol F and atomic number 9. It is the
        lightest halogen and exists as a highly toxic pale yellow diatomic gas at standard
        conditions.`
  }
];