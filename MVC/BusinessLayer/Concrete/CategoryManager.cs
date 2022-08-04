using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repossitories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategortDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategortUpdate(Category category)
        {
           _categorydal.update(category);
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x=>x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }



        //public void CategoryAddBl(Category p)
        //{
        //    if(p.CategoryName=="" || p.CategoryDurum==false || p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categorydal.Insert(p);
        //    }

        //}



        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBl()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBl(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryAçıklama == "" ||
        //        p.CategoryDurum == false || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
    }
}


