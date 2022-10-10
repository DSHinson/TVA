import { Component, OnInit } from '@angular/core';
import { Person } from 'src/models/DTOPerson.Model';
import { IPersonService } from 'src/services/interface/IPersonService';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.css'],
})
export class PersonsComponent implements OnInit {

  Person!: Person | null;

  constructor() { }

  ngOnInit(): void {
  }

  PersonSelected(person:Person): void{
    alert(person.name);
  }

}
