using PhoneDirectory.Core.DataAccess.EntityFramework;
using PhoneDirectory.DataAccess.Abstract;
using PhoneDirectory.DataAccess.Concrete.EntityFramework.Context;
using PhoneDirectory.Entities.Concrete;

namespace PhoneDirectory.DataAccess.Concrete.EntityFramework.Concrete
{
    public class EfDirectoryDal : EfEntityRepositaryBase<Directory, PhoneDirectoryDbContext>, IDirectoryDal
    {
    }
}
