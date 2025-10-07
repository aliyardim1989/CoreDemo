using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory(); //SAdece ilgili Entity e ait tanımlama yapmak için kullanıyoruz.
        List<Blog> GetListWithCategoryByWriter(int id);



    }
}
