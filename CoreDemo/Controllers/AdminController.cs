using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Sadece Sol Tarftaki Menüleri tutacak.
        public PartialViewResult AdminNavbarPartial()
        {

            return PartialView();
        }


    }
}
