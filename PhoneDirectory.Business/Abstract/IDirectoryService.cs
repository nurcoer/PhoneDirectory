using PhoneDirectory.Core.Results.Utilities;
using PhoneDirectory.Entities.Concrete;
using System.Collections.Generic;

namespace PhoneDirectory.Business.Abstract
{
    public interface IDirectoryService
    {
        IResult Update(Directory directory);
        IResult Delete(Directory directory);
        IDataResult<List<Directory>> GetAll();
        IResult Add(Directory directory);
        IDataResult<Directory> GetById(int id);
    }
}
