using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd (Category category);
        Category GetByID(int id);
        void CategortDelete(Category category);
        void CategortUpdate(Category category);

    }
}
