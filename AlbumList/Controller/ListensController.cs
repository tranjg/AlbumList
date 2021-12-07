using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlbumList.Models;

namespace AlbumList.Controllers
{
    public class ListensController : Controller
    {
        protected Repository<ListensModel> Listens { get; set; }

        public ListensController(AlbumContext ctx)
        {
            Listens = new Repository<ListensModel>(ctx);
        }

        [Route("/Home/Listens", Name = "listens")]
        public IActionResult Index() => View(Listens.List());

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ListensModel s)
        {
            if (ModelState.IsValid)
            {
                Listens.Insert(s);
                Listens.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }
    }
}
