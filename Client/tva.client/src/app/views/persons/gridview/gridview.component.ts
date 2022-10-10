import { Component,Output, EventEmitter, ElementRef, HostListener, OnInit, ViewChild } from '@angular/core';

import { delay } from 'rxjs';
import { Person } from 'src/models/DTOPerson.Model';
import { IPersonService } from 'src/services/interface/IPersonService';

@Component({
  selector: 'app-gridview',
  templateUrl: './gridview.component.html',
  styleUrls: ['./gridview.component.css']
})
export class GridviewComponent implements OnInit {
  Page:number = 0;
  PageSize:number = 10;
  Persons:Array<Person> = new Array<Person>();
  loading:boolean = false;
  searchTerm:string|null =null;
  @Output() newItemEvent = new EventEmitter<Person>();

  constructor(private _PersonService:IPersonService) { 
    
  }
  
  ngOnInit(): void {
    this.LoadPage()
  }
  
  btnSelectPerson_Click(person:Person):void
  {
      this.newItemEvent.emit(person);
    

  }

  LoadPage():void{
    this._PersonService.getPersonsSearchWithPagination(this.Page,this.PageSize,this.searchTerm).subscribe((result)=>{
       
      this.Persons=result;
      
    });
  this.loading =false;
  }

  btnClearSearch_Click():void{

    this.searchTerm = null;
    this.btnSearch_Click();
  }

  btnSearch_Click():void{
    this.Persons = [];
    this.loading = true;
    this.Page = 0;
    this._PersonService.getPersonsSearchWithPagination(this.Page,this.PageSize,this.searchTerm).subscribe((result)=>{

      this.Persons=result;
    });
  this.loading =false;
  }

  btnNextPage_Click():void{
      ++this.Page;
      this.LoadPage();
  }

  btnPreviousPage_Click():void{
    if(this.Page>0)
    {
      --this.Page;
    }
    this.LoadPage();
  }

}
