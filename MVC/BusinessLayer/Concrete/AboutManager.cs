using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutydal;

        public AboutManager(IAboutDal aboutydal)
        {
            _aboutydal = aboutydal;
        }

        public void AboutAdd(About about)
        {
            _aboutydal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _aboutydal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutydal.update(about);
        }

        public About GetByID(int id)
        {
            return _aboutydal.Get(x=>x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _aboutydal.List();
        }
    }
}
