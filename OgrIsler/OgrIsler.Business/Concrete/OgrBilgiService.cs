using Ninject;
using OgrIsler.Business.Abstract;
using OgrIsler.Core.Abstract;
using OgrIsler.DataAccess.Abstract;
using OgrIsler.DataAccess.Concrete;
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
        public readonly StandardKernel _kernel;

        public OgrBilgiService()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IOgrBilgiService>().To<OgrBilgiService>().InSingletonScope();
            _kernel.Bind<IOgrBilgiDal>().To<OgrBilgiDal>().InSingletonScope();
            _OgrBilgiDal = new OgrBilgiDal();
        }

        //public OgrBilgiService(IOgrBilgiDal ogrBilgiDal)
        //{
        //    _OgrBilgiDal = ogrBilgiDal;
        //}

        public void Delete(Bilgi Entity)
        {
            _OgrBilgiDal.Delete(Entity);
        }

        public async Task<Bilgi> Get(Expression<Func<Bilgi, bool>> filter = null)
        {
            return await _OgrBilgiDal.Get(filter);
        }

        public async Task<IList<Bilgi>> GetList(Expression<Func<Bilgi, bool>> filter = null)
        {
            return await _OgrBilgiDal.GetList();
        }

        public void Insert(Bilgi Entity)
        {
             _OgrBilgiDal.Insert(Entity);
        }

        public void Update(Bilgi Entity)
        {
            _OgrBilgiDal.Update(Entity);
        }
    }
}
