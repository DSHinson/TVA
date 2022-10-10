import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import {IPersonRepository}from "../interface/IPersonRepository";
import {Person } from "../../models/DTOPerson.Model"; 
import { observable } from 'rxjs';

@Injectable()
export class PersonRepository implements IPersonRepository
{
    constructor(private Client:HttpClient){

    };

    getPersonsWithPagination(Page:number,PageSize:number,searchTerm:string|null){
       // Initialize Params Object
    let params = new HttpParams();

    // Begin assigning parameters
    params = params.append('Page', Page);
    params = params.append('PageSize', PageSize);
    if(searchTerm)
    {
      params = params.append('search', searchTerm);
    }
      return  this.Client.get<Array<Person>>("https://localhost:7228/api/Person",{ params: params });
    }

}