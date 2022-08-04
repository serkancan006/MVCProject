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
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void AdmintDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.update(admin);
        }

        public void AdminyAdd(Admin admin)
        {
            _admindal.Insert(admin);
        }

        public Admin GetByID(int id)
        {
            return _admindal.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _admindal.List();
        }
    }
}
