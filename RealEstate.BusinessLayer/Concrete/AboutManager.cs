using RealEstate.BusinessLayer.Abstract;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutService _aboutservice;

        public AboutManager(IAboutService aboutservice)
        {
            _aboutservice = aboutservice;
        }

        public List<About> GetList()
        {
          return _aboutservice.GetList();
        }

        public void TDelete(About t)
        {
           _aboutservice.TDelete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(About t)
        {
            _aboutservice.TInsert(t);
        }

        public void TUpdate(About t)
        {
           _aboutservice.TUpdate(t);
        }
    }
}
