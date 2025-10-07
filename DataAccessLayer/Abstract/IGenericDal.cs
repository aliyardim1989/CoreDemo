using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Dışarıdan 1 Parametre olarak T göndermem lazım
    //T 1 class a ait bütün değerleri kullanacak.
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll();
        T GetByID(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);

    }
}
