using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]

    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            //Listeyi Convert Ederek jsonWriters ın içine attım.
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        //Dışarıdan gönderdiğim Değere göre O Parametreyi almak istiyorum...
        public IActionResult GetWriterByID(int writerId)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerId);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

        public IActionResult DeleteWriter(int id)
        {
            var writerDelete = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writerDelete);
            return Json(writerDelete);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writerUpdate = writers.FirstOrDefault(x => x.Id == w.Id);
            writerUpdate.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name = "Ayşe"
            },
            new WriterClass
            {
                Id = 2,
                Name = "Ahmet"
            },
            new WriterClass
            {
                Id = 3,
                Name = "Buse"
            }
        };
    }
}