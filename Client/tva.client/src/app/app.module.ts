import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common'; 

//Views
import { HomeComponent } from './views/home/home.component';
import { PersonsComponent } from './views/persons/persons.component';
import { AboutComponent } from './views/about/about.component';
import { ContactComponent } from './views/contact/contact.component';
import { GridviewComponent } from './views/persons/gridview/gridview.component';

//Services
import { PersonService } from '../../src/services/implementation/PersonService'
import { IPersonService } from 'src/services/interface/IPersonService';

//Repositories
import { PersonRepository } from 'src/dal/implementation/PersonRepository';
import { IPersonRepository } from 'src/dal/interface/IPersonRepository';
import { DetailComponent } from './views/persons/detail/detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PersonsComponent,
    AboutComponent,
    ContactComponent,
    GridviewComponent,
    DetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule
  ],
  providers: [
    {provide: IPersonService, useClass: PersonService},
    {provide: IPersonRepository, useClass: PersonRepository},
             ],
  bootstrap: [AppComponent]
})
export class AppModule { }
