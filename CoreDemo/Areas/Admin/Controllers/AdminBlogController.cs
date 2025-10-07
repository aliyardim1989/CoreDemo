using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            //Burada bunun içerisinde hem kategorisi hem de yazarı olmalı GetBlogListWithCategory ile yaptık. 
            //GetBlogListWithCategory
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }


    }
}
