import { Component } from '@angular/core';
import { ApiServices } from '../api.service';

@Component({
  selector: '.app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent {
  
//ngOnInit(): void {};

  constructor(public listcomponent: ApiServices) { }
  contact: any[] =[];
  hero: any[] =[];
  displayHero=false;

  getmethod () {
    this.listcomponent.getHeroes().subscribe ( (heroes:any) => {
        this.contact = heroes;
       
    });
}
displayClickedHero(id: any) {
  this.displayHero=true;
  this.listcomponent.getHeroesbyid().subscribe ( (heroes:any) => {
    this.hero = heroes;
  });
  
     
}
executeRandomColor() {
  const colorClasses = ['font-light-blue', 'font-bold-red', 'font-normal-green', 'background-yellow'];
  const randomIndex = Math.floor(Math.random() * colorClasses.length);
  return colorClasses[randomIndex];
}

}
 

