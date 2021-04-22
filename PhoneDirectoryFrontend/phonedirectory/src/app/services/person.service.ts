import { Injectable } from '@angular/core';
import { WEB_API } from 'src/app/constants';
import { Observable } from 'rxjs';
import { Person } from 'src/app/models/person';
import { ListResponseModel } from 'src/app/models/responseModels/listResponseModel';
import { SingleResponseModel } from 'src/app/models/responseModels/singleResponseModel';
import {ResponseModel} from 'src/app/models/responseModels/responseModel';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private httpClient: HttpClient) { }

  getAllPerson(): Observable<ListResponseModel<Person>>{
    let newPath= WEB_API+'persons/getall';
    return this.httpClient.get<ListResponseModel<Person>>(newPath);
  }
  getByIdPerson(personId:number):Observable<SingleResponseModel<Person>>{
    let newPath= WEB_API+'persons/getbyid?id='+personId;
    return this.httpClient.get<SingleResponseModel<Person>>(newPath);
  }
  addPerson(person: Person):Observable<ResponseModel> {
     let newPath= WEB_API+"persons/add";
    return this.httpClient.post<ResponseModel>(newPath,person);
  }
  updatePerson(person: Person):Observable<ResponseModel> {
    let newPath= WEB_API+"persons/update";
    return this.httpClient.post<ResponseModel>(newPath,person);
  }
  deletePerson(person: Person):Observable<ResponseModel> {
    let newPath= WEB_API+"persons/delete";
    return this.httpClient.post<ResponseModel>(newPath,person);
  }
}
