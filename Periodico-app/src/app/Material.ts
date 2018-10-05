
import {NgModule} from '@angular/core';

import {MatButtonModule, MatCheckboxModule} from '@angular/material';

import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSelectModule} from '@angular/material/select';

import {MatMenuModule} from '@angular/material/menu';
import {MatTableModule} from '@angular/material/table';
import {MatGridListModule} from '@angular/material/grid-list';

@NgModule({
  imports: [MatButtonModule, MatCheckboxModule, MatToolbarModule, MatIconModule,MatFormFieldModule,MatSelectModule, MatMenuModule,MatTableModule, MatGridListModule],
  exports: [MatButtonModule, MatCheckboxModule, MatToolbarModule, MatIconModule, MatFormFieldModule, MatSelectModule, MatMenuModule,MatTableModule, MatGridListModule],
})
export class MaterialModule { }