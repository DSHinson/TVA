import { Observable } from "rxjs";
import {Person } from "../../models/DTOPerson.Model"; 

export abstract class IPersonService{

    abstract personArray: Array<Person>;
    abstract getPersonsSearchWithPagination: (Page:number,PageSize:number, Search:string|null)=>Observable< Array<Person>>;

}