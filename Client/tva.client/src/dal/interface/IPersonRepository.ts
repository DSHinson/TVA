import { Observable } from "rxjs";
import {Person } from "../../models/DTOPerson.Model"; 

export abstract class IPersonRepository {
   abstract getPersonsWithPagination: (Page:number,PageSize:number,searchTerm:string|null)=> Observable<Array<Person>>;
}