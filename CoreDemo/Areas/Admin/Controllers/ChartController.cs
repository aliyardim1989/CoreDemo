using CoreDemo.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Bu Action Category lerin Action ğzerinde Listeleneceği Action olacak. 


        //Verilerime Statik olarak değer atayacak. 
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 2
            });


            return Json(new { jsonlist = list });
        }

    }
}
