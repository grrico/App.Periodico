import { Component, OnInit } from '@angular/core';
import { DataUsrServiceApi } from './data-usr.service';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})


export class BodyComponent implements OnInit {
  show:boolean = true;
  activado:boolean=true;
  users: string[] =['jose','ana','luis','pedro'];


  metodoHola(){
    alert('Hola!');
  }

  DeleleUser(user){
    for(let i=0; i< this.users.length; i++){
      if (user==this.users[i]){
        this.users.splice(i,1);
      }
    }
  }

  AddUser(newUser){
    console.log('nuevo usuario:' + newUser.value);
    this.users.push(newUser.value);
    newUser.value='';
    return false;
  }
  nameUsrTs:string='Luis Maria';
  ageUsrTs: number = 50;

  name: String = 'genaro';
  age : Number;
  address:{
     street: string;
     city: string;
  };

  hobbies: string[];

  posts=[];

  constructor(private dataUsrService: DataUsrServiceApi) { 
    
    this.dataUsrService.getDataUsr().subscribe(dataUsrService => {
      
      //console.log(dataUsrService);
      
      this.posts=dataUsrService;
    });

    this.age=55;
    this.address={
      street:'carrara 45',
      city:'bello'      

    };
    this.hobbies=['nadar','leer','escribir'];
  }
  ngOnInit() {
  }

}
