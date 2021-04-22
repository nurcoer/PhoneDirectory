
using PhoneDirectory.Core.Results.Utilities;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Business.Abstract
{
    public interface IPersonService
    {
        IResult Update(Person person);
        IResult Delete(Person person);
        IDataResult<List<Person>> GetAll();
        IResult Add(Person person);
        IDataResult<Person> GetById(int id);
    }
}
