
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { PersonListComponent } from './components/person/person-list/person-list.component';
import { PersonOperationComponent } from './components/person/person-operation/person-operation.component';
import { PersonDetailComponent } from './components/person/person-detail/person-detail.component';
import { NaviComponent } from './components/tools/navi/navi.component';
import { PersonFilterPipe } from './pipes/person-filter.pipe';


@NgModule({
  declarations: [
    AppComponent,
    PersonListComponent,
    PersonOperationComponent,
    PersonDetailComponent,
    NaviComponent,
    PersonFilterPipe
  ],
  imports: [
     BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot({
      positionClass:"toast-bottom-right"
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
