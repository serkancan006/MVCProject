using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repossitories
{
    public class CategoryRepossitories : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;


        public void Delete(Category p)
        {
            var x = c.Entry(p);
            x.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            var x = c.Entry(p);
            x.State = EntityState.Added;
           // _object.Add(p);
            c.SaveChanges();
            //ENtity Framework da klasik ado net deki karşılığı nedir savechanges komutu için
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            var x = c.Entry(p);
            x.State = EntityState.Modified;
            c.SaveChanges();
        }

        public void update(Category p)
        {
            var x = c.Entry(p);
            x.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
/*
ToList
Add
Remove
Find

 */
