using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AdminyAdd(Admin admin);
        Admin GetByID(int id);
        void AdmintDelete(Admin admin);
        void AdminUpdate(Admin admin);
    }
}
