import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/api.service';
import { Hero } from 'src/app/hero';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  heroes: Hero[] = [];
  updatedStats: Hero;

  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    this.getContacts();
  }

  getContacts() {
    this.apiService.getContacts();
  }

  postHero(heroName: string): void {
    const action = 'evolve';

    this.apiService.postHero(heroName, action).subscribe((updatedStats) => {
      this.updatedStats = updatedStats

    });
  }

  getRandomColour(): string {
    const colourClasses = ['color-class-1', 'color-class-2', 'color-class-3', 'color-class-4'];
    const RandomIndex = Math.floor(Math.random() * colourClasses.length);
    return colourClasses[RandomIndex];
  }

}
