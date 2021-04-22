import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Person } from 'src/app/models/person';

import { PersonService } from 'src/app/services/person.service';

@Component({
  selector: 'app-person-list',
  templateUrl: './person-list.component.html',
  styleUrls: ['./person-list.component.css']
})
export class PersonListComponent implements OnInit {

  persons: Person[] = [];
  dataLoaded = false;
  filterText: string;

  constructor(
    private personService: PersonService,
    private activatedRoute: ActivatedRoute,
  ) { }

  ngOnInit(): void {
     this.activatedRoute.params.subscribe((params) => {
       this.getPersons();
       if (params['filterText']) {
          this.filterText = params['filterText'];
        }
     })
  }

  getPersons(){
    this.personService.getAllPerson().subscribe((response) => {
       this.persons = response.data;
       this.dataLoaded = true;
    });
  }



}
