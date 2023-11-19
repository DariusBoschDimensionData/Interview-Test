import { Component, OnInit } from '@angular/core';
import { Hero } from 'src/app/models/hero';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  hero: Hero ={
    name : "hj",
    power: "ghfh",
    stats: []
  }

  
  constructor(private apiService: ApiService) { }

  ngOnInit(){
    this.getContacts();
  }

  getContacts(){
    //this.apiService.getContacts();
  }

}
