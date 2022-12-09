import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})

export class ListComponent implements OnInit {
  heroes : any;

  constructor(private apiService: ApiService) { }

  ngOnInit() {
   this.getHeroes();
  }


  public evolveHero(Hero : any){
    this.apiService.postEvolve(Hero).subscribe(response => {
      window.alert("Stats For Hero:" + Hero.name + "Updated, table will display new values")
      this.heroes = response;
    });
  }

  getHeroes(){
    this.apiService.getHeroes().subscribe(response => {
      this.heroes = response;
    });
  }

  getClass(){
    return "classRandom-" + Math.floor(Math.random() * (4 - 1 + 1) + 1)
  }
}
