import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { Person } from './models/person';
import{PersonListComponent} from './components/person/person-list/person-list.component';
import{PersonOperationComponent} from './components/person/person-operation/person-operation.component';
import{PersonDetailComponent} from './components/person/person-detail/person-detail.component';

const routes: Routes = [
  { path: 'persons', component: PersonListComponent },
  { path: 'persons/:filterText', component: PersonListComponent },
  { path: 'personsUpdate/:person', component: PersonOperationComponent },
  { path: 'personsAdd', component: PersonOperationComponent },
  { path: 'personsDetail/:person', component: PersonDetailComponent }
];
 
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
