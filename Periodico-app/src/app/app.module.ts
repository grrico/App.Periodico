import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Route } from '@angular/router'

import { AppComponent } from './app.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import {MaterialModule} from './material/material.module';

import { EncabezadoComponent } from './encabezado/encabezado.component';
import { FooterComponent } from './footer/footer.component';
import { BodyComponent } from './body/body.component';
import { UserComponent } from './user/user.component';
import { DataUsrServiceApi } from './body/data-usr.service';
import { AboutComponent } from './about/about.component';
import { EstadoComponent } from './periodico/estado/estado.component';

const routes: Route[] = [
 { path:'', component: BodyComponent },
 { path:'about', component: AboutComponent},
 { path:'periodico', component: EstadoComponent}
]
@NgModule({
  declarations: [
    AppComponent,
    EncabezadoComponent,
    FooterComponent,
    BodyComponent,
    UserComponent,
    AboutComponent,
    EstadoComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [DataUsrServiceApi],
  bootstrap: [AppComponent]
})
export class AppModule { }
