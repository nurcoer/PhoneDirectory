using PhoneDirectory.Business.Abstract;
using PhoneDirectory.Core.Results.Utilities;
using PhoneDirectory.DataAccess.Abstract;
using PhoneDirectory.Entities.Concrete;
using PhoneDirectory.Business.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Business.Concrete
{
    public class PersonManager:IPersonService
    {
        IPersonDal _personDal;


        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new SuccessResult(PersonMessage.PersonAdd(person.FirstName));
        }
        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(PersonMessage.PersonUpdate(person.FirstName));
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(PersonMessage.PersonDelete(person.FirstName));
        }
        public IDataResult<Person> GetById(int id)
        {
            return new SuccessDataResult<Person>(_personDal.GetById(c => c.Id == id));
        }
        public IDataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll());
        }

    }
}
