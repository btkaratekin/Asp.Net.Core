using OgrIsler.Core.Concrete.EntityFrameWork;
using OgrIsler.DataAccess.Abstract;
using OgrIsler.DataAccess.Concrete.EntityFramework;
using OgrIsler.Entities.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OgrIsler.DataAccess.Concrete
{
    public class OgrBilgiDal : EfRepositoryBase<Bilgi, OgrIslerDbContext>, IOgrBilgiDal
    {
        
    }
}
