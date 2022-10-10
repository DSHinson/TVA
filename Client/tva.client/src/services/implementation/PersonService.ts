import { Injectable } from "@angular/core";
import { Person } from "src/models/DTOPerson.Model";
import { IPersonService } from "../interface/IPersonService";
import { IPersonRepository } from "src/dal/interface/IPersonRepository";

@Injectable()
export class PersonService implements IPersonService {
    constructor(private PersonRepository: IPersonRepository) {

    }

    public personArray: Array<Person> = [];
    
    public getPersonsSearchWithPagination(Page:number,PageSize:number,searchTerm :string|null) {
       return  this.PersonRepository.getPersonsWithPagination(Page,PageSize,searchTerm);
    }

}