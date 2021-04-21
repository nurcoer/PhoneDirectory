using PhoneDirectory.Core.DataAccess;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.DataAccess.Abstract
{
    public interface IDirectoryDal : IEntityRepository<Directory>
    {
    }
}
