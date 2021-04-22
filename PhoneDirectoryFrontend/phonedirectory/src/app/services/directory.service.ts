import { Injectable } from '@angular/core';
import { WEB_API } from 'src/app/constants';
import { Observable } from 'rxjs';
import { Directory } from 'src/app/models/directory';
import { ListResponseModel } from 'src/app/models/responseModels/listResponseModel';
import { SingleResponseModel } from 'src/app/models/responseModels/singleResponseModel';
import {ResponseModel} from 'src/app/models/responseModels/responseModel';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DirectoryService {

  constructor(private httpClient: HttpClient) { }

  getAllDirectories(): Observable<ListResponseModel<Directory>>{
    let newPath= WEB_API+'directories/getall';
    return this.httpClient.get<ListResponseModel<Directory>>(newPath);
  }
  getByIdDirectory(directoryId:number):Observable<SingleResponseModel<Directory>>{
    let newPath= WEB_API+'directories/getbyid?id='+directoryId;
    return this.httpClient.get<SingleResponseModel<Directory>>(newPath);
  }
  addDirectory(book: Directory):Observable<ResponseModel> {
     let newPath= WEB_API+"directories/add";
    return this.httpClient.post<ResponseModel>(newPath,book);
  }
  updateDirectory(book: Directory):Observable<ResponseModel> {
    let newPath= WEB_API+"directories/update";
    return this.httpClient.post<ResponseModel>(newPath,book);
  }
  deleteDirectory(book: Directory):Observable<ResponseModel> {
    let newPath= WEB_API+"directories/delete";
    return this.httpClient.post<ResponseModel>(newPath,book);
  }
}
