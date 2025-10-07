using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Status";
            //wm.WriterAdd(p);
            wm.TAdd(p);
            return RedirectToAction("Index", "Blog");

            //Doğrusu Aşağıda Ama Çalışmadı

            //WriterValidator wv = new WriterValidator();
            //ValidationResult results = wv.Validate(p);
            //if (results.IsValid)
            //{
            //    p.WriterStatus = true;
            //    p.WriterAbout = "Deneme Status";
            //    wm.WriterAdd(p);
            //    return RedirectToAction("Index", "Blog");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.propertName, item.ErrorMessage);
            //    }
            //}
            //return View();
        }


    }
}
