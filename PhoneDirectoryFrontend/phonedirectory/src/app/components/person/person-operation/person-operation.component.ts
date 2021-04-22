import { Component, Input, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  FormControl,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';

import { Person } from 'src/app/models/person';
import { Directory } from 'src/app/models/directory';

import { PersonService } from 'src/app/services/person.service';
import { DirectoryService } from 'src/app/services/directory.service';

@Component({
  selector: 'app-person-operation',
  templateUrl: './person-operation.component.html',
  styleUrls: ['./person-operation.component.css']
})
export class PersonOperationComponent implements OnInit {
  operationType: string;
  personForm: FormGroup;
  currentPersonId: number;
  directories: Directory[];
  person:any;

  constructor(
    private formBuilder: FormBuilder,
    private personService: PersonService,
     private directoryService: DirectoryService,
    private toastrService: ToastrService,
    private router: Router,
    private activetedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getAllDirectories();
    
    this.activetedRoute.params.subscribe((params) => {
      if (params['person']) {
        this.operationType = 'Update';
        this.createPersonEditForm(params['person']);
      } else {
        this.createPersonAddForm();
        this.operationType = 'Add';
      }
    });
  }

    createPersonEditForm(personId: number) {
    this.currentPersonId = personId;

    this.personForm = this.formBuilder.group({
      id:[''],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      description: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      phoneDirectoryId: ['', Validators.required],
    });
    
      this.personService.getByIdPerson(personId).subscribe(response => {
        this.personForm.patchValue({
        id: response.data.id,
        firstName: response.data.firstName,
        lastName: response.data.lastName,
        description: response.data.description,
        phoneNumber: response.data.phoneNumber,
        phoneDirectoryId: response.data.phoneDirectoryId,
      });
    });
    
  }

  createPersonAddForm() {
    this.personForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      description: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      phoneDirectoryId: ['', Validators.required],
    });
  }

 getAllDirectories() {
    this.directoryService.getAllDirectories().subscribe((response) => {
      this.directories = response.data;
    });
  }

   addPerson() {
    if (this.personForm.valid) {
      this.findDirectory();
      this.personService.addPerson(this.person).subscribe((response) => {
        this.toastrService.info(response.message);
        
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
    } else {
      this.toastrService.error('Form Invalid');
    }
  }

  findDirectory(){
    this.person = Object.assign({}, this.personForm.value);
    this.person.phoneDirectory = this.directories.find(directory => {
       return directory.id === this.person.phoneDirectoryId
      });
      this.person.phoneNumber=this.person.phoneNumber.toString();
  }

  updatePerson() {
    if (this.personForm.valid) {
      this.findDirectory();
      this.personService.updatePerson(this.person).subscribe((response)=>{
       this.toastrService.success(response.message);
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
    } else {
      this.toastrService.error('Form Invalid');
    }
  }

}
