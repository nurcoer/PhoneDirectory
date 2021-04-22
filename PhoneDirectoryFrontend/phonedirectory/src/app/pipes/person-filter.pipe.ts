import { Pipe, PipeTransform } from '@angular/core';

import { Person } from 'src/app/models/person';

@Pipe({
  name: 'personFilter'
})
export class PersonFilterPipe implements PipeTransform {

  transform(value: Person[], filterText: string): Person[] {
     filterText = filterText ? filterText.toLocaleLowerCase() : '';
    return filterText
      ? value.filter(
          (p) =>
            p.firstName.toLocaleLowerCase().indexOf(filterText) !== -1 ||
            p.lastName.toLocaleLowerCase().indexOf(filterText) !== -1 
        )
      : value;
  }

}
