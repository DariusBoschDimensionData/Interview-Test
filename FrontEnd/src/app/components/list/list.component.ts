import { Component, OnInit } from '@angular/core';
import { Hero } from 'src/app/models/hero';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  heroes: Hero[] = [];
  updatedStats: Hero;

  constructor(private apiService: ApiService) { }

  ngOnInit(): void{
    this.getContacts();
  }

  getContacts(){
    this.apiService.getContacts();
  }

  postHero(heroName: string): void {
    const action = 'evolve';

    this.apiService.postHero(heroName, action).subscribe((updatedStats) => {
      this.updatedStats = updatedStats

    });
  }

  getRandomColorsClass(): string{
    const colorClasses = ['color-class-1', 'color-class-2','color-class-3', 'color-class-4'];
    const RandomIndex = Math.floor(Math.random() * colorClasses.length);
    return colorClasses[RandomIndex];
  }

}
