using OgrIsler.Business.Abstract;
using OgrIsler.Core.Abstract;
using OgrIsler.DataAccess.Abstract;
using OgrIsler.Entities.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Business.Concrete
{
    public class OgrBilgiService : IOgrBilgiService
    {
        public readonly IOgrBilgiDal _OgrBilgiDal;

        public OgrBilgiService(IOgrBilgiDal ogrBilgiDal)
        {
            _OgrBilgiDal = ogrBilgiDal;
        }

        public void Delete(Bilgi Entity)
        {
            throw new NotImplementedException();
        }

        public Task<Bilgi> Get(Expression<Func<Bilgi, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Bilgi>> GetList(Expression<Func<Bilgi, bool>> filter = null)
        {
            return await _OgrBilgiDal.GetList();
        }

        public void Insert(Bilgi Entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Bilgi Entity)
        {
            throw new NotImplementedException();
        }
    }
}
