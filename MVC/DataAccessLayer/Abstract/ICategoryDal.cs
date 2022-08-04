using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepossitory<Category>
    {
        ////DRY Araştır Neden sınıflara değilde interface oluşturuyoruz
        ////CRUD İşlemleri Metotları Tanımlanır
        ////Type Name(); == Metot Tanımlama Yöntemi
        //List<Category> List();

        //void Insert(Category p); //Category sınıfındaki property leri kullanmak için bir parametre atadık

        //void Update(Category p);

        //void Delete(Category p);

        ////Metotların Görevleri Tanımlancak bunlar Repossitories(Depolar) olan yerde tanımlancak
    }
}
