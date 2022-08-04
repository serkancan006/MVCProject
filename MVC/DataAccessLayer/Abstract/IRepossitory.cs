using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepossitory<T>  //T bir Entity yi Yani Bir tabloyu ifade eder
    {
        List<T> List();

        void Insert(T p);

        T Get(Expression<Func<T, bool>> predicate);

        void Delete(T p);

        void update(T p);

        List<T> List(Expression<Func<T, bool>> filter);    //Şartlı Lİsteleme
    }
}
