import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import Swal from 'sweetalert2';

import { Person } from 'src/app/models/person';
import { Directory } from 'src/app/models/directory';

import { PersonService } from 'src/app/services/person.service';
import { DirectoryService } from 'src/app/services/directory.service';

@Component({
  selector: 'app-person-detail',
  templateUrl: './person-detail.component.html',
  styleUrls: ['./person-detail.component.css']
})
export class PersonDetailComponent implements OnInit {
  
  directories: Directory[];
  person:Person;
  directoryTitle:string;
  
  constructor(
    private personService: PersonService,
     private directoryService: DirectoryService,
    private toastrService: ToastrService,
     private activetedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
     this.activetedRoute.params.subscribe((params) => {
      if (params['person']) {
        this.getPerson(params['person']);
      } else {
        //hata bas
      }
    });
  }


  getPerson(personId:number){
    
    this.personService.getByIdPerson(personId).subscribe(response => {
      this.person=response.data;
      this.getByIdDirectory(response.data.phoneDirectoryId)
    });
  }

  getByIdDirectory(directoryId:number){
    this.directoryService.getByIdDirectory(directoryId).subscribe(response=>{
      this.directoryTitle = response.data.title;
    })
  }

    handleWarningAlert(person:Person) {

    Swal.fire({
      title: 'Silme İşlemi',
      text: 'Kişiyi Listeden Silmek istediğinize emin misiniz?',
      icon: 'error',
      showCancelButton: true,
      confirmButtonText: 'Sil',
      cancelButtonText: 'Silme',
    }).then((result) => {

      if (result.isConfirmed) {

        this.deletePerson(person)

      } else if (result.isDismissed) {

        this.toastrService.info("Kişi Silinmedi.");
      }
    })

  }
  deletePerson(person:Person){

    this.personService.deletePerson(person).subscribe((response) => {
       this.toastrService.error(response.message);
      },responseError=> {
         if (responseError.error.Errors.length > 0) {
            for (let i = 0; i < responseError.error.Errors.length; i++) {
              this.toastrService.error(
                responseError.error.Errors[i].ErrorMessage,
                'Dogrulama hatasi'
              );
            }
          }
      });
  }

}
