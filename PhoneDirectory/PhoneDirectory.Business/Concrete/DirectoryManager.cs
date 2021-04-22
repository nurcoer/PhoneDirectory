using PhoneDirectory.Business.Abstract;
using PhoneDirectory.Business.Constants;
using PhoneDirectory.Core.Results.Utilities;
using PhoneDirectory.DataAccess.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Business.Concrete
{
    public class DirectoryManager : IDirectoryService
    {
        IDirectoryDal _directoryDal;

        public DirectoryManager(IDirectoryDal directoryDal)
        {
            _directoryDal = directoryDal;
        }
        public IResult Add(Directory directory)
        {
            _directoryDal.Add(directory);
            return new SuccessResult(PhoneDirectoryMessage.PhoneDirectoryAdd());
        }
        public IResult Update(Directory directory)
        {
            _directoryDal.Update(directory);
            return new SuccessResult(PhoneDirectoryMessage.PhoneDirectoryUpdate());
        }

        public IResult Delete(Directory directory)
        {
            _directoryDal.Delete(directory);
            return new SuccessResult(PhoneDirectoryMessage.PhoneDirectoryDelete());
        }

        public IDataResult<Directory> GetById(int id)
        {
            return new SuccessDataResult<Directory>(_directoryDal.GetById(d => d.Id == id));
        }

        public IDataResult<List<Directory>> GetAll()
        {
            return new SuccessDataResult<List<Directory>>(_directoryDal.GetAll());
        }

       

    }
}
