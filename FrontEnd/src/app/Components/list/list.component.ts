import { Component, OnInit } from '@angular/core';
import { heroes } from 'src/app/Models/Heroes';
import { ApiService } from 'src/app/Services/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  //declare and initialize variables 
  heroList: heroes[] = [];
  StatsUpdated: boolean = false;

  constructor(private apiService: ApiService) { }

  ngOnInit() {

  //Call to service to get information from API using GET
   this.apiService.getHeroes().subscribe(data=>{
    //assign data received to array of data type Heroes
    this.heroList = data;  

    //Make sure status update heading is hidden on read and if page is not refreshed.
    this.StatsUpdated = false;
   });
  }

  //Method to evolve Hero
  EvolveHero(Hero: heroes)
  {
    let hero = Hero.name; //Get Hero name from UI fields

    //Call to service to post information to the API using POST with parameters
    this.apiService.evolve(hero, "evolve").subscribe((Response: any)=>{

      //Clear array
     this.heroList = [];
      //re-add Hero becaue only one Hero - if more then you can remove and re-insert by index
     this.heroList.push(Response);

      //Display stats was updated heading above table
      this.StatsUpdated = true;
    });
  }
}
